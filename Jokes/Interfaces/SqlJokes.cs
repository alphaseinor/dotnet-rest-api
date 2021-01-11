using System.Collections.Generic;
using Jokes.Models;
using System.Linq;
using System;

namespace Jokes.Interfaces{
    public class SqlJokes : IJokes{
        private readonly JokeContext _context;

        public SqlJokes(JokeContext context)
        {
            _context = context;
        }
        public IEnumerable<Joke> GetJokes(){
            return _context.Jokes.ToList();
        }
        public Joke GetJokeById(int id){
            return _context.Jokes.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges(){
            return (_context.SaveChanges() >= 0);
        }

        public void CreateJoke(Joke joke){
            if(joke == null){
                throw new ArgumentNullException(nameof(joke));
            }
            _context.Jokes.Add(joke);
        }
    }
}