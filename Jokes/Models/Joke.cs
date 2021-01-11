using System.ComponentModel.DataAnnotations;

namespace Jokes.Models
{
    public class Joke{
        [Key]
        public int Id { get; set;}
        [Required]
        public string setUp {get; set;}
        [Required]
        public string punchLine {get; set;}
    }
}


