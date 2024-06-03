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
        private string rodada = string.Empty;
        public string naipePrimeiraCartaJogada = string.Empty;
        private bool foiApostado = false;

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

        public void PrimeiraCartaJogada(int idJogadorRodadaAtual, string rodadaAtual)
        {
            string[] retornoBruto = GerenciadorStrings.ObterJogadas(IdPartida);

            if (retornoBruto[0] == "")
            {
                naipePrimeiraCartaJogada = string.Empty;
                foiApostado = false;
                return;
            }


            for (int i = 0; i < retornoBruto.Length; i++)
            {
                string[] ultimaRodada = retornoBruto[i].Split(',');

                if (rodadaAtual == ultimaRodada[0])
                {
                    naipePrimeiraCartaJogada = ultimaRodada[2];
                    break;
                }
                naipePrimeiraCartaJogada = string.Empty;
            }
        }

        public void JogarCopasPrimeiraRodada()
        {
            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
            for(int i = quantidadeCartas; i >= 1; i--)
            {
                if(Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == 'C')
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
            JogarMaiorCartaPrimeiraRodada(quantidadeCartas);
        }

        public void JogarCopas(List<int> todasAsCartasJogadas)
        {
            int quantidadeDeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == 'C' && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
            JogarQualquerCarta(todasAsCartasJogadas, quantidadeDeCartas);
        }

        public void JogarMaiorCarta(int quantidadeDeCartas, List<int> todasAsCartasJogadas)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i) && Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == char.Parse(naipePrimeiraCartaJogada))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
            JogarCopas(todasAsCartasJogadas);
        }

        public void JogarMaiorCarta(int quantidadeDeCartas)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == char.Parse(naipePrimeiraCartaJogada))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
            JogarCopasPrimeiraRodada();
        }

        public void JogarQualquerCarta(int quantidadeDeCartas, List<int> todasAsCartasJogadas)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
            JogarCopas(todasAsCartasJogadas);
        }

        public void JogarMaiorCartaPrimeiraRodada(int quantidadeDeCartas)
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, quantidadeDeCartas);
            naipePrimeiraCartaJogada = string.Empty;
            return;
        }

        public void ComecarPrimeiraRodada(int quantidadeDeCartas)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                JogarCopasPrimeiraRodada();
                return;
            }
            JogarMaiorCartaPrimeiraRodada(quantidadeDeCartas);
        }

        public void ComecarRound(int quantidadeDeCartas,List<int>todasAsCartasJogadas)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                JogarCopas(todasAsCartasJogadas);
                return;
            }
            JogarMaiorCarta(quantidadeDeCartas, todasAsCartasJogadas);
        }

        public void JogarQualquerCarta(List<int> todasAsCartasJogadas, int quantidadeDeCartas)
        {
            for (int i = 1; i <= quantidadeDeCartas; i++)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
        }

        public void Apostar(string rodadaAtual)
        {
            if(rodadaAtual == "7")
            {
                int quantidaDeCopasMao = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
                List<int> todasAsCartasJogadas = estrategia.VerificaCartasJogadas();
                int pontuacaoTurno = Jogadores[IdJogadores[0]].pontuacaoDoTurno;
                int quantidadeDeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                if (pontuacaoTurno > 4)
                {
                    for(int i = 6;i <= quantidadeDeCartas;i++)
                    {
                        if(!todasAsCartasJogadas.Contains(i))
                        {
                            partida.ApostarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha,i);
                            foiApostado = true;
                            break;
                        }
                    }
                }
                else if(pontuacaoTurno <= 4)
                {
                    for (int i = 5; i <= 1; i--)
                    {
                        if (!todasAsCartasJogadas.Contains(i))
                        {
                            partida.ApostarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                            foiApostado = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                partida.ApostarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, 0);
            }
        }

        public void TomarDecisao()
        {
            List<int> todasAsCartasJogadas = estrategia.VerificaCartasJogadas();

            string[] vez = GerenciadorStrings.ObterVez(IdPartida);
            int idJogadorRodadaAtual = int.Parse(vez[0].Split(',')[1]);
            string rodadaAtual = vez[0].Split(',')[2];

            PrimeiraCartaJogada(idJogadorRodadaAtual, rodadaAtual);
            if(IdJogadores[0] == idJogadorRodadaAtual)
            {
                int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                if(naipePrimeiraCartaJogada == string.Empty && rodadaAtual == "1")
                {
                    ComecarPrimeiraRodada(quantidadeCartas);
                }
                else if(naipePrimeiraCartaJogada == string.Empty)
                {
                    ComecarRound(quantidadeCartas,todasAsCartasJogadas);
                }
                else if(rodadaAtual == "1")
                {
                    JogarMaiorCarta(quantidadeCartas);
                }
                else
                {
                    JogarMaiorCarta(quantidadeCartas,todasAsCartasJogadas);
                }
                if(!foiApostado)
                {
                    Apostar(rodadaAtual);
                }
            }
        }
    }
}
