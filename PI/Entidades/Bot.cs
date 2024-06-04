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
        private Partida partida;

        private int IdPartida;
        private string rodada = string.Empty;
        public string naipePrimeiraCartaJogada = string.Empty;
        private bool foiApostado = false;

        private ComecarRodada comecarRodada;
        private ComecarTurno comecarTurno;
        private ResponderPrimeiroTurno responderPrimeiroTurno;
        private ResponderTurno responderTurno;

        public Bot(Partida partida,int idPartida,Timer timer,Dictionary<int,Jogador> jogadores)
        {
            IdPartida = idPartida;
            Jogadores = jogadores;
            IdJogadores = jogadores.Keys.ToList<int>();

            estrategia = new Estrategia(idPartida, IdJogadores[0]);
            comecarRodada = new ComecarRodada(estrategia);
            comecarTurno = new ComecarTurno(estrategia);
            responderPrimeiroTurno = new ResponderPrimeiroTurno(estrategia);
            responderTurno = new ResponderTurno(estrategia);

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
                foiApostado = false;
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
                    comecarRodada.Jogar(quantidadeCartas, IdPartida, Jogadores[IdJogadores[0]],partida); //ComecarRodada
                }
                else if(naipePrimeiraCartaJogada != string.Empty && rodadaAtual == "1")
                {
                    responderPrimeiroTurno.Jogar(quantidadeCartas,IdPartida, Jogadores[IdJogadores[0]],partida, todasAsCartasJogadas,naipePrimeiraCartaJogada); //ResponderPrimeiroTurno
                }
                else if(naipePrimeiraCartaJogada == string.Empty)
                {
                    comecarTurno.Jogar(quantidadeCartas, IdPartida, Jogadores[IdJogadores[0]],partida,todasAsCartasJogadas); //ComecarTurno
                }
                else
                {
                    responderTurno.Jogar(quantidadeCartas, IdPartida, Jogadores[IdJogadores[0]],partida,todasAsCartasJogadas,naipePrimeiraCartaJogada); //ResponderTurno
                }

                if(foiApostado && rodadaAtual == "1")
                {
                    foiApostado = false;
                }

                if(!foiApostado)
                {
                    Apostar(rodadaAtual);
                }
            }
        }
    }
}
