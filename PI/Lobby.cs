using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace lobby
{
    public partial class Lobby : Form
    {
        //variaveis globais
        private int IdPartida;
        private string[] dados = new string[2];

        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
            listarPartida();
        }


        private void listarPartida()
        {
            string partidasList = Jogo.ListarPartidas("T");
            partidasList = partidasList.Replace("\r", "");
            if (partidasList.Length > 0)
                partidasList = partidasList.Substring(0, partidasList.Length - 1);

            string[] nomePartidas = partidasList.Split('\n');

            lstPartsEncontradas.Items.Clear();


            for (int i = 0; i < nomePartidas.Length; i++)
            {
                lstPartsEncontradas.Items.Add(nomePartidas[i]);
            }
        }
        private void btnPartidas_Click(object sender, EventArgs e)
        {
            listarPartida();
        }

        private void listarJogadores()
        {
            string partidaList = lstPartsEncontradas.SelectedItem.ToString();
            string[] partidInfo = partidaList.Split(',');

            txtID.Text = partidInfo[0];
            IdPartida = Convert.ToInt32(partidInfo[0]);
        

            string jogadoresList = Jogo.ListarJogadores(IdPartida);
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

        private void lstPartsEncontradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarJogadores();
        }

        private void btnListJogadores_Click(object sender, EventArgs e)
        {

            if (lstPartsEncontradas.SelectedItem != null) // Verifica se há uma partida selecionada na primeira ListBox
            {
                listarJogadores();
            }
            else
            {
                MessageBox.Show("selecione uma partida antes de listar os jogadores" , "MagicTrick" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }

        }


        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenha.Text;
            string grupo = "Budapeste";

            

            string retornoCriacao =  Jogo.CriarPartida(nomePartida, senha, grupo);

             
            if (retornoCriacao.Length > 4 && retornoCriacao.Substring(0,4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao criar a partida:\n{retornoCriacao.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listarPartida();
            txtID.Text = retornoCriacao;


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "" && txtSenhaLogIn.Text != "" && txtID.Text != "")
            {
                string nomeDoJogador = txtPlayerName.Text;
                string senhaEntrar = txtSenhaLogIn.Text;
                int idPartidaEntrar = Convert.ToInt32(txtID.Text);
                string retornoEntrar = Jogo.EntrarPartida(idPartidaEntrar, nomeDoJogador, senhaEntrar);
                if (retornoEntrar.Length > 4 && retornoEntrar.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show($"Ocorreu um erro ao entrar a partida:\n{retornoEntrar.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string dadosJogador = retornoEntrar;
                dados = dadosJogador.Split(',');
            }
            else
            {
                MessageBox.Show($"Ocorreu um erro ao entrar na partida:\nUm ou mais campos estão vazios", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            string retornoIniciar = Jogo.IniciarPartida(Convert.ToInt32(dados[0]), dados[1]);


            if (retornoIniciar.Length > 4 && retornoIniciar.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao iniciar a partida:\n{retornoIniciar.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblId.Text = retornoIniciar;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            IdPartida = 3092;
            dados[0] = "3201";
            dados[1] = "40A010";

            //dados[0] = "4158";
            //dados[1] = "F93034";

            //dados[0] = "5360";
            //dados[1] = "06BBC1";

            //dados[0] = "5364";
            //dados[1] = "AE04FF";



            if (IdPartida != 0 && dados != null)
            {
                FormularioPartida game = new FormularioPartida();
                game.IniciarGame(IdPartida,dados);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma partida e entre nela antes de continuar.", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
