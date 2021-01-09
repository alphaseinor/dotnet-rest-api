using System.Collections.Generic;
using Jokes.Models;

namespace Jokes.Interfaces{
    public interface IJokes{
        IEnumerable<IJokes> GetAppJokes();
        Joke GetJokeById(int id);
        
    }
}