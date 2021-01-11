using System.ComponentModel.DataAnnotations;

namespace Jokes.Dtos{
    public class JokeCreateDto{
        [Required]
        public string setUp {get; set;}
        [Required]
        public string punchLine {get; set;}
    }
}