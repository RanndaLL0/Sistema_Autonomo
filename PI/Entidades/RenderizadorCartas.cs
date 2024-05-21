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
    public class RenderizadorCartas
    {
        public Dictionary<int,Jogador> jogadores { get; set; }
        private GerenciadorStrings gerenciadorDeStrings;
        public Form formularioPartida;

        public RenderizadorCartas(Form formularioPartida,Dictionary<int,Jogador> jogadores, int idPartida) 
        {
            this.jogadores = jogadores;
            this.gerenciadorDeStrings = new GerenciadorStrings(idPartida);
            this.formularioPartida = formularioPartida;
            Renderizar();
        }

        private void QuebraLinha(Jogador jogador)
        {
            int numeroDeJogadores = jogadores.Count;

            if (jogador.Posicao.Contador == 6 && numeroDeJogadores == 2 || jogador.Posicao.Contador == 7 && numeroDeJogadores == 4)
            {
                jogador.Posicao.X = jogador.Posicao.XInicial + jogador.Posicao.PulaLinhaX;
                jogador.Posicao.Y = jogador.Posicao.YInicial + jogador.Posicao.PulaLinhaY;
            }
        }

        public void Renderizar()
        {
            string diretorioAtual = Directory.GetCurrentDirectory();
            List<int> idJogadores = jogadores.Keys.ToList();
            foreach (int Id in  idJogadores)
            {
                Jogador jogador = jogadores[Id];
                for(int i = 1; i <= jogador.Cartas.cartas.Count; i++)
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

                    
                    if (jogador.Cartas.cartas.ContainsKey(i))
                    {
                        string caminho = jogador.Posicao.DesenhoCarta.Replace('|', jogador.Cartas.cartas[i].Naipe);
                        carta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/", caminho));
                    }
                    else
                    {
                        string[] CartasJogadas = gerenciadorDeStrings.ObterJogadas();
                        foreach (string Carta in CartasJogadas)
                        {
                            int idJogador = int.Parse(Carta.Split(',')[1]);
                            int idCarta = int.Parse(Carta.Split(',')[4]);
                            char naipeCarta = char.Parse(Carta.Split(',')[2]);

                            if (Id == idJogador && idCarta == i)
                            {
                                Jogador Jogador = jogadores[idJogador];
                                Jogador.Cartas.AdicionarCarta(naipeCarta, idCarta);
                                string caminho = Jogador.Posicao.SilhuetaCarta.Replace('|', naipeCarta);
                                carta.BackgroundImage = Image.FromFile(Path.Combine(diretorioAtual, "../../Cards/Empty Space/", caminho));
                            }
                        }
                    }
                    carta.BackgroundImageLayout = ImageLayout.Stretch;
                    jogador.Cartas.cartas[i].ImagemDaCarta = carta;
                    formularioPartida.Controls.Add(jogador.Cartas.cartas[i].ImagemDaCarta);
                }
            }
        }


    }
}
