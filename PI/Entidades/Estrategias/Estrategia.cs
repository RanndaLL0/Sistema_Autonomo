using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class Estrategia
    {
        private int IdPartida;
        private int IdJogadorNaMaquina; 

        public Estrategia(int idPartida,int idJogadorNaMaquina) 
        {
            IdPartida = idPartida;
            IdJogadorNaMaquina = idJogadorNaMaquina;
        }

        public int QuantidadeCopas(Jogador jogador)
        {
            List<int> cartasJogadas = VerificaCartasJogadas();
            int quantidadeCopas = 0;
            int quantidadeCopasUsadas = 0;

            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

            for(int i = 1; i <= quantidadeCartas; i++)
            {
                if (jogador.Cartas.cartas[i].Naipe == 'C')
                {
                    quantidadeCopas++;
                }
            }

            if (cartasJogadas == null)
            {
                return quantidadeCopas;
            }

            for (int i = 0; i < cartasJogadas.Count; i++)
            {
                if (jogador.Cartas.cartas[cartasJogadas[i]].Naipe == 'C')
                {
                    quantidadeCopasUsadas++;
                }
            }

            return quantidadeCopas - quantidadeCopasUsadas;
        }

        public List<int> VerificaCartasJogadas()
        {
            List<int> idsCartasJogadas = GerenciadorStrings.ObterJogadasPeloJogador(IdPartida, IdJogadorNaMaquina);
            List<int> idsCartasApostadas = GerenciadorStrings.ObterCartaApostadaJogadorMaquina(IdPartida, IdJogadorNaMaquina);

            if (idsCartasJogadas == null || idsCartasApostadas == null) { return null; }

            List<int> idsTodasCartasJogadas = new List<int>();

            idsTodasCartasJogadas.AddRange(idsCartasJogadas);
            idsTodasCartasJogadas.AddRange(idsCartasApostadas);
            
            return idsTodasCartasJogadas;
        }
    }
}
