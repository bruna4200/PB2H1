using Prova2H1.Models;
using Prova2H1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Services
{
    public class IParticipanteRepository
    {
        private readonly IParticipanteRepository pRepository;
        public IParticipanteRepository(
             IParticipanteRepository repository
         )
        {
            pRepository = repository;
        }

        public void InserirParticipante(Participante participante)
        {
            pRepository.InserirParticipante(participante);
        }
    }
}
