using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace lobby
{
    public partial class Game : Form
    {
        public string RetornoIniciar { get; set; }
        public int RetornoIdPartida { get; set; }
        public string[] RetornoDados { get; set; }

        private string diretorioAtual = Directory.GetCurrentDirectory();



        public Game()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void AtualizarCartas()
        {
            string CartasList = Jogo.ConsultarMao(RetornoIdPartida);
            if (CartasList.Length > 4 && CartasList.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao verificar ao consultar mão:\n{CartasList.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CartasList = CartasList.Replace("\r", "");
            if (CartasList.Length > 0)
                CartasList = CartasList.Substring(0, CartasList.Length - 1);

            string[] Cartas = CartasList.Split('\n');

            lstCartas.Items.Clear();

            for (int i = 0; i < Cartas.Length; i++)
            {
                lstCartas.Items.Add(Cartas[i]);
            }
        }


        private void RemoverPanels()
        {
            List<Control> panelsParaRemover = new List<Control>();

            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    panelsParaRemover.Add(control);
                }
            }

            foreach (Control panel in panelsParaRemover)
            {
                Controls.Remove(panel);
                panel.Dispose();
            }

        }

        private void MostrarCartas()
        {
            RemoverPanels();

            string conjuntoDeJogadores = Jogo.ListarJogadores(RetornoIdPartida);

            conjuntoDeJogadores = conjuntoDeJogadores.Replace("\r", "");
            if (conjuntoDeJogadores.Length > 0)
                conjuntoDeJogadores = conjuntoDeJogadores.Substring(0, conjuntoDeJogadores.Length - 1);

            string[] listaJogadores = conjuntoDeJogadores.Split('\n');
            int numeroDeJogadores = listaJogadores.Length;

            string idJogadorInicial = RetornoDados[0];
            string[] idJogadores = new string[4]; 

            int indice = 0;

            for (int i = 0; i < numeroDeJogadores; i++)
            {
                string[] partesJogadores = listaJogadores[i].Split(',');
                idJogadores[i] = partesJogadores[0];

                if (idJogadores[i] == idJogadorInicial)
                {
                    indice = i; 
                }
                
            }

            string temp = idJogadores[0];
            idJogadores[0] = idJogadorInicial;
            idJogadores[indice] = temp;


            List<Jogador> jogador = new List<Jogador>();

            if (numeroDeJogadores == 2)
            {
                jogador.Add(new Jogador(850, 850, 690, 690, 0, 91, 137, 97, 0, 0, 143));
                jogador.Add(new Jogador(1335, 1335, 155, 155, 0, 91, 137, -97, 0, 0, -143));
            }
            else
            {
                jogador.Add(new Jogador(800, 800, 690, 690, 0, 91, 137, 97, 0, 0, 143));
                jogador.Add(new Jogador(1382, 1382, 155, 155, 0, 91, 137, -97, 0, 0, -143));
                jogador.Add(new Jogador(620, 620, 147, 147, 0, 137, 91, 0, 97, -143, 0));
                jogador.Add(new Jogador(1516, 1516, 730, 730, 0, 137, 91, 0, -97, 143, 0));
            }


            int contadorDeCartas = 1;
            for (int i = 0; i < numeroDeJogadores; i++)
            {

                for (int j = 0; j < lstCartas.Items.Count; j++)
                {
                    
                    Panel carta = new Panel();
                    string[] pedacoCarta = lstCartas.Items[j].ToString().Split(',');
                    string naipeCarta = pedacoCarta[2];

                    if (pedacoCarta[0] == idJogadores[i] && contadorDeCartas != int.Parse(pedacoCarta[1]))
                    {
                        while (contadorDeCartas != int.Parse(pedacoCarta[1]))
                        {
                            if (numeroDeJogadores == 2 && jogador[i].Count == 6 || numeroDeJogadores > 2 && jogador[i].Count == 7)
                            {
                                jogador[i].X = jogador[i].XInicial + jogador[i].PulaLinhaX;
                                jogador[i].Y = jogador[i].YInicial + jogador[i].PulaLinhaY;
                            }
                            jogador[i].X += jogador[i].DeslocamentoX;
                            jogador[i].Y += jogador[i].DeslocamentoY;
                            jogador[i].Count++;

                            contadorDeCartas++;
                        }
                    }

                    if (pedacoCarta[0] == idJogadores[i])
                    {
                        if (numeroDeJogadores == 2 && jogador[i].Count == 6 || numeroDeJogadores > 2 && jogador[i].Count == 7)
                        {
                            jogador[i].X = jogador[i].XInicial + jogador[i].PulaLinhaX;
                            jogador[i].Y = jogador[i].YInicial + jogador[i].PulaLinhaY;
                        }
                        carta.Left = jogador[i].X;
                        carta.Top = jogador[i].Y;
                        jogador[i].X += jogador[i].DeslocamentoX;
                        jogador[i].Y += jogador[i].DeslocamentoY;
                        jogador[i].Count++;

                        carta.Width = jogador[i].Width;
                        carta.Height = jogador[i].Height;
                        carta.BackgroundImageLayout = ImageLayout.Stretch;
                        string[] diretorios = {Path.Combine(diretorioAtual,"../../Cards/", $"{naipeCarta}.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}invertido.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}dir.png"), Path.Combine(diretorioAtual,"../../Cards/", $"{naipeCarta}esq.png") };
                        carta.BackgroundImage = Image.FromFile(diretorios[i]);


                        Controls.Add(carta);
                    }
                    if (numeroDeJogadores == 2 && int.Parse(pedacoCarta[1]) == 12 || numeroDeJogadores > 2 && int.Parse(pedacoCarta[1]) == 14)
                    {
                        contadorDeCartas = 0;
                    }
                    contadorDeCartas++;

                }

                
            }


        }


        public void IniciarGame()
        {
            VerificarVez();
            AtualizarCartas();
            MostrarCartas();
            txtIdJogador.Text = RetornoDados[0];
            txtSenhaJogador.Text = RetornoDados[1];
            lblVersao.Text = Jogo.Versao;
        }

        private void VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(RetornoIdPartida);
            if (retornoVez.Length > 4 && retornoVez.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao verificar a vez:\n{retornoVez.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] dadosVez = retornoVez.Split(',');
            lblPartidaStatus.Text = dadosVez[0];
            lblIDVez.Text = dadosVez[1];
            lblRodadaVez.Text = dadosVez[2];
            lblStatusVez.Text = dadosVez[3];

        }

        private void MostrarJogada()
        {
            string jogadas = Jogo.ExibirJogadas(RetornoIdPartida);
            if (jogadas.Length > 4 && jogadas.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao verificar a rodada:\n{jogadas.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (jogadas == "")
            {
                return;
            }

            jogadas = jogadas.Replace("\r", "");
            if (jogadas.Length > 0)
                jogadas = jogadas.Substring(0, jogadas.Length - 1);

            
            string[] listaJogada = jogadas.Split('\n');

            string[] ultimaRodada = listaJogada[listaJogada.Length-1].Split(',');

            int x = 1300;

            
            foreach (string jogada in listaJogada)
            {
                string[] rodada = jogada.Split(',');
                if (rodada[0] == ultimaRodada[0])
                {
                    string naipeCarta = rodada[2];
                    string numeroCarta = rodada[3];

                    string caminhoImagem = Path.Combine(diretorioAtual, "../../Cards/numeros/", $"{numeroCarta}{naipeCarta}.png");
                    lblJogada.Text = jogadas;
                    lblJogada.Visible = true;

                    Panel carta = new Panel();
                    carta.BackgroundImage = Image.FromFile(caminhoImagem);
                    carta.Height = 231;
                    carta.Width = 143;
                    carta.Left = x;
                    carta.Top = 367;
                    Label cartaJogada = new Label();
                    cartaJogada.Text = rodada[1];
                    cartaJogada.AutoSize = true;
                    cartaJogada.Left = x + carta.Width / 2 - 15;
                    cartaJogada.Top = 608;


                    carta.BackgroundImageLayout = ImageLayout.Stretch;
                    Controls.Add(carta);
                    Controls.Add(cartaJogada);
                    x -= 164;
                }
            }

        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao jogar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblTexto.Text = "Carta Jogada:";
            lblCartaJogada.Text = retornoJogada;
            lblCartaJogada.Visible = true;

        }


        private void btnApostar_Click(object sender, EventArgs e)
        {
            string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoAposta.Length > 4 && retornoAposta.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao apostar:\n{retornoAposta.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblTexto.Text = "Carta Apostada:";
            lblCartaJogada.Text = retornoAposta;
            lblCartaJogada.Visible = true;
            AtualizarCartas();
            MostrarCartas();
            MostrarJogada();
            VerificarVez();

        }

        private void btnAtualizarVez_Click(object sender, EventArgs e)
        {
            VerificarVez();
            AtualizarCartas();
            MostrarCartas();
            MostrarJogada();
            
        }

        private void btnAtualizarCartas_Click(object sender, EventArgs e)
        {
            AtualizarCartas();
            MostrarCartas();
            MostrarJogada();
            VerificarVez();
        }

        private void Jogar()
        {
            if(lblIDVez.Text == RetornoDados[0])
            {
                foreach (string carta in lstCartas.Items)
                {
                    string[] pedacoCarta = carta.ToString().Split(',');
                    txtIdCarta.Text = pedacoCarta[1];
                    string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
                    if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
                    {
                        continue;
                    }
                    lblTexto.Text = "Carta Jogada:";
                    lblCartaJogada.Text = retornoJogada;
                    lblCartaJogada.Visible = true;
                    break;
                }
                string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("0"));
                AtualizarCartas();
                MostrarCartas();
                MostrarJogada();
            }
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
            AtualizarCartas();
            MostrarCartas();
            MostrarJogada();
            VerificarVez();
            Jogar();
            tmrTimer.Enabled = true;
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = true;
        }
    }
}
