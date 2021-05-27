using AutoMapper;
using Common.DTO.Cadastro;
using Domain.Modules.Cadastro;

namespace Interface.Configurations
{
    public class AutoMapperConfigTest : Profile
    {
        public AutoMapperConfigTest()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            //ClienteAutoMapper.ConfigureBindings();
        }
    }
}
