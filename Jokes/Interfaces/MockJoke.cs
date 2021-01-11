using System.Collections.Generic;
using Jokes.Models;

namespace Jokes.Interfaces{
    public class MockJoke : IJokes{
        public IEnumerable<Joke> GetJokes(){
            var jokes = new List<Joke>{
                new Joke{Id=0, setUp="What do you call someone without a nose or a body", punchLine="Nobody Knows"},
                new Joke{Id=1, setUp="What concert costs just 45 cents", punchLine="50 Cent featuring Nickelback"},
                new Joke{Id=2, setUp="Did you hear about the guy who invented the knock-knock joke", punchLine="He won the nobell prize"}
            };

            return jokes;
        }

        public Joke GetJokeById(int id){
            return new Joke{Id=0, setUp="I don't trust stairs", punchLine="They're always up to something"};
        }

        public bool SaveChanges(){
            throw new System.NotImplementedException();
        }

        public void CreateJoke(Joke joke){
            throw new System.NotImplementedException();
        }
    }
}