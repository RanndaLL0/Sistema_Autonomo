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
        public int IdPartida { get; set; }
        public string[] JogadorNaMaquina { get; set; }
        public InicializadorPartida inicializadorPartida;

        private string diretorioAtual = Directory.GetCurrentDirectory();



        public FormularioPartida()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormularioPartida_KeyDown);
        }

        public void IniciarGame(int idPartida, string[] jogadorNaMaquina)
        {
            JogadorNaMaquina = jogadorNaMaquina;
            IdPartida = idPartida;
            VerificarVez();
            inicializadorPartida = new InicializadorPartida(JogadorNaMaquina, IdPartida,this);
            inicializadorPartida.partida.ExibirCartaJogada();
            inicializadorPartida.partida.ExibirCartaApostada();
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
        }

        public void btnStartTimer_Click(object sender, EventArgs e)
        {
            inicializadorPartida.InicializarBot(tmrTimer);
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;
            tmrTimer2.Enabled = true;
            inicializadorPartida.partida.AtualizarEstadoPartida();
            inicializadorPartida.Bot.TomarDecisao();
            //Jogar();
            tmrTimer.Enabled = true;
        }

        private void tmrTimer2_Tick(object sender, EventArgs e)
        {
            tmrTimer2.Enabled = false;
            inicializadorPartida.partida.RemoverCartaApostada();
            inicializadorPartida.partida.RemoverCartaJogada();
            inicializadorPartida.partida.AtualizarTodosOsLabels();
            inicializadorPartida.partida.ExibirCartaJogada();
            inicializadorPartida.partida.ExibirCartaApostada();
            tmrTimer2.Enabled = true;
        }

        private void FormularioPartida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
