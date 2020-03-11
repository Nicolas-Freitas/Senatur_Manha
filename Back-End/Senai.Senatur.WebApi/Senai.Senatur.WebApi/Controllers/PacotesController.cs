using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;
using Senai.Senatur.WebApi.Repository;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacoteRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Pacote pacote)
        {
            try
            {
                PacoteRepository.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Pacote pacote)
        {
            try
            {
                PacoteRepository.Alterar(id, pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

       
        [HttpGet("{id}")]
        public IActionResult BuscarPacotePorId(int id)
        {
            try
            {
                Pacote pacoteBuscado = PacoteRepository.BuscarPacotePorId(id);

                if (pacoteBuscado == null)
                {
                    return NotFound();
                }

                return Ok(pacoteBuscado);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}