using Microsoft.AspNetCore.Mvc;
using Example.Models;
using System.Collections.Generic;

namespace Example.Controllers{
    [Route("api/jokes")]
    [ApiController]
    public class ExampleController : ControllerBase{
        public ActionResult<IEnumerable<Example>> GetAllExamples(){

        }

        public ActionResult<Example> GetExampleByID(int id){

        }
    }
}