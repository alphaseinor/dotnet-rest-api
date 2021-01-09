using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Jokes.Data;
using Jokes.Models;

namespace Jokes.Controllers{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase{
        private readonly MockJoke _repository = new MockJoke();

        //GET api/jokes
        [HttpGet]
        public ActionResult<IEnumerable<Joke>> GetAllJokes(){

        }

        //GET api/jokes/:id
        [HttpGet("{id}")]
        public ActionResult<Joke> GetJokeByID(int id){

        }
    }
}