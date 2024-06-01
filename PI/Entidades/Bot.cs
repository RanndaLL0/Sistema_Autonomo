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

            estrategia = new Estrategia(idPartida, IdJogadores[0]);
            this.partida = partida; 
            InicializarTimer(timer);
        }

        public void InicializarTimer(Timer timer)
        {
            timer.Enabled = true;
        }

        public void JogarCopas()
        {
            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
            for(int i = quantidadeCartas; i >= 1; i--)
            {
                if(Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == 'C')
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return;
                }
            }
        }

        public void ComecarRound(int quantidadeDeCartas,List<int> todasAsCartasJogadas,string primeiraCartaJogada)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if(quantidadeCopas != 0)
            {
                JogarCopas();
                return;
            }
            JogarMaiorCarta(quantidadeDeCartas,todasAsCartasJogadas,primeiraCartaJogada);
        }

        public void JogarMaiorCarta(int quantidadeDeCartas,List<int> todasAsCartasJogadas,string primeiraCartaJogada)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i) && Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == char.Parse(primeiraCartaJogada))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return;
                }
            }
            JogarQualquerCarta(todasAsCartasJogadas,quantidadeDeCartas);
        }

        public void JogarQualquerCarta(List<int> todasAsCartasJogadas,int quantidadeDeCartas)
        {
            for(int i = quantidadeDeCartas; i >= 1; i --)
            {
                if(todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return;
                }
            }
            return;
        }

        public void PrimeiraCartaJogada()
        {
            string[] informacoesJogada = GerenciadorStrings.ObterJogadas(IdPartida);
        }

        public void TomarDecisao()
        {
            List<int> TodasAsCartasJogadas = estrategia.VerificaCartasJogadas();

            string[] vez = GerenciadorStrings.ObterVez(IdPartida);
            string idJogadorRodadaAtual = vez[0].Split(',')[1];


            if (IdJogadores[0] == int.Parse(idJogadorRodadaAtual))
            {

                string primeiraCartaJogada = partida.primeiraCartaRound;
                int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                if (primeiraCartaJogada == string.Empty && IdJogadores[0] == int.Parse(idJogadorRodadaAtual))
                {
                    ComecarRound(quantidadeCartas, TodasAsCartasJogadas, primeiraCartaJogada);
                    return;
                }
                else
                {
                    JogarMaiorCarta(quantidadeCartas,TodasAsCartasJogadas, primeiraCartaJogada);
                }
            }
        }


    }
}
