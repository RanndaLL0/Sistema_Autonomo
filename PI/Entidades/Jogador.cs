using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Jogador
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private int PontuacaoDaPartida { get; set; }
        private int PontuacaoDoTurno { get; set; }
        public Baralho Baralho { get; set; }
        public ConfiguracaoMao Posicao { get; set; }

        public Jogador(int id,string nome) 
        {
            Id = id;
            Nome = nome;
            PontuacaoDaPartida = 0;
            PontuacaoDoTurno = 0;
        }

        public Jogador(int id,ConfiguracaoMao posicao, string nome)
        {
            Id = id;
            Posicao = posicao;
            Nome = nome;
            Baralho = new Baralho();
            PontuacaoDaPartida = 0;
            PontuacaoDoTurno = 0;
        }

        public int ObterPontuacaoTurno()
        {
            return 0;
        }

        public int ObterPontuacaoPartida()
        {
            return 0;
        }

        public void Jogar()
        {

        }

        public void Apostar()
        {

        }
    }
}
