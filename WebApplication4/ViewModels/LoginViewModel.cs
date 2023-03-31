using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "O formato de email é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }
    }
}