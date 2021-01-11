using System.Collections.Generic;
using Jokes.Models;

namespace Jokes.Interfaces{
    public interface IJokes{
        bool SaveChanges();
        IEnumerable<Joke> GetJokes();
        Joke GetJokeById(int id);
        void CreateJoke(Joke joke);
    }
}