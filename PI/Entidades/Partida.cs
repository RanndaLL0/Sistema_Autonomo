﻿using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class Partida
    {
        private List<Carta> cartasJogadas;
        private Dictionary<int,Jogador> jogadores;
        private List<int> idJogadores;
        private int pontuacao;
        private Form formularioPartida;
        private int idPartida;
        private GerenciadorStrings gerenciadorDeStrings;

        public Partida(Dictionary<int,Jogador> jogadores, List<int> idJogadores,Form formularioPartida,int idPartida)
        {
            gerenciadorDeStrings = new GerenciadorStrings(idPartida);
            cartasJogadas = new List<Carta>();
            this.jogadores = jogadores;
            this.idJogadores = idJogadores;
            this.idPartida = idPartida;
            this.formularioPartida = formularioPartida;
        }

        public void JogarCarta()
        {

            TextBox txtIdJogador = formularioPartida.Controls.Find("txtIdJogador", true).FirstOrDefault() as TextBox;
            TextBox txtSenhaJogador = formularioPartida.Controls.Find("txtSenhaJogador", true).FirstOrDefault() as TextBox;
            TextBox txtIdCarta = formularioPartida.Controls.Find("txtIdCarta", true).FirstOrDefault() as TextBox;

            string retornoJogada = Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtIdCarta.Text));
            if (retornoJogada.Length > 4 && retornoJogada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro ao jogar:\n{retornoJogada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoverCartaJogada();
            ExibirCartaJogada();
            //CartasJogadas.Add(carta);
        }   

        private void RemoverCartaJogada()
        {
            string[] CartasJogadas = gerenciadorDeStrings.ObterJogadas();
            foreach(string carta in CartasJogadas)
            {
                int idJogador = int.Parse(carta.Split(',')[1]);
                int idCarta = int.Parse(carta.Split(',')[4]);
                char naipeCarta = char.Parse(carta.Split(',')[2]);

                if (jogadores[idJogador].Cartas.cartas[idCarta] != null)
                {
                    Jogador jogador = jogadores[idJogador];
                    string path = jogador.Posicao.SilhuetaCarta;
                    jogadores[idJogador].JogarCarta(idCarta,path,naipeCarta);
                }
            }
        }

        private void ExibirCartaJogada()
        {
            string[] jogadas = gerenciadorDeStrings.ObterJogadas();
            string[] ultimaRodada = jogadas[jogadas.Length - 1].Split(',');

            int x = 1300;


            foreach (string jogada in jogadas)
            {
                string[] rodada = jogada.Split(',');
                if (rodada[0] == ultimaRodada[0])
                {
                    string naipeCarta = rodada[2];
                    string numeroCarta = rodada[3];


                    string diretorioAtual = Directory.GetCurrentDirectory();
                    string caminhoImagem = Path.Combine(diretorioAtual, "../../Cards/numeros/", $"{numeroCarta}{naipeCarta}.png");

                    Panel carta = new Panel();
                    carta.BackgroundImage = Image.FromFile(caminhoImagem);
                    carta.Height = 231;
                    carta.Width = 143;
                    carta.Left = x;
                    carta.Top = 367;
                    Label cartaJogada = new Label();
                    cartaJogada.Text = rodada[1];
                    cartaJogada.AutoSize = true;
                    cartaJogada.Left = x + carta.Width / 2 - 15;
                    cartaJogada.Top = 608;


                    carta.BackgroundImageLayout = ImageLayout.Stretch;
                    formularioPartida.Controls.Add(carta);
                    formularioPartida.Controls.Add(cartaJogada);
                    x -= 164;
                }
            }
        }

        public void AtualizarPontuacaoJogadores()
        {
            foreach(int Id in idJogadores)
            {
                jogadores[Id].ObterPontuacaoPartida();
                jogadores[Id].ObterPontuacaoTurno();
            }
        }

    }
}
