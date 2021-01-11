using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Jokes.Interfaces;
using Jokes.Models;
using Jokes.Dtos;
using AutoMapper;

namespace Jokes.Controllers{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase{

        private readonly IJokes _repository;
        private readonly IMapper _mapper;

        public JokeController(IJokes repository, IMapper mapper){
            //inject dep
            _repository = repository;
            _mapper = mapper;
        }

        // instead of doing a class based approach I'm switching it to the interface
        // private readonly MockJoke _repository = new MockJoke();

        //GET api/jokes
        [HttpGet]
        public ActionResult<IEnumerable<JokeReadDto>> GetAllJokes(){
            var jokeItems = _repository.GetJokes();

            return Ok(_mapper.Map<IEnumerable<JokeReadDto>>(jokeItems));
        }

        //GET api/jokes/:id
        [HttpGet("{id}", Name="GetJokeByID")]
        public ActionResult<JokeReadDto> GetJokeByID(int id){
            var jokeItem = _repository.GetJokeById(id); //get id from binding source, uri parameters
            if(jokeItem != null){
                return Ok(_mapper.Map<JokeReadDto>(jokeItem));
            }
            return NotFound();
        }

        //GET api/jokes
        [HttpPost]
        public ActionResult<JokeReadDto> CreateJoke(JokeCreateDto jokeCreateDto){
            var jokeModel = _mapper.Map<Joke>(jokeCreateDto);
            _repository.CreateJoke(jokeModel);
            _repository.SaveChanges();
            var jokeReadDto = _mapper.Map<JokeReadDto>(jokeModel);

            return CreatedAtRoute(nameof(GetJokeByID), new {Id = jokeReadDto.Id}, jokeReadDto);
        }
    }
}