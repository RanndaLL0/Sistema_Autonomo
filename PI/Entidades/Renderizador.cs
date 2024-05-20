using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Renderizador
    {
        public Dictionary<int,Jogador> Jogadores { get; set; }
        public List<int> IdJogadores { get; set; }
        private string diretorioAtual = Directory.GetCurrentDirectory();
        public Form Game;
        private  int IdPartida;
        public Renderizador(Form game, List<int> idJogadores,Dictionary<int,Jogador> jogadores, int idPartida) 
        {
            Jogadores = jogadores;
            IdJogadores = idJogadores;
            IdPartida = idPartida;
            Game = game;
            Renderizar();
        }

        private void QuebraLinha(Jogador jogador)
        {
            int numeroDeJogadores = IdJogadores.Count;

            if (jogador.Posicao.Contador == 6 && numeroDeJogadores == 2 || jogador.Posicao.Contador == 7 && numeroDeJogadores == 4)
            {
                jogador.Posicao.X = jogador.Posicao.XInicial + jogador.Posicao.PulaLinhaX;
                jogador.Posicao.Y = jogador.Posicao.YInicial + jogador.Posicao.PulaLinhaY;
            }
        }

        public void Renderizar()
        {
            foreach(int Id in  IdJogadores)
            {
                Jogador jogador = Jogadores[Id];
                for(int i = 1; i <= jogador.Baralho.cartas.Count; i++)
                {
                    QuebraLinha(jogador);
                    Panel carta = new Panel();
                    carta.Left = jogador.Posicao.X;
                    carta.Top = jogador.Posicao.Y;
                    jogador.Posicao.X += jogador.Posicao.DeslocamentoX;
                    jogador.Posicao.Y += jogador.Posicao.DeslocamentoY;
                    jogador.Posicao.Contador++;

                    carta.Width = jogador.Posicao.Largura;
                    carta.Height = jogador.Posicao.Altura;

                    
                    if (jogador.Baralho.cartas.ContainsKey(i))
                    {
                        string caminho = jogador.Posicao.DesenhoCarta.Replace('|', jogador.Baralho.cartas[i].Naipe);
                        carta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/", caminho));
                    }
                    else
                    {
                        string[] CartasJogadas = GerenciadorDeStrings.ObterJogadas(IdPartida);
                        foreach (string Carta in CartasJogadas)
                        {
                            int idJogador = int.Parse(Carta.Split(',')[1]);
                            int idCarta = int.Parse(Carta.Split(',')[4]);
                            char naipeCarta = char.Parse(Carta.Split(',')[2]);

                            if (Id == idJogador && idCarta == i)
                            {
                                Jogador Jogador = Jogadores[idJogador];
                                Jogador.Baralho.AdicionarCarta(naipeCarta, idCarta);
                                string caminho = Jogador.Posicao.SilhuetaCarta.Replace('|', naipeCarta);
                                carta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/Empty Space/", caminho));
                            }
                        }
                    }
                    carta.BackgroundImageLayout = ImageLayout.Stretch;

                    jogador.Baralho.cartas[i].ImagemDaCarta = carta;

                    Game.Controls.Add(jogador.Baralho.cartas[i].ImagemDaCarta);
                }
            }
        }


    }
}
