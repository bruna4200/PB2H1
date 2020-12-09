using Prova2H1.Models;
using Prova2H1.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Repository
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        public void InserirParticipante(Participante participante)
        {
            var validator = new ParticipanteValidator();
            var validRes = validator.Validate(participante);
            if (validRes.IsValid)
                participante.Add(participante);
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }
    }
}
