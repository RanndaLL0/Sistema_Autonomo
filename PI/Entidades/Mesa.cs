using MagicTrickServer;
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
        public Partida Partida;
        private int IdPartida;
        private string[] JogadorNaMaquina;
        private List<int> IdJogadores;
        private Renderizador renderizador;
        private Form Game;

        public Mesa(string[] jogadorNaMaquina,int idPartida,Form game)
        {
            IdPartida = idPartida;
            JogadorNaMaquina = jogadorNaMaquina;
            Maos = new List<ConfiguracaoMao>();
            baralho = new Baralho();
            Jogadores = new Dictionary<int, Jogador>();
            IdJogadores = new List<int>();

            Game = game;
            Iniciar();
            renderizador = new Renderizador(Game,IdJogadores,Jogadores);
        }
            
        private void Iniciar()
        {
            Maos = ConfiguracaoPartida.PosicaoCartas(IdPartida);
            CriarJogadores();
            DistribuirCartas();
            Partida = new Partida(Jogadores,IdJogadores,Game,IdPartida);
        }

        private void CriarJogadores()
        {            
            IdJogadores = ConfiguracaoPartida.ObterOrdemMesa(JogadorNaMaquina, IdPartida);
            string senhaJogadorMaquina = JogadorNaMaquina[1];
            int IdJogadorMaquina = int.Parse(JogadorNaMaquina[0]);


            for (int i = 0;i < IdJogadores.Count; i++)
            {
                string nomeJogador = GerenciadorDeStrings.ObterNomeDoJogador(IdJogadores[i],IdPartida);
                if (IdJogadores[i] == IdJogadorMaquina)
                {
                    Jogadores.Add(IdJogadores[i], new Jogador(IdJogadorMaquina, Maos[i], nomeJogador, senhaJogadorMaquina));
                }
                else
                {
                    Jogadores.Add(IdJogadores[i], new Jogador(IdJogadores[i], Maos[i], nomeJogador));
                }
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
    }
}
