using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class ResponderPrimeiroTurno
    {

        private Estrategia estrategia;

        public ResponderPrimeiroTurno(Estrategia estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Jogar(int quantidadeDeCartas, int idPartida, Jogador jogadorMaquina, Partida partida, List<int> todasAsCartasJogadas,string naipePrimeiraCartaJogada)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (jogadorMaquina.Cartas.cartas[i].Naipe == char.Parse(naipePrimeiraCartaJogada))
                {
                    partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, i);
                    return;
                }
            }
            JogarCopas(idPartida,jogadorMaquina,partida);
        }

        public void JogarCopas(int idPartida,Jogador jogadorMaquina,Partida partida)
        {
            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(idPartida);
            int quantidadeCopas = estrategia.QuantidadeCopas(jogadorMaquina);
            if (quantidadeCopas != 0)
            {
                for (int i = quantidadeCartas; i >= 1; i--)
                {
                    if (jogadorMaquina.Cartas.cartas[i].Naipe == 'C')
                    {
                        partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, i);
                        return;
                    }
                }
            }
            JogarMenorCarta(partida,jogadorMaquina);
        }

        public void JogarMenorCarta(Partida partida,Jogador jogadorMaquina)
        {
            partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, 1);
            return;
        }
    }
}
