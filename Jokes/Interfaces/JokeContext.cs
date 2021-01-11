using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Jokes.Models;
using dotenv.net.Utilities;

namespace Jokes.Interfaces{
    public class JokeContext : DbContext{
        public JokeContext(DbContextOptions<JokeContext> opt) : base(opt){
        }

        public DbSet<Joke> Jokes { get; set;}
    }
}