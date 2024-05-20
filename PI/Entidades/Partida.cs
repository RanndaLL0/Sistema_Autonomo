using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Partida
    {
        private List<Carta> CartasJogadas;
        private Dictionary<int,Jogador> Jogadores;
        private List<int> IdJogadores;
        private int Pontuacao;
        private int IdPartida;
        private Form Game;

        public Partida(Dictionary<int,Jogador> jogadores, List<int> idJogadores,Form game,int idPartida)
        {
            IdPartida = idPartida;
            CartasJogadas = new List<Carta>();
            Jogadores = jogadores;
            IdJogadores = idJogadores;
            Game = game;
        }

        public void JogarCarta()
        {

            TextBox txtIdJogador = Game.Controls.Find("txtIdJogador", true).FirstOrDefault() as TextBox;
            TextBox txtSenhaJogador = Game.Controls.Find("txtSenhaJogador", true).FirstOrDefault() as TextBox;
            TextBox txtIdCarta = Game.Controls.Find("txtIdCarta", true).FirstOrDefault() as TextBox;

            string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao jogar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCarta();
            //CartasJogadas.Add(carta);
        }   

        public void RemoverCarta()
        {
            string[] CartasJogadas = GerenciadorDeStrings.ObterJogadas(IdPartida);
            foreach(string carta in CartasJogadas)
            {
                int idJogador = int.Parse(carta.Split(',')[1]);
                int idCarta = int.Parse(carta.Split(',')[4]);
                char naipeCarta = char.Parse(carta.Split(',')[2]);

                if (Jogadores[idJogador].Baralho.cartas[idCarta] != null)
                {
                    Jogador jogador = Jogadores[idJogador];
                    string path = jogador.Posicao.SilhuetaCarta;
                    Jogadores[idJogador].Baralho.RemoverCarta(idCarta,Game,path,naipeCarta);
                }
            }
        }

        public void AtualizarPontuacaoJogadores()
        {
            foreach(int Id in IdJogadores)
            {
                Jogadores[Id].ObterPontuacaoPartida();
                Jogadores[Id].ObterPontuacaoTurno();
            }
        }

    }
}
