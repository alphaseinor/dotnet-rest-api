using System.Collections.Generic;
using Example.Models;

namespace Example.Data{
    public interface IExample{
        IEnumerable<Example> GetAppCommands(){
            throw new System.NotImplementedException();
        }

        Example GetExampleByID(int id){
            return new Example{id=0, setUp="I don't trust stairs", punchLine="They're always up to something"}
        }
    }
}