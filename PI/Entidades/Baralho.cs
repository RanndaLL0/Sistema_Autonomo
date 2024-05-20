using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SistemaAutonomo.Entidades
{
    public class Baralho
    {
        public Dictionary<int,Carta> cartas;

        public Baralho()
        {
            cartas = new Dictionary<int, Carta>();
        }

        public void AdicionarCarta(char naipe,int idCarta)
        {
            cartas.Add(idCarta, new Carta(naipe, idCarta));
        }

        public void RemoverCarta(int idCarta,Form game,string path,char naipeCarta)
        {
            string diretorioAtual = Directory.GetCurrentDirectory();
            string caminhoCarta = path.Replace('|', naipeCarta);
            cartas[idCarta].ImagemDaCarta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/Empty Space/", caminhoCarta));
        }
    }
}
