using System.Collections.Generic;
using Jokes.Models;

namespace Jokes.Interfaces{
    public interface IJokes{
        IEnumerable<Joke> GetJokes();
        Joke GetJokeById(int id);
        
    }
}