using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Jokes.Interfaces;
using Jokes.Models;

namespace Jokes.Controllers{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase{

        private readonly IJokes _repository;

        public JokeController(IJokes repository){
            //inject dep
            _repository = repository;
        }

        // instead of doing a class based approach I'm switching it to the interface
        // private readonly MockJoke _repository = new MockJoke();

        //GET api/jokes
        [HttpGet]
        public ActionResult<IEnumerable<Joke>> GetAllJokes(){
            var jokeItems = _repository.GetJokes();

            return Ok(jokeItems);
        }

        //GET api/jokes/:id
        [HttpGet("{id}")]
        public ActionResult<Joke> GetJokeByID(int id){
            var jokeItem = _repository.GetJokeById(id); //get id from binding source, uri parameters

            return Ok(jokeItem);
        }
    }
}