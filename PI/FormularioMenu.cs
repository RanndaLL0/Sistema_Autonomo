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
    public partial class FormularioMenu : Form
    {
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            FormularioEntrada formularioEntrada = new FormularioEntrada();
            formularioEntrada.ShowDialog();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            FormularioCriarPartida formularioCriarPartida = new FormularioCriarPartida();
            formularioCriarPartida.ShowDialog();
        }
    }
}
