using Microsoft.EntityFrameworkCore;
using Jokes.Models;

namespace Jokes.Interfaces{
    public class JokeContext : DbContext{
        public JokeContext(DbContextOptions<JokeContext> opt) : base(opt){
            
        }

        public DbSet<Joke> Jokes { get; set;}
    }
}