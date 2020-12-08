using Prova2H1.Models;
using Prova2H1.Context;
using Prova2H1.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Repository
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        private ParticipanteContext context;
        public void novoParticipante(Participante participante)
        {
            var validator = new ParticipanteValidator();
            var validRes = validator.Validate(participante);
            if (validRes.IsValid)
                context.participante.Add(participante);
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }
    }
}
