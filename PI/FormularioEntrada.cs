using lobby;
using MagicTrickServer;
using SistemaAutonomo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo
{
    public partial class FormularioEntrada : Form
    {
        private int IdPartida;
        private string[] InformacoesJogadorMaquina = new string[2];
        public FormularioEntrada()
        {
            InitializeComponent();
            //lblVersao.Text = Jogo.Versao;
            listarPartida();
        }

        private void listarPartida()
        {
            string partidasList = Jogo.ListarPartidas("T");
            partidasList = partidasList.Replace("\r", "");
            if (partidasList.Length > 0)
                partidasList = partidasList.Substring(0, partidasList.Length - 1);

            string[] nomePartidas = partidasList.Split('\n');

            lstPartidasEncontradas.Items.Clear();


            for (int i = 0; i < nomePartidas.Length; i++)
            {
                lstPartidasEncontradas.Items.Add(nomePartidas[i]);
            }
        }

        private void listarJogadores()
        {
            string listaDePartidas = lstPartidasEncontradas.SelectedItem.ToString();
            string[] partidaInfo = listaDePartidas.Split(',');

            txtIDPartida.Text = partidaInfo[0];
            IdPartida = Convert.ToInt32(partidaInfo[0]);


            string jogadoresList = Jogo.ListarJogadores2(IdPartida);
            lstJogadores.Items.Clear();

            jogadoresList = jogadoresList.Replace("\r", "");
            if (jogadoresList.Length > 0)
                jogadoresList = jogadoresList.Substring(0, jogadoresList.Length - 1);

            string[] nomeJogadores = jogadoresList.Split('\n');

            for (int i = 0; i < nomeJogadores.Length; i++)
            {
                lstJogadores.Items.Add(nomeJogadores[i]);
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            listarPartida();
        }

        private void lstPartidasEncontradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarJogadores();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (lstPartidasEncontradas.SelectedItem != null)
            {
                listarJogadores();
            }
            else
            {
                MessageBox.Show("selecione uma partida antes de listar os jogadores", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEntrarLobby_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador.Text != "" && txtSenha.Text != "" && txtIDPartida.Text != "")
            {
                int idPartida = Convert.ToInt32(txtIDPartida.Text);
                string nomeDoJogador = txtNomeJogador.Text;
                string senhaEntrar = txtSenha.Text;
                string retornoEntrar = Jogo.EntrarPartida(idPartida, nomeDoJogador, senhaEntrar);

                if (retornoEntrar.Length > 4 && retornoEntrar.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show($"Ocorreu um erro ao entrar a partida:\n{retornoEntrar.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string dadosJogador = retornoEntrar;
                InformacoesJogadorMaquina = dadosJogador.Split(',');
                listarJogadores();
            }
            else
            {
                MessageBox.Show($"Ocorreu um erro ao entrar na partida:\nUm ou mais campos estão vazios", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            string retornoIniciar = Jogo.IniciarPartida(Convert.ToInt32(InformacoesJogadorMaquina[0]), InformacoesJogadorMaquina[1]);


            if (retornoIniciar.Length > 4 && retornoIniciar.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao iniciar a partida:\n{retornoIniciar.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEntrarPartida_Click_1(object sender, EventArgs e)
        {
            //IdPartida = 297;
            //dados[0] = "870";
            //dados[1] = "C81C0C";


            if (IdPartida != 0 && InformacoesJogadorMaquina[0] != null)
            {
                FormularioPartida formularioPartida = new FormularioPartida();
                formularioPartida.IniciarGame(IdPartida, InformacoesJogadorMaquina);
                formularioPartida.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma partida e entre nela antes de continuar.", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
