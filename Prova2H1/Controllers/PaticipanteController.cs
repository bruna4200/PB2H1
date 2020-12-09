using Microsoft.AspNetCore.Mvc;
using Prova2H1.Models;
using Prova2H1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipanteController : ControllerBase
    {


        private readonly IParticipanteService _PacienteServices;

        public ParticipanteController(ParticipanteController services)
        {
            _PacienteServices = (IParticipanteService)services;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Participante participantes)
        {
            _PacienteServices.InserirParticipante(participantes);
            return Ok("Participante cadastrado com sucesso.");
        }
        [HttpGet("{NumEscolhido}")]
        public async Task<int> Get(int numEscolhido)
        {
            int[] num = new int[100];
            Random r = new Random();

            for (int i = 0; i < num.length; i++)
            {
                num[i] = r.nextInt(60) + 1; //Dentro do Array num[i] não pode haver números repetidos, então, como fazer?
            }
        }
    }
}