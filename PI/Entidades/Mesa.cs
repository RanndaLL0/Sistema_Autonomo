using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades
{
    public class Mesa
    {
        private List<Jogador> player;
        private Baralho baralho;
        private Tabuleiro tabuleiro;
        private int Pontuacao;

        public Mesa()
        {
            player = new List<Jogador>();
            baralho = new Baralho();
            tabuleiro = new Tabuleiro();
        }

        public void Inicio()
        {
            Distribuir();
        }

        private void Distribuir()
        {

        }

        public void Vencedor()
        {
            tabuleiro.Vencedor();   
        }
    }
}
