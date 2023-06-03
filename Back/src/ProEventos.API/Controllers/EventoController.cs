using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                EventoId = 1,
                Tema = "Angular e .NET",
                Local = "Curitiba",
                Lote = "Primeiro Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemURL = "foto.png"
                },

                new Evento(){
                EventoId = 2,
                Tema = "Angular e .NET",
                Local = "SP",
                Lote = "Primeiro Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(10).ToString(),
                ImagemURL = "foto.png"
                }
            };
        public EventoController(){

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }

        [HttpPut("{id:int}")]
        public string Put(int id)
        {
            return $"Exemplo Put com id = {id}";
        }

        [HttpDelete("{id:int}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com id = {id}";
        }
    }
}
