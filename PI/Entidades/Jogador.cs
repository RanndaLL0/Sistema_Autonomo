using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Jogador
    {
        private int id;
        public string nome { get;}
        private int pontuacaoDaPartida { get; set; }
        private int pontuacaoDoTurno { get; set; }
        public Cartas Cartas { get; set; }
        public PosicaoCartas Posicao { get; set; }
        public string senha { get; set; }


        /// <summary>
        /// Construtor para o jogador na maquina
        /// </summary>
        /// <param name="id"></param>
        /// <param name="posicao"></param>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        public Jogador(int id, PosicaoCartas posicao, string nome,string senha)
        {
            this.id = id;
            this.senha = senha;
            Posicao = posicao;
            this.nome = nome;
            Cartas = new Cartas();
            pontuacaoDaPartida = 0;
            pontuacaoDoTurno = 0;
        }
   
        public Jogador(int id, PosicaoCartas posicao, string nome)
        {
            this.id = id;
            Posicao = posicao;
            this.nome = nome;
            Cartas = new Cartas();
            pontuacaoDaPartida = 0;
            pontuacaoDoTurno = 0;
        }

        public int ObterPontuacaoTurno()
        {
            return 0;
        }

        public int ObterPontuacaoPartida()
        {
            return 0;
        }

        public void JogarCarta(int idCarta,string path, char naipeCarta)
        {
            string diretorioAtual = Directory.GetCurrentDirectory();
            string caminhoCarta = path.Replace('|', naipeCarta);
            Cartas.cartas[idCarta].ImagemDaCarta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/Empty Space/", caminhoCarta));
        }

        public void Apostar()
        {

        }
    }
}
