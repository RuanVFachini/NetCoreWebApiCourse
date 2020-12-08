using AutoMapper;
using WebApiCourse.API.DTO;
using WebApiCourse.API.ExtensionsMethods;
using WebApiCourse.Domain.Models;

namespace WebApiCourse.API.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Aluno, AlunoDTO>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => src.Nome + " " + src.Sobrenome)
                )
                .ForMember(
                    dest => dest.Idade,
                    opt => opt.MapFrom(src => src.DataNasc.GetCurrentAge())
                );
            
            CreateMap<AlunoRequestDTO, Aluno>();

        }
    }
}