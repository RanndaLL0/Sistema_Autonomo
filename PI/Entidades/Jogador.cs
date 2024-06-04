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
        public int id;
        public string nome { get;}
        public int pontuacaoDaPartida { get; set; }
        public int pontuacaoDoTurno { get; set; }
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

        public void ColocarPontuacao(int idPartida)
        {
            string[] jogadores = GerenciadorStrings.ObterInformacaoDosJogadores(idPartida);
            foreach(string jogador in jogadores)
            {
                int idJogador = int.Parse(jogador.Split(',')[0]);
                if (idJogador == id)
                {
                    pontuacaoDaPartida = int.Parse(jogador.Split(',')[2]);
                    pontuacaoDoTurno = int.Parse(jogador.Split(',')[3]);
                }
            }
        }

        public void JogarCarta(int idCarta,string path, char naipeCarta)
        {
            string diretorioAtual = Directory.GetCurrentDirectory();
            string caminhoCarta = path.Replace('|', naipeCarta);
            Cartas.cartas[idCarta].ImagemDaCarta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/Empty Space/", caminhoCarta));
        }
    }
}
