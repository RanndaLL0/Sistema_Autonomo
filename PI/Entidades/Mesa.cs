﻿using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Mesa
    {
        private Dictionary<int, Jogador> Jogadores;
        private List<ConfiguracaoMao> Maos;
        private Baralho baralho;
        private Partida tabuleiro;
        private int IdPartida;
        private string[] JogadorNaMaquina;

        public Mesa(string[] jogadorNaMaquina,int idPartida)
        {
            IdPartida = idPartida;
            JogadorNaMaquina = jogadorNaMaquina;
            Maos = new List<ConfiguracaoMao>();
            baralho = new Baralho();
            Jogadores = new Dictionary<int, Jogador>();

            Iniciar();
        }

        public void Iniciar()
        {
            Maos = ConfiguracaoPartida.PosicaoCartas(IdPartida);
            CriarJogadores();

            DistribuirCartas();
            tabuleiro = new Partida(Jogadores);
        }

        public void CriarJogadores()
        {

            List<int> IdJogadores = new List<int>();
            IdJogadores = ConfiguracaoPartida.ObterOrdemMesa(JogadorNaMaquina, IdPartida);

            for (int i = 0;i < IdJogadores.Count; i++)
            {
                string nomeJogador = GerenciadorDeStrings.ObterNomeDoJogador(IdJogadores[i],IdPartida);
                Jogadores.Add(IdJogadores[i], new Jogador(IdJogadores[i], Maos[i], nomeJogador));
            }
        }

        private void DistribuirCartas()
        {
            string[] todasAsCartas = GerenciadorDeStrings.ObterCartasDaPartida(IdPartida);

            foreach(string carta in todasAsCartas)
            {
                string[] informacoesDaCarta = carta.Split(',');
                int idJogador = int.Parse(informacoesDaCarta[0]);
                int idCarta = int.Parse(informacoesDaCarta[1]);
                char naipe = char.Parse(informacoesDaCarta[2]);

                Jogadores[idJogador].Baralho.AdicionarCarta(naipe,idCarta);
            }
        }

        public void ExibirCartas()
        {
        }
    }
}
