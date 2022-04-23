using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o Login!")]
        public string login { get; set; }
        [Required(ErrorMessage = "Digite a sua senha!")]
        public string Senha { get; set; }
    }
}
