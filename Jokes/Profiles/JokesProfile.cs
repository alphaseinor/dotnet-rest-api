using AutoMapper;
using Jokes.Models;
using Jokes.Dtos;

namespace Jokes.Profiles{
    public class JokesProfile : Profile{
        public JokesProfile()
        {
            CreateMap<Joke, JokeReadDto>();
        }
    }
}