using lobby;
using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class InicializadorPartida
    {
        private Dictionary<int, Jogador> jogadores;
        private Jogador jogadorNaMaquina;
        private GerenciadorStrings gerenciadorDeStrings;
        public Partida partida;        
        private ConfiguracaoPartida configuracaoPartida;

        public InicializadorPartida(string[] jogadorNaMaquinaString,int idPartida,Form game)
        {
            configuracaoPartida = new ConfiguracaoPartida(idPartida);
            gerenciadorDeStrings = new GerenciadorStrings(idPartida);
            jogadores = new Dictionary<int, Jogador>();
            IniciarPartida(idPartida, jogadorNaMaquinaString,game);
        }
            
        private void IniciarPartida(int idPartida, string[] jogadorNaMaquinaString,Form game)
        {
            CriarJogadores(jogadorNaMaquinaString);
            DistribuirCartas();
            partida = new Partida(jogadores,jogadores.Keys.ToList(),game,idPartida);
            new RenderizadorCartas(game, jogadores, idPartida);
        }

        private void CriarJogadores(string[] jogadorNaMaquinaString)
        {            
            List<int>IdJogadores = configuracaoPartida.ObterOrdemMesa(jogadorNaMaquinaString);
            List<PosicaoCartas> Maos = configuracaoPartida.PosicaoCartas();
            string senhaJogadorMaquina = jogadorNaMaquinaString[1];
            int IdJogadorMaquina = int.Parse(jogadorNaMaquinaString[0]);


            for (int i = 0;i < IdJogadores.Count; i++)
            {
                string nomeJogador = gerenciadorDeStrings.ObterNomeDoJogador(IdJogadores[i]);
                if (IdJogadores[i] == IdJogadorMaquina)
                {
                    jogadorNaMaquina = new Jogador(IdJogadorMaquina, Maos[i], nomeJogador, senhaJogadorMaquina);
                    jogadores.Add(IdJogadores[i], jogadorNaMaquina);
                }
                else
                {
                    jogadores.Add(IdJogadores[i], new Jogador(IdJogadores[i], Maos[i], nomeJogador));
                }
            }
        }

        public void DistribuirCartas()
        {
            string[] todasAsCartas = gerenciadorDeStrings.ObterCartasDaPartida();

            foreach(string carta in todasAsCartas)
            {
                string[] informacoesDaCarta = carta.Split(',');
                int idJogador = int.Parse(informacoesDaCarta[0]);
                int idCarta = int.Parse(informacoesDaCarta[1]);
                char naipe = char.Parse(informacoesDaCarta[2]);

                jogadores[idJogador].Cartas.AdicionarCarta(naipe,idCarta);
            }
        }
    }
}
