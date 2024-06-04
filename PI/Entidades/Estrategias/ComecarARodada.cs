using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class ComecarARodada
    {

        public void Jogar(int quantidadeDeCartas)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                JogarCopasPrimeiraRodada();
                return;
            }
            JogarMaiorCartaPrimeiraRodada(quantidadeDeCartas);
        }

        public void JogarCopasPrimeiraRodada()
        {
            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                for (int i = quantidadeCartas; i >= 1; i--)
                {
                    if (Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == 'C')
                    {
                        partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                        return;
                    }
                }
            }
            JogarMenorCartaPrimeiraRodada();
        }

        public void JogarMenorCartaPrimeiraRodada()
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, 1);
            return;
        }

        public void JogarMaiorCartaPrimeiraRodada(int quantidadeDeCartas)
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, quantidadeDeCartas);
            return;
        }
    }
}
