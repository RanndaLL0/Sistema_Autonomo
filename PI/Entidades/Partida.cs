using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutonomo.Entidades
{
    public class Partida
    {
        private List<Carta> CartasJogadas;
        private Dictionary<int,Jogador> Jogadores;
        private int Pontuacao;

        public Partida(Dictionary<int,Jogador> jogadores)
        {
            CartasJogadas = new List<Carta>();
            Jogadores = jogadores;
        }

        public void JogarCarta(Carta carta)
        {
            CartasJogadas.Add(carta);
        }   

        public Carta RemoverCarta()
        {
            return null;
        }

        public void AtualizarPontuacaoJogadores()
        {

        }

    }
}
