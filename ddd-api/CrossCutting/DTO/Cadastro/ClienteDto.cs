using System;

namespace Common.DTO.Cadastro
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; }

        public string Ativo { get; set; }
    }
}
