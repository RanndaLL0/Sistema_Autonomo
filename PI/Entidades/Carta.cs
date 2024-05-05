using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades
{
    public class Carta
    {
        public char Naipe { get; set; }
        public int Valor { get; set; }

        public Carta(char naipe, int valor)
        {
            Naipe = naipe;
            Valor = valor;
        }
    }
}
