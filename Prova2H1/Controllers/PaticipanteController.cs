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


        private readonly IParticipanteService _services;

        public ParticipanteController(IParticipanteService services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Participante participantes)
        {
            _services.InserirParticipante(participantes);
            return Ok("Participante cadastrado com sucesso.");
        }
    }
}