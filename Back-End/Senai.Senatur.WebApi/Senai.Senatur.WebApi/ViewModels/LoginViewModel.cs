using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é necessário.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "O e-mail deve ter entre 5 e 200 caractéres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é necessária.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "A senha deve ter entre 3 e 100 caractéres.")]
        public string Senha { get; set; }
    }
}