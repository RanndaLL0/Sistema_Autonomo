using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class ResponderTurno
    {

        private Estrategia estrategia;

        public ResponderTurno(Estrategia estrategia) 
        {
            this.estrategia = estrategia;
        }

        public void Jogar(int quantidadeDeCartas, int idPartida, Jogador jogadorMaquina, Partida partida, List<int> todasAsCartasJogadas, string naipePrimeiraCartaJogada)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i) && jogadorMaquina.Cartas.cartas[i].Naipe == char.Parse(naipePrimeiraCartaJogada))
                {
                    partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, i);
                    return;
                }
            }
            JogarCopas(todasAsCartasJogadas,idPartida,jogadorMaquina,partida);
        }

        public void JogarCopas(List<int> todasAsCartasJogadas,int idPartida,Jogador jogadorMaquina,Partida partida)
        {
            int quantidadeDeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(idPartida);
            int quantidadeCopas = estrategia.QuantidadeCopas(jogadorMaquina);
            if (quantidadeCopas != 0)
            {
                for (int i = quantidadeDeCartas; i >= 1; i--)
                {
                    if (jogadorMaquina.Cartas.cartas[i].Naipe == 'C' && !todasAsCartasJogadas.Contains(i))
                    {
                        partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, i);
                        return;
                    }
                }
            }
            JogarQualquerCarta(todasAsCartasJogadas, quantidadeDeCartas,partida,jogadorMaquina);
        }

        public void JogarQualquerCarta(List<int> todasAsCartasJogadas, int quantidadeDeCartas,Partida partida,Jogador jogadorMaquina)
        {
            for (int i = 1; i <= quantidadeDeCartas; i++)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, i);
                    return;
                }
            }
        }

    }
}
