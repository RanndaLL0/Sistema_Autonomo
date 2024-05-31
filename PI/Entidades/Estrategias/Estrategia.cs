using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades.Estrategias
{
    public class Estrategia
    {
        private ConfiguracaoPartida configuracaoPartida;
        private int IdPartida;
        public Estrategia(int idPartida) 
        {
            IdPartida = idPartida;
            configuracaoPartida = new ConfiguracaoPartida();
        }

        public int QuantidadeCopas(Jogador jogador)
        {
            int quantidadeCopas = 0;
            int quantidadeCartas = ConfiguracaoPartida.QuantidadeCartasJogador(IdPartida);

            for(int i = 1; i <= quantidadeCartas; i++)
            {
                if (jogador.Cartas.cartas[i].Naipe == 'C')
                {
                    quantidadeCopas++;
                }
            }
            return quantidadeCopas;
        }

    }
}
