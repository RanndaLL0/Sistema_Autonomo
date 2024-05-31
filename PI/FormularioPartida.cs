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
    public partial class FormularioPartida : Form
    {
        public string RetornoIniciar { get; set; }
        public int IdPartida { get; set; }
        public string[] JogadorNaMaquina { get; set; }
        public InicializadorPartida inicializadorPartida;

        private string diretorioAtual = Directory.GetCurrentDirectory();



        public FormularioPartida()
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
            inicializadorPartida = new InicializadorPartida(JogadorNaMaquina, IdPartida,this);
            AtualizarCartas();
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
        private void btnJogar_Click(object sender, EventArgs e)
        {
            inicializadorPartida.partida.JogarCarta();
        }


        private void btnApostar_Click(object sender, EventArgs e)
        {
            inicializadorPartida.partida.ApostarCarta();
        }

        private void btnAtualizarVez_Click(object sender, EventArgs e)
        {
            VerificarVez();
            AtualizarCartas();
        }

        private void btnAtualizarCartas_Click(object sender, EventArgs e)
        {
            inicializadorPartida.partida.RemoverCartaJogada();
            inicializadorPartida.partida.ExibirCartaJogada();
            inicializadorPartida.partida.AtualizarEstadoPartida();
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
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            inicializadorPartida.InicializarBot(tmrTimer);
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
            inicializadorPartida.Bot.JogarMaiorCarta();
            inicializadorPartida.partida.AtualizarEstadoPartida();
            VerificarVez();
            //Jogar();
            tmrTimer.Enabled = true;
        }


    }
}
