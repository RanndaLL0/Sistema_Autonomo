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
                //MessageBox.Show($"Ocorreu um erro ao verificar ao consultar mão:\n{CartasList.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            
            for (int i = 0; i < numeroDeJogadores; i++)
            {
                int contadorDeCartas = 1;
                for (int j = 0; j < lstCartas.Items.Count; j++)
                {
                    
                    string[] pedacoCarta = lstCartas.Items[j].ToString().Split(',');
                    string naipeCarta = pedacoCarta[2];
                    if (pedacoCarta[0] != idJogadores[i]) continue;
                    Panel carta = new Panel();

                    while (contadorDeCartas != int.Parse(pedacoCarta[1]))
                    {
                        Panel cartaVazia = new Panel();
                        if (numeroDeJogadores == 2 && jogador[i].Count == 6 || numeroDeJogadores > 2 && jogador[i].Count == 7)
                        {
                            jogador[i].X = jogador[i].XInicial + jogador[i].PulaLinhaX;
                            jogador[i].Y = jogador[i].YInicial + jogador[i].PulaLinhaY;
                        }
                        cartaVazia.Left = jogador[i].X;
                        cartaVazia.Top = jogador[i].Y;
                        jogador[i].X += jogador[i].DeslocamentoX;
                        jogador[i].Y += jogador[i].DeslocamentoY;
                        jogador[i].Count++;
                        cartaVazia.Width = jogador[i].Width;
                        cartaVazia.Height = jogador[i].Height;
                        cartaVazia.BackgroundImageLayout = ImageLayout.Stretch;
                        string[] diretoriosCartasVazias = { Path.Combine(diretorioAtual, "../../Cards/cartasVazias/", $"Padrao.png"), Path.Combine(diretorioAtual, "../../Cards/cartasVazias/", $"Padrao.png"), Path.Combine(diretorioAtual, "../../Cards/cartasVazias/", $"Padraodir.png"), Path.Combine(diretorioAtual, "../../Cards/cartasVazias/", $"Padraodir.png") };
                        cartaVazia.BackgroundImage = Image.FromFile(diretoriosCartasVazias[i]);

                        //Controls.Add(cartaVazia);
                        contadorDeCartas++;
                    }
                    

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
                    string[] diretorios = { Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}invertido.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}dir.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}esq.png") };
                    carta.BackgroundImage = Image.FromFile(diretorios[i]);


                    Controls.Add(carta);
                    
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

            retornoVez = retornoVez.Replace("\r", "");
            if (retornoVez.Length > 0)
                retornoVez = retornoVez.Substring(0, retornoVez.Length - 1);
            string[] dadosVez = retornoVez.Split(',');
            string[] dadosTodosVez = retornoVez.Split('\n');

            lstStatus.Items.Clear();
            foreach(string s in dadosTodosVez)
            {
                lstStatus.Items.Add(s);
            }
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
            lstJogadas.Items.Clear();

            for (int i = 0; i < listaJogada.Length; i++)
            {
                lstJogadas.Items.Add(listaJogada[i]);
            }
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
                    

                    Panel carta = new Panel();
                    carta.BackgroundImage = Image.FromFile(caminhoImagem);
                    carta.Height = 231;
                    carta.Width = 143;
                    carta.Left = x;
                    carta.Top = 367;
                    Label cartaJogada = new Label();
                    //cartaJogada.Text = rodada[1];
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
            lblTexto.Text = "Carta A:";
            lblCartaJogada.Text = retornoAposta;


            VerificarVez();
            AtualizarCartas();
            MostrarCartas();

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


        private bool JogarCopas()
        {
            foreach (string carta in lstCartas.Items)
            {
                string[] pedacoCarta = carta.ToString().Split(',');

                if (pedacoCarta[2] == "C" && pedacoCarta[0] == RetornoDados[0]) // Verifica se o jogador ques esta na maquina tem a carta de Copas
                {
                    txtIdCarta.Text = pedacoCarta[1];
                    string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(pedacoCarta[1]));

                    if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
                    {
                        continue;
                    }

                    lblTexto.Text = "Carta Jogada:";
                    lblCartaJogada.Text = retornoJogada;
                    lblCartaJogada.Visible = true;
                    string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("6"));
                    if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
                    {
                        Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("7"));
                        continue;
                    }
                    return true;   
                }
            }
            return false;
        }

        private void Jogar()
        {
            
            if (lblIDVez.Text == RetornoDados[0]) // compara o Id da vez com o do jogador que esta na maquina
            {
                bool jogouCopas = JogarCopas();
                if (!jogouCopas)
                {
                    foreach (string carta in lstCartas.Items)
                    {

                        string[] pedacoCarta = carta.ToString().Split(',');

                        txtIdCarta.Text = pedacoCarta[1];
                        string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(pedacoCarta[1]));


                        if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
                        {
                            continue;
                        }
                        lblTexto.Text = "Carta Jogada:";
                        lblCartaJogada.Text = retornoJogada;
                        lblCartaJogada.Visible = true;
                        break;
                    }
                    string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("12"));
                }
                AtualizarCartas();
                MostrarCartas();
                MostrarJogada();
            }
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
 
            tmrTimer.Enabled = false;
            VerificarVez();
            Jogar();
            tmrTimer.Enabled = true;
            if (lblPartidaStatus.Text != "J")
            {
                tmrTimer.Enabled = false;
                string statusFinal = lstStatus.Items[0].ToString();
                string[] ganhador = statusFinal.Split(',');
                MessageBox.Show($"O VENCEDOR FOI {ganhador[1]}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = true;
        }


    }
}
