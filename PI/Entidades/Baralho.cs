using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SistemaAutonomo.Entidades
{
    public class Baralho
    {
        public Dictionary<int,Carta> cartas;

        public Baralho()
        {
            cartas = new Dictionary<int, Carta>();
        }

        public void AdicionarCarta(char naipe,int idCarta)
        {
            cartas.Add(idCarta, new Carta(naipe, idCarta));
        }

        public void RemoverCarta(int idCarta,Form game)
        {
            Panel cartaRemovida = cartas[idCarta].ImagemDaCarta;
            cartas.Remove(idCarta);
            game.Controls.Remove(cartaRemovida);
        }
    }
}
