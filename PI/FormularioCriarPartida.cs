using MagicTrickServer;
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
    public partial class FormularioCriarPartida : Form
    {
        public FormularioCriarPartida()
        {
            InitializeComponent();

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string grupo = "Budapeste";



            string retornoCriacao = Jogo.CriarPartida(nomePartida, senha, grupo);


            if (retornoCriacao.Length > 4 && retornoCriacao.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao criar a partida:\n{retornoCriacao.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //FormularioEntrada formularioEntrada = new FormularioEntrada();
            //formularioEntrada.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
