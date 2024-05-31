using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAutonomo.Entidades.Estrategias;

namespace SistemaAutonomo.Entidades
{
    public class Bot
    {

        private Dictionary<int, Jogador> Jogadores;
        private List<int> IdJogadores;
        private Estrategia estrategia;
        private int IdPartida;
        private Partida partida;

        public Bot(Partida partida,int idPartida,Timer timer,Dictionary<int,Jogador> jogadores)
        {
            IdPartida = idPartida;
            Jogadores = jogadores;
            IdJogadores = jogadores.Keys.ToList<int>();

            estrategia = new Estrategia(idPartida);
            this.partida = partida; 
            InicializarTimer(timer);
        }

        public void InicializarTimer(Timer timer)
        {
            timer.Enabled = true;
        }

        public void JogarMaiorCarta()
        {
            List<int>cartasJogadas = GerenciadorStrings.ObterJogadasPeloJogador(IdPartida, IdJogadores[0]);
            char ultimaCartaJogada = char.Parse(GerenciadorStrings.UltimaCartaJogada(IdPartida)[2]);

            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

            for (int i = quantidadeCartas; i >= 1; i--)
            {
                if (!cartasJogadas.Contains(i) && Jogadores[0].Cartas.cartas[i].Naipe == ultimaCartaJogada)
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                }      
            }

        }


    }
}
