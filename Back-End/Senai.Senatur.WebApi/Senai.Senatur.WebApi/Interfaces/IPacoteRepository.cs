using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi
{
    interface IPacoteRepository
    {
        List<Pacote> Listar();

        void Cadastrar(Pacote pacote);


        void Alterar(int id, Pacote pacote);

        Pacote BuscarPacotePorId(int id);
    }
}
