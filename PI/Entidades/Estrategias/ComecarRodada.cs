using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class ComecarRodada
    {

        private Estrategia estrategia;

        public ComecarRodada(Estrategia estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Jogar(int quantidadeDeCartas,int idPartida,Jogador jogadorMaquina,Partida partida)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(jogadorMaquina);
            if (quantidadeCopas != 0)
            {
                JogarCopas(jogadorMaquina,idPartida,partida);
                return;
            }
            JogarMaiorCarta(quantidadeDeCartas,jogadorMaquina,partida);
        }

        public void JogarCopas(Jogador jogadorMaquina,int idPartida,Partida partida)
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
            JogarMenorCarta(jogadorMaquina,partida);
        }

        public void JogarMaiorCarta(int quantidadeDeCartas,Jogador jogadorMaquina,Partida partida)
        {
            partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, quantidadeDeCartas);
            return;
        }

        public void JogarMenorCarta(Jogador jogadorMaquina,Partida partida)
        {   
            partida.JogarCarta(jogadorMaquina.id, jogadorMaquina.senha, 1);
            return;
        }
    }
}
