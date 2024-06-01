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
        private Form formularioPartida;
        private List<Label> nomes;
        private List<Panel> cartasJogadas;
        public Bot bot;
        private RenderizadorCartas Renderizador;

        private int pontuacao;
        private int idPartida;
        private string numeroRodada = string.Empty;
        public string primeiraCartaRound = string.Empty;
        private bool cartasAtualizadasNaRodada1 = true;
        bool atribuiuPrimeiraCarta = true;

        private GerenciadorStrings gerenciadorDeStrings;

        public Partida(Dictionary<int,Jogador> jogadores, List<int> idJogadores,Form formularioPartida,int idPartida)
        {
            this.jogadores = jogadores;
            this.idJogadores = idJogadores;
            this.idPartida = idPartida;
            this.formularioPartida = formularioPartida;

            cartasJogadas = new List<Panel>();

            nomes = new List<Label>();
            Renderizador = new RenderizadorCartas(formularioPartida,jogadores,idPartida);
            Renderizador.Renderizar();
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

        public void JogarCarta(int idJogador,string senhaJogador,int idCarta)
        {

            string retornoJogada = Jogo.Jogar(idJogador, senhaJogador, idCarta);
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao jogar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCartaJogada();
            ExibirCartaJogada();
            AtualizarEstadoPartida();
            //CartasJogadas.Add(carta);
        }


        public void ApostarCarta()
        {

            TextBox txtIdJogador = formularioPartida.Controls.Find("txtIdJogador", true).FirstOrDefault() as TextBox;
            TextBox txtSenhaJogador = formularioPartida.Controls.Find("txtSenhaJogador", true).FirstOrDefault() as TextBox;
            TextBox txtIdCarta = formularioPartida.Controls.Find("txtIdCarta", true).FirstOrDefault() as TextBox;

            string retornoJogada = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao apostar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCartaApostada();
        }

        public void ApostarCarta(int idJogador, string senhaJogador, int idCarta)
        {

            string retornoJogada = Jogo.Apostar(idJogador, senhaJogador, idCarta);
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao apostar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCartaApostada();
        }

        public void RemoverCartaApostada()
        {
            List<string> CartasApostadas = GerenciadorStrings.ObterCartasApostadas(idPartida);
            if (CartasApostadas == null) return;

            foreach (string carta in CartasApostadas)
            {
                int idJogador = int.Parse(carta.Split(',')[0].Substring(2));
                int idCarta = int.Parse(carta.Split(',')[4]);
                char naipeCarta = char.Parse(carta.Split(',')[1]);

                if (jogadores[idJogador].Cartas.cartas[idCarta] != null)
                {
                    Jogador jogador = jogadores[idJogador];
                    string path = jogador.Posicao.SilhuetaCarta;
                    jogadores[idJogador].JogarCarta(idCarta, path, naipeCarta);
                }
            }
        }

        public void RemoverCartaJogada()
        {
            string[] CartasJogadas = GerenciadorStrings.ObterJogadas(idPartida);
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
            string[] jogadas = GerenciadorStrings.ObterJogadas(idPartida);
            if (jogadas[0] == "") return;

            string[] ultimaRodada = jogadas[jogadas.Length - 1].Split(',');

            int x = 1300;

            if (numeroRodada != ultimaRodada[0])
            {
                numeroRodada = ultimaRodada[0];
                primeiraCartaRound = string.Empty;
                atribuiuPrimeiraCarta = true;
                LimparCartasJogadas(cartasJogadas);
                LimparLabels(nomes);
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
                    carta.BackColor = Color.Transparent;
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

                    if(atribuiuPrimeiraCarta)
                    {
                        primeiraCartaRound = naipeCarta;
                        atribuiuPrimeiraCarta = false;
                    }

                    cartasJogadas.Add(carta);
                    nomes.Add(nomeJogador);
                }
            }

        }

        private void LimparCartasJogadas(List<Panel> cartasJogadas)
        {
            foreach (Panel carta in cartasJogadas)
            {
                formularioPartida.Controls.Remove(carta);
            }
            cartasJogadas.Clear();
        }

        private void LimparLabels(List<Label> nomes)
        {
            foreach (Label nome in nomes)
            {
                formularioPartida.Controls.Remove(nome);
            }
            nomes.Clear();
        }

        public void AtualizarEstadoPartida()
        {
            string[] vez = GerenciadorStrings.ObterVez(idPartida);
            string rodada = vez[0].Split(',')[2];
            if (rodada == "1" && !cartasAtualizadasNaRodada1)
            {
                string[] todasAsCartas = GerenciadorStrings.ObterCartasDaPartida(idPartida);
                RemoverCartasDaMao(jogadores);
                primeiraCartaRound = string.Empty;
                foreach (string carta in todasAsCartas)
                {
                    string[] informacoesDaCarta = carta.Split(',');
                    int idJogador = int.Parse(informacoesDaCarta[0]);
                    int idCarta = int.Parse(informacoesDaCarta[1]);
                    char naipe = char.Parse(informacoesDaCarta[2]);
                    jogadores[idJogador].Cartas.AdicionarCarta(naipe, idCarta);
                }

                cartasAtualizadasNaRodada1 = true;
                Renderizador.RemoverPanels();
                Renderizador.ResetarPosicoes();
                Renderizador.Renderizar();
            }
            if(rodada == "2")
            {
                cartasAtualizadasNaRodada1 = false;
            }
        }

        private void RemoverCartasDaMao(Dictionary<int, Jogador> jogadores)
        {
            foreach (int chave in jogadores.Keys)
            {
                jogadores[chave].Cartas.cartas.Clear();
            }
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
