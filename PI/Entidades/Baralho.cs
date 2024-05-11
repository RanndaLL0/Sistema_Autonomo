using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades
{
    public class Baralho
    {
        private List<Carta> cartas;

        public Baralho()
        {
            cartas = new List<Carta>();
        }

        public void AdicionarCarta(char naipe,int idCarta)
        {
            cartas.Add(new Carta(naipe, idCarta));
        }

        public Carta RemoverCarta()
        {
            return null;
        }
    }
}
