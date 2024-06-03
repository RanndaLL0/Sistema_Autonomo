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

        public void PrimeiraCartaJogada( string rodadaAtual)
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
        public void JogarMaiorCarta(int quantidadeDeCartas, List<int> todasAsCartasJogadas)
        {
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i) && Jogadores[IdJogadores[0]].Cartas.cartas[i].Naipe == char.Parse(naipePrimeiraCartaJogada))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
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
                    return;
                }
            }
            JogarCopas(todasAsCartasJogadas);
        }

        public void JogarMaiorCartaPrimeiraRodada(int quantidadeDeCartas)
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, quantidadeDeCartas);
            return;
        }

        public void JogarMenorCartaPrimeiraRodada()
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, 1);
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
            JogarPrimeiraMaiorCarta(quantidadeDeCartas, todasAsCartasJogadas);
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

        public bool EscolherCartaAposta(int inicio,int final,int incrementador,List<int> todasAsCartasJogadas)
        {
            for (int i = inicio; i != final; i += incrementador)
            {
                if (!todasAsCartasJogadas.Contains(i))
                {
                    partida.ApostarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    return true;
                }
            }
            return false;
        }

        public void Apostar(string rodadaAtual)
        {
            if(rodadaAtual == "9")
            {
                List<int> todasAsCartasJogadas = estrategia.VerificaCartasJogadas();
                int pontuacaoTurno = Jogadores[IdJogadores[0]].pontuacaoDoTurno;
                int quantidadeDeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);
                foiApostado = true;

                if (pontuacaoTurno > 4)
                {
                    bool apostou = EscolherCartaAposta(6, quantidadeDeCartas, 1,todasAsCartasJogadas);
                    if(apostou) return;
                    EscolherCartaAposta(5, 1, -1, todasAsCartasJogadas);
                }
                else
                {
                    bool apostou = EscolherCartaAposta(5, 1, -1, todasAsCartasJogadas);
                    if(apostou) return;
                    EscolherCartaAposta(6, quantidadeDeCartas, 1, todasAsCartasJogadas);
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

            PrimeiraCartaJogada(rodadaAtual);
            if (IdJogadores[0] == idJogadorRodadaAtual)
            {
                
                int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                if(naipePrimeiraCartaJogada == string.Empty && rodadaAtual == "1")
                {
                    ComecarPrimeiraRodada(quantidadeCartas);
                }
                else if(naipePrimeiraCartaJogada != string.Empty && rodadaAtual == "1")
                {
                    JogarMaiorCarta(quantidadeCartas);
                }
                else if(naipePrimeiraCartaJogada == string.Empty)
                {
                    ComecarRound(quantidadeCartas,todasAsCartasJogadas);
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
