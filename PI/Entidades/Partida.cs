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
        private List<int> IdJogadores;
        private int Pontuacao;

        public Partida(Dictionary<int,Jogador> jogadores, List<int> idJogadores)
        {
            CartasJogadas = new List<Carta>();
            Jogadores = jogadores;
            IdJogadores = idJogadores;
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
            foreach(int Id in IdJogadores)
            {
                Jogadores[Id].ObterPontuacaoPartida();
                Jogadores[Id].ObterPontuacaoTurno();
            }
        }

    }
}
