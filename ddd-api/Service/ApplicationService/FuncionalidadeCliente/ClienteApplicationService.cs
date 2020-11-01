using Common.DTO.FuncionalidadeCliente;
using Infrastructure.UnitOfWork.FuncionalidadeCliente;
using Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.ApplicationService
{
    public class ClienteApplicationService : BaseService
    {
        private readonly ClienteUnitOfWork _uow;

        public ClienteApplicationService(ClienteUnitOfWork uow,
                                         INotificador notificador) : base(notificador)
        {
            _uow = uow;
        }
        public async Task<List<ClienteDto>> GetAll()
        {
            var query = _uow.ClienteRepository.GetAll();

            var dto = query.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Cpf = x.Cpf,
                DataNascimento = x.DataNascimento,
                Ativo = x.Ativo
            }).ToList();

            return dto;
        }

        public async Task<List<ClienteDto>> GetAllWithError()
        {
            Notificar("Gerar Um Erro Aleatorio para testar");

            var query = _uow.ClienteRepository.GetAll();

            var dto = query.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Cpf = x.Cpf,
                DataNascimento = x.DataNascimento,
                Ativo = x.Ativo
            }).ToList();

            return dto;
        }


        //public ProdutoDto GetById(int id)
        //{
        //    var query = _uow.ProdutoRepository.GetById(id);

        //    var dto = query.Select(x => new ProdutoDto
        //    {

        //        Id = x.Id,
        //        Nome = x.Nome,

        //    }).FirstOrDefault();

        //    return dto;
        //}

        //public void Update(ProdutoDto dto, int id)
        //{
        //    var query = _uow.ProdutoRepository.GetById(id);

        //    var produto = query.FirstOrDefault();

        //    produto.Nome = dto.Nome;
        //    produto.Preco = dto.Preco;
        //    produto.IdCategoria = dto.IdCategoria;

        //    _uow.Commit();

        //}

        //public void Delete(int id)
        //{
        //    var query = _uow.ProdutoRepository.GetById(id);
        //    var produto = query.FirstOrDefault();

        //    _uow.ProdutoRepository.Delete(produto);
        //    _uow.Commit();

        //}

        //public void Insert(ProdutoDto dto)
        //{
        //    var Produtodb = new ProdutoDB
        //    {
        //        Nome = dto.Nome,
        //        IdCategoria = dto.IdCategoria,

        //    };

        //    _uow.ProdutoRepository.Add(Produtodb);
        //    _uow.Commit();

        //}
    }
}
