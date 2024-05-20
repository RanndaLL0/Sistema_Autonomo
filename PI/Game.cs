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
using SistemaAutonomo.Entidades;

namespace lobby
{
    public partial class Game : Form
    {
        public string RetornoIniciar { get; set; }
        public int IdPartida { get; set; }
        public string[] JogadorNaMaquina { get; set; }
        public Mesa mesa;

        private string diretorioAtual = Directory.GetCurrentDirectory();



        public Game()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //Mesa mesa = new Mesa(JogadorNaMaquina,IdPartida);
        }

        public void IniciarGame(int idPartida, string[] jogadorNaMaquina)
        {
            JogadorNaMaquina = jogadorNaMaquina;
            IdPartida = idPartida;
            VerificarVez();
            mesa = new Mesa(JogadorNaMaquina, IdPartida,this);
            AtualizarCartas();
            MostrarCartas();
            txtIdJogador.Text = JogadorNaMaquina[0];
            txtSenhaJogador.Text = JogadorNaMaquina[1];
            lblVersao.Text = Jogo.Versao;
        }

        private void AtualizarCartas()
        {
            string CartasList = Jogo.ConsultarMao(IdPartida);
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
            //RemoverPanels();

            //string conjuntoDeJogadores = Jogo.ListarJogadores(IdPartida);

            //conjuntoDeJogadores = conjuntoDeJogadores.Replace("\r", "");
            //if (conjuntoDeJogadores.Length > 0)
            //    conjuntoDeJogadores = conjuntoDeJogadores.Substring(0, conjuntoDeJogadores.Length - 1);

            //string[] listaJogadores = conjuntoDeJogadores.Split('\n');
            //int numeroDeJogadores = listaJogadores.Length;

            //string idJogadorInicial = JogadorNaMaquina[0];
            //string[] idJogadores = new string[4]; 

            //int indice = 0;

            //for (int i = 0; i < numeroDeJogadores; i++)
            //{
            //    string[] partesJogadores = listaJogadores[i].Split(',');
            //    idJogadores[i] = partesJogadores[0];

            //    if (idJogadores[i] == idJogadorInicial)
            //    {
            //        indice = i; 
            //    }
                
            //}

            //string temp = idJogadores[0];
            //idJogadores[0] = idJogadorInicial;
            //idJogadores[indice] = temp;


            //List<ConfiguracaoMao> jogador = new List<ConfiguracaoMao>();

            //if (numeroDeJogadores == 2)
            //{
            //    jogador.Add(new ConfiguracaoMao(850, 850, 690, 690, 0, 91, 137, 97, 0, 0, 143));
            //    jogador.Add(new ConfiguracaoMao(1335, 1335, 155, 155, 0, 91, 137, -97, 0, 0, -143));
            //}
            //else
            //{
            //    jogador.Add(new ConfiguracaoMao(800, 800, 690, 690, 0, 91, 137, 97, 0, 0, 143));
            //    jogador.Add(new ConfiguracaoMao(1382, 1382, 155, 155, 0, 91, 137, -97, 0, 0, -143));
            //    jogador.Add(new ConfiguracaoMao(620, 620, 147, 147, 0, 137, 91, 0, 97, -143, 0));
            //    jogador.Add(new ConfiguracaoMao(1516, 1516, 730, 730, 0, 137, 91, 0, -97, 143, 0));
            //}


            
            //for (int i = 0; i < numeroDeJogadores; i++)
            //{
            //    int contadorDeCartas = 1;
            //    for (int j = 0; j < lstCartas.Items.Count; j++)
            //    {
                    
            //        string[] pedacoCarta = lstCartas.Items[j].ToString().Split(',');
            //        char naipeCarta = char.Parse(pedacoCarta[2]);
            //        if (pedacoCarta[0] != idJogadores[i]) continue;
            //        Panel carta = new Panel();

            //        if (contadorDeCartas != int.Parse(pedacoCarta[1]))
            //        {
            //            while (contadorDeCartas != int.Parse(pedacoCarta[1]) && contadorDeCartas < 12)
            //            {
            //                if (numeroDeJogadores == 2 && jogador[i].Contador == 6 || numeroDeJogadores > 2 && jogador[i].Contador == 7)
            //                {
            //                    jogador[i].X = jogador[i].XInicial + jogador[i].PulaLinhaX;
            //                    jogador[i].Y = jogador[i].YInicial + jogador[i].PulaLinhaY;
            //                }
            //                jogador[i].X += jogador[i].DeslocamentoX;
            //                jogador[i].Y += jogador[i].DeslocamentoY;
            //                jogador[i].Contador++;

            //                contadorDeCartas++;
            //            }
            //        }

            //        if (numeroDeJogadores == 2 && jogador[i].Contador == 6 || numeroDeJogadores > 2 && jogador[i].Contador == 7)
            //        {
            //            jogador[i].X = jogador[i].XInicial + jogador[i].PulaLinhaX;
            //            jogador[i].Y = jogador[i].YInicial + jogador[i].PulaLinhaY;
            //        }
            //        carta.Left = jogador[i].X;
            //        carta.Top = jogador[i].Y;
            //        jogador[i].X += jogador[i].DeslocamentoX;
            //        jogador[i].Y += jogador[i].DeslocamentoY;
            //        jogador[i].Contador++;

            //        carta.Width = jogador[i].Largura;
            //        carta.Height = jogador[i].Altura;
            //        carta.BackgroundImageLayout = ImageLayout.Stretch;
            //        string[] diretorios = {Path.Combine(diretorioAtual,"../../Cards/", $"{naipeCarta}.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}invertido.png"), Path.Combine(diretorioAtual, "../../Cards/", $"{naipeCarta}dir.png"), Path.Combine(diretorioAtual,"../../Cards/", $"{naipeCarta}esq.png") };
            //        carta.BackgroundImage = Image.FromFile(diretorios[i]);


            //        Controls.Add(carta);
                    
            //        contadorDeCartas++;
            //   }


            //}


        }


        private void VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(IdPartida);
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
            string jogadas = Jogo.ExibirJogadas(IdPartida);
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
            mesa.Partida.JogarCarta();
        }


        private void btnApostar_Click(object sender, EventArgs e)
        {
            string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoAposta.Length > 4 && retornoAposta.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao apostar:\n{retornoAposta.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

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

                if (pedacoCarta[2] == "C" && pedacoCarta[0] == JogadorNaMaquina[0])
                {
                    txtIdCarta.Text = pedacoCarta[1];
                    string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(pedacoCarta[1]));

                    if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
                    {
                        continue;
                    }
                    string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("0"));
                    return true;   
                }
            }
            return false;
        }

        private void Jogar()
        {
            if(lblIDVez.Text == JogadorNaMaquina[0]) // compara o Id da vez com o do jogador que esta na maquina
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
                        break;
                    }
                    string retornoAposta = Jogo.Apostar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32("0"));
                }
            }
            AtualizarCartas();
            MostrarCartas();
            MostrarJogada();
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
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
