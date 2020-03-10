using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SenaturContext ctx = new SenaturContext();
        private string StringConexao = "Data Source=DEV7\\SQLEXPRESS;" +
            "initial catalog=Senatur_Manha;" +
            "integrated security=true";

        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }
    }
}