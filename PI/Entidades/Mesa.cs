using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Mesa
    {
        private Dictionary<int, Jogador> Jogadores;
        private List<ConfiguracaoMao> Maos;
        private Baralho baralho;
        private Tabuleiro tabuleiro;
        private int IdPartida;
        private string[] JogadorNaMaquina;

        public Mesa(string[] jogadorNaMaquina)
        {
            Maos = new List<ConfiguracaoMao>();
            baralho = new Baralho();
            tabuleiro = new Tabuleiro(Jogadores);
            JogadorNaMaquina = jogadorNaMaquina;
        }

        public void Inicio()
        {
            Distribuir();
        }

        private void Distribuir()
        {
            string[] todasAsCartas = GerenciadorDeStrings.ObterCartasDaPartida(IdPartida);

            foreach(string carta in todasAsCartas)
            {
                string[] informacoesDaCarta = carta.Split(',');
                int idJogador = int.Parse(informacoesDaCarta[0]);
                char naipe = char.Parse(informacoesDaCarta[1]);
                int idCarta = int.Parse(informacoesDaCarta[2]);

                Jogadores[idJogador].Baralho.AdicionarCarta(naipe,idCarta);
            }
        }

        public void ExibirCartas()
        {

        }
    }
}
