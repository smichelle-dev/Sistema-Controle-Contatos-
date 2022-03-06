using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
       public int id { get; set; }
        [Required(ErrorMessage ="Digite o nome do contato")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage ="O e-mail informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage ="O celular informado não é válido")]
        public string Celular { get; set; }

    }
}
