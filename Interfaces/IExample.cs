using System.Collections.Generic;
using Example.Models;

namespace Example.Data{
    public interface IExample{
        IEnumerable<IExample> GetAppExamples();
        Command GetExamplesById(int id);
        
    }
}