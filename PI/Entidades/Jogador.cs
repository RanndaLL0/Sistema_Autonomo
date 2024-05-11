using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontuacaoDaPartida { get; set; }
        public int PontuacaoDoTurno { get; set; }
        public Baralho Baralho { get; set; }

        public Jogador(int id,string nome) 
        {
            Id = id;
            Nome = nome;
            PontuacaoDaPartida = 0;
            PontuacaoDoTurno = 0;
        }

        public void Jogar()
        {

        }

        public void Apostar()
        {

        }
    }
}
