using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Carta
    {
        public char Naipe { get;}
        public int IdDaCarta { get;}
        public Panel ImagemDaCarta { get; set; }

        public Carta(char naipe, int idDaCarta)
        {
            Naipe = naipe;
            IdDaCarta = idDaCarta;
        }

    }
}
