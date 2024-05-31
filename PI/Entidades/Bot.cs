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
            List<int>idsCartasJogadas = GerenciadorStrings.ObterJogadasPeloJogador(IdPartida, IdJogadores[0]);
            List<int>idsCartasApostadas = GerenciadorStrings.ObterIdsCartasApostadasJogador(IdPartida, IdJogadores[0]);

            if (idsCartasJogadas == null || idsCartasApostadas == null) { return; }
            List<int> idsTodasCartasJogadas = new List<int>();
            idsTodasCartasJogadas.AddRange(idsCartasJogadas);
            idsTodasCartasJogadas.AddRange(idsCartasApostadas);

            string[] vez = GerenciadorStrings.ObterVez(IdPartida);
            string idJogadorRodadaAtual = vez[0].Split(',')[1];

            if (idsTodasCartasJogadas != null && IdJogadores[0] == int.Parse(idJogadorRodadaAtual))
            {
                char ultimaCartaJogada = char.Parse(GerenciadorStrings.UltimaCartaJogada(IdPartida)[2]);
                int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                for (int i = quantidadeCartas; i >= 1; i--)
                {
                    
                    if (!idsTodasCartasJogadas.Contains(i) && Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == ultimaCartaJogada)
                    {
                        partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                        return;
                    }
                }
            }
        }


    }
}
