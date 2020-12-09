using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Models
{
    public class Participante
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int NumEscolhido { get; set; }

        internal void Add(Participante participante)
        {
            new Participante();
        }
    }
}
