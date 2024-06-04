using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class ComecarOTurno
    {

        public void Jogar(int quantidadeDeCartas, List<int> todasAsCartasJogadas)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                JogarCopas(todasAsCartasJogadas);
                return;
            }
            JogarPrimeiraMaiorCarta(quantidadeDeCartas, todasAsCartasJogadas);
        }

        public void JogarCopas(List<int> todasAsCartasJogadas)
        {
            int quantidadeDeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                for (int i = quantidadeDeCartas; i >= 1; i--)
                {
                    if (Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == 'C' && !todasAsCartasJogadas.Contains(i))
                    {
                        partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                        return;
                    }
                }
            }
            JogarQualquerCarta(todasAsCartasJogadas, quantidadeDeCartas);
        }

        public void JogarQualquerCarta(List<int> todasAsCartasJogadas, int quantidadeDeCartas)
        {
            for (int i = 1; i <= quantidadeDeCartas; i++)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return;
                }
            }
        }

        public void JogarPrimeiraMaiorCarta(int quantidadeDeCartas, List<int> todasAsCartasJogadas)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return;
                }
            }
            JogarCopas(todasAsCartasJogadas);
        }
    }
}
