using System.Collections.Generic;
using Jokes.Models;
using System.Linq;

namespace Jokes.Interfaces{
    public class SqlJokes : IJokes{
        private readonly SqlJokes _context;

        public SqlJokes(JokeContext context)
        {
            _context = context;
        }
        public IEnumerable<Joke> GetJokes(){
            return _context.Commands.ToList();
        }
        public Joke GetJokeById(int id){
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }
    }
}