﻿using System;
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
        private string naipePrimeiraCartaJogada = string.Empty;

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
                return;
            }

            string[] retornoTratado = retornoBruto[retornoBruto.Length - 1].Split(',');


            if (rodada != rodadaAtual && idJogadorRodadaAtual == IdJogadores[0])
            {
                naipePrimeiraCartaJogada = string.Empty;
                rodada = rodadaAtual;
            }
            else 
            {
                rodada = rodadaAtual;
                naipePrimeiraCartaJogada = retornoTratado[2];
            }
        }

        public void JogarCopas()
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

        public void JogarMaiorCarta(int quantidadeDeCartas)
        {
            partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, quantidadeDeCartas);
            naipePrimeiraCartaJogada = string.Empty;
            return;
        }

        public void ComecarRound(int quantidadeDeCartas)
        {
            int quantidadeCopas = estrategia.QuantidadeCopas(Jogadores[IdJogadores[0]]);
            if (quantidadeCopas != 0)
            {
                JogarCopas();
                return;
            }
            JogarMaiorCarta(quantidadeDeCartas);
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
            for (int i = quantidadeDeCartas; i >= 1; i--)
            {
                if (todasAsCartasJogadas != null && !todasAsCartasJogadas.Contains(i))
                {
                    partida.JogarCarta(IdJogadores[0], Jogadores[IdJogadores[0]].senha, i);
                    naipePrimeiraCartaJogada = string.Empty;
                    return;
                }
            }
        }

        public void TomarDecisao()
        {
            List<int> TodasAsCartasJogadas = estrategia.VerificaCartasJogadas();

            string[] vez = GerenciadorStrings.ObterVez(IdPartida);
            int idJogadorRodadaAtual = int.Parse(vez[0].Split(',')[1]);
            string rodadaAtual = vez[0].Split(',')[2];

            PrimeiraCartaJogada(idJogadorRodadaAtual, rodadaAtual);
            if (IdJogadores[0] == idJogadorRodadaAtual)
            {

                
                int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

                if (naipePrimeiraCartaJogada == string.Empty && rodadaAtual == "1")
                {
                    ComecarRound(quantidadeCartas);
                    return;
                }
                else if(naipePrimeiraCartaJogada == string.Empty)
                {
                    ComecarRound(quantidadeCartas,TodasAsCartasJogadas);
                }
                else
                {
                    JogarMaiorCarta(quantidadeCartas,TodasAsCartasJogadas);
                }
            }
        }
    }
}
