using Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Modules.Cadastro
{
    [Table("Cliente")]
    public class Cliente : Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Column("Nome")]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Column("Cpf")]
        public string Cpf { get; set; }

        [Required]
        [Column("Ativo")]
        public string Ativo { get; set; }
    }
}
