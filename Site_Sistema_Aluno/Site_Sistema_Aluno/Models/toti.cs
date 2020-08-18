using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site_Sistema_Aluno.Models
{
    public class toti
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informe o seu nome!")]
        [StringLength(60, MinimumLength = 6)]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = " Favor informe a sua nacionalidade.!")]
        [StringLength(20, MinimumLength = 4)]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O campo cidade é obrigatório.")]
        [StringLength(30)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Favor digite a sua data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = " email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}