using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.Senatur.WebApi.Domains;

namespace Senai.Senatur.WebApi.Repository
{
    public class PacoteRepository : IPacoteRepository
    {
        SenaturContext ctx = new SenaturContext();
        private string StringConexao = "Data Source=DEV4\\SQLEXPRESS;" +
            "initial catalog=Senatur_Manha;" +
            "integrated security=true";

        public void Alterar(int id,Pacote pacoteAtualizar)
        {
            Pacote pacoteBuscado = ctx.Pacote.Find(id);

            if(pacoteAtualizar.NomePacote != null)
            {
                pacoteBuscado.NomePacote = pacoteAtualizar.NomePacote;
            }

            ctx.Pacote.Update(pacoteBuscado);

            ctx.SaveChanges();
        }

        public Pacote BuscarPacotePorId(int id)
        {
            return ctx.Pacote.FirstOrDefault(e => e.IdPacote == id);
        }

        public void Cadastrar(Pacote pacote)
        {
            ctx.Pacote.Add(pacote);

            ctx.SaveChanges();
        }

        public List<Pacote> Listar()
        {
            return ctx.Pacote.ToList();
        }
    }
}
