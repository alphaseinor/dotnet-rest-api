using System.Collections.Generic;
using Example.Models;

namespace Example.Data{
    public class MockExample : IExample{
        IEnumerable<Example> GetAppExamples(){
            var jokes = new List<Example>{
                new Example{id=0, setUp="What do you call someone without a nose or a body", punchLine="Nobody Knows"},
                new Example{id=1, setUp="What concert costs just 45 cents", punchLine="50 Cent featuring Nickelback"},
                new Example{id=2, setUp="Did you hear about the guy who invented the knock-knock joke", punchLine="He won the nobell prize"}
            };

            return jokes;
        }

        Example GetExampleByID(int id){
            return new Example{id=0, setUp="I don't trust stairs", punchLine="They're always up to something"}
        }
    }
}