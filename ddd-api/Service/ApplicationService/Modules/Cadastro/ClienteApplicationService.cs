using Common.DTO.Cadastro;
using CrossCutting.FluentValidations.Cadastro;
using Domain.Modules.Cadastro;
using Infrastructure.UnitOfWork.Modules.Cadastro;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.ApplicationService.Modules.Cadastro
{
    public class ClienteApplicationService : BaseService
    {
        private readonly ClienteUnitOfWork _uow;
        private const string _verifyMessage = "Informações de entrada de Cliente";

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

        public async Task<ClienteDto> GetById(int id)
        {
            var query = _uow.ClienteRepository.GetById(id);
            
            var dto = query.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Cpf = x.Cpf,
                DataNascimento = x.DataNascimento
            }).FirstOrDefault();

            return dto;
        }

        public async Task Insert(ClienteDto dto)
        {
            VerifyExists(dto, _verifyMessage);

            var cliente = await Create(dto);

            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return;

            Validate(cliente);

            if(!OperacaoValida()) return;

            _uow.ClienteRepository.Add(cliente);
            await _uow.CommitAsync();
        }

        public async Task Update(int id, ClienteDto dto)
        {
            VerifyExists(dto, _verifyMessage);

            var cliente = await _uow.ClienteRepository.GetByIdAsync(id);
                            
            VerifyExists(cliente, _verifyMessage);

            await Update(cliente, dto);

            Validate(cliente);

            if (!OperacaoValida()) return;

            _uow.Commit();

        }

        public async Task Delete(int id)
        {
            var cliente = await _uow.ClienteRepository.GetByIdAsync(id);
            VerifyExists(cliente, _verifyMessage);

            _uow.ClienteRepository.Delete(cliente);
            await _uow.CommitAsync();
        }

        private void Validate(Cliente cliente)
        {
            int age = DateTime.Now.Year - cliente.DataNascimento.Year;

            if (age < 18)
                Notificar("Cliente é menor de 18 anos.");
        }

        private async Task<Cliente> Create(ClienteDto dto)
        {
            var cliente = new Cliente()
            {
                Nome = dto.Nome,
                Cpf = dto.Cpf,
                DataNascimento = dto.DataNascimento,
                Ativo = dto.Ativo,
            };

            return cliente;
        }

        private async Task Update(Cliente db, ClienteDto dto)
        {
            db.Nome = dto.Nome;
            db.Cpf = dto.Cpf;
            db.DataNascimento = dto.DataNascimento;
            db.Ativo = dto.Ativo;
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

    }
}
