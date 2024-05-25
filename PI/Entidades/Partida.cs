using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Partida
    {
        private Dictionary<int,Jogador> jogadores;
        private List<int> idJogadores;
        private int pontuacao;
        private Form formularioPartida;
        private int idPartida;
        private List<Panel> cartasJogadas;
        private string numeroRodada = "";

        private GerenciadorStrings gerenciadorDeStrings;

        public Partida(Dictionary<int,Jogador> jogadores, List<int> idJogadores,Form formularioPartida,int idPartida)
        {
            gerenciadorDeStrings = new GerenciadorStrings(idPartida);
            this.jogadores = jogadores;
            this.idJogadores = idJogadores;
            this.idPartida = idPartida;
            this.formularioPartida = formularioPartida;
            cartasJogadas = new List<Panel>();
        }

        public void JogarCarta()
        {

            TextBox txtIdJogador = formularioPartida.Controls.Find("txtIdJogador", true).FirstOrDefault() as TextBox;
            TextBox txtSenhaJogador = formularioPartida.Controls.Find("txtSenhaJogador", true).FirstOrDefault() as TextBox;
            TextBox txtIdCarta = formularioPartida.Controls.Find("txtIdCarta", true).FirstOrDefault() as TextBox;

            string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao jogar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCartaJogada();
            ExibirCartaJogada();
            //CartasJogadas.Add(carta);
        }   

        public void RemoverCartaJogada()
        {
            string[] CartasJogadas = gerenciadorDeStrings.ObterJogadas();
            if (CartasJogadas[0] == "") return;

            foreach(string carta in CartasJogadas)
            {
                int idJogador = int.Parse(carta.Split(',')[1]);
                int idCarta = int.Parse(carta.Split(',')[4]);
                char naipeCarta = char.Parse(carta.Split(',')[2]);

                if (jogadores[idJogador].Cartas.cartas[idCarta] != null)
                {
                    Jogador jogador = jogadores[idJogador];
                    string path = jogador.Posicao.SilhuetaCarta;
                    jogadores[idJogador].JogarCarta(idCarta,path,naipeCarta);
                }
            }
        }


        public void ExibirCartaJogada()
        {
            string[] jogadas = gerenciadorDeStrings.ObterJogadas();
            if (jogadas[0] == "") return;

            string[] ultimaRodada = jogadas[jogadas.Length - 1].Split(',');

            int x = 1300;


            if (numeroRodada != ultimaRodada[0])
            {
                numeroRodada = ultimaRodada[0];
                LimparCartasJogadas(cartasJogadas);
            }

            foreach (string jogada in jogadas)
            {

                string[] rodada = jogada.Split(',');
                if (rodada[0] == ultimaRodada[0])
                {
                    string naipeCarta = rodada[2];
                    string numeroCarta = rodada[3];
                    string diretorioAtual = Directory.GetCurrentDirectory();
                    string caminhoImagem = Path.Combine(diretorioAtual, "../../Cards/numeros/", $"{numeroCarta}{naipeCarta}.png");

                    Panel carta = new Panel();
                    carta.BackgroundImage = Image.FromFile(caminhoImagem);
                    carta.Height = 231;
                    carta.Width = 143;
                    carta.Left = x;
                    carta.Top = 367;
                    Label nomeJogador = new Label();
                    nomeJogador.Text = jogadores[int.Parse(rodada[1])].nome;
                    nomeJogador.AutoSize = true;
                    nomeJogador.Left = x + carta.Width / 2 - 15;
                    nomeJogador.Top = 608;


                    carta.BackgroundImageLayout = ImageLayout.Stretch;
                    formularioPartida.Controls.Add(carta);
                    formularioPartida.Controls.Add(nomeJogador);
                    x -= 164;
                    cartasJogadas.Add(carta);
                }
            }

        }

        public void LimparCartasJogadas(List<Panel> cartasJogadas)
        {
                foreach (Panel carta in cartasJogadas)
                {
                    formularioPartida.Controls.Remove(carta);
                }
                cartasJogadas.Clear();
        }

        private void AtualizarEstadoPartida()
        {
            
        }

        public void AtualizarPontuacaoJogadores()
        {
            foreach(int Id in idJogadores)
            {
                jogadores[Id].ObterPontuacaoPartida();
                jogadores[Id].ObterPontuacaoTurno();
            }
        }

    }
}
