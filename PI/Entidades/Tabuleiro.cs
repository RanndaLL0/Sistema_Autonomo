using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades
{
    public class Tabuleiro
    {
        private List<Carta> CartasJogadas;
        private int Pontuacao;

        public Tabuleiro()
        {
            CartasJogadas = new List<Carta>();
        }

        public void JogarCarta(Carta carta)
        {
            CartasJogadas.Add(carta);
        }   

        public void Vencedor()
        {
            int max = 0;
            foreach(Carta c in CartasJogadas)
            {
                if(c.Valor > max)
                {
                    max = c.Valor;
                }
            }
        }
    }
}
