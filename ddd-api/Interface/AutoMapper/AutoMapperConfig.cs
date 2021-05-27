using AutoMapper;
using Common.DTO.Cadastro;
using Domain.Modules.Cadastro;

namespace Interface.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}
