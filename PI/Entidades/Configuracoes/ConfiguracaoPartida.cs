using MagicTrickServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class ConfiguracaoPartida
    {

        public static int ContarJogadores(int idPartida)
        {
            string[] listaDeJogadores = GerenciadorStrings.ObterInformacaoDosJogadores(idPartida);
            return listaDeJogadores.Length;
        }

        public static int QuantidadeCartasJogador(int idPartida)
        {
            if(ContarJogadores(idPartida) == 2)
            {
                return 12;
            }
            else
            {
                return 14;
            }
        }

        public static List<PosicaoCartas>PosicaoCartas(int idPartida)
        {

            List<PosicaoCartas> configuracoes = new List<PosicaoCartas>();
            int quantidadeDeJogadores = ContarJogadores(idPartida);

            if (quantidadeDeJogadores == 2)
            {
                configuracoes.Add(new PosicaoCartas(x: 631, xInicial: 631, y: 769, yInicial: 769, contador: 0, largura: 91, altura: 137, deslocamentoX: 97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: 143, desenhoCarta: $"|.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x: 1212, xInicial: 1212, y: 171, yInicial: 171, contador: 0, largura: 91, altura: 137, deslocamentoX: -97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: -143, desenhoCarta: $"|invertido.png", silhuetaCarta: $"|.png"));
            }
            else
            {
                configuracoes.Add(new PosicaoCartas(x: 631, xInicial: 631, y: 769, yInicial: 769, contador: 0, largura: 91, altura: 137, deslocamentoX: 97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: 143, desenhoCarta: $"|.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x: 1527, xInicial: 1527, y: 843, yInicial: 843, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: -97, pulaLinhaX: 143, pulaLinhaY: 0, desenhoCarta: $"|esq.png", silhuetaCarta: $"|dir.png"));
                configuracoes.Add(new PosicaoCartas(x: 1212, xInicial: 1212, y: 171, yInicial: 171, contador: 0, largura: 91, altura: 137, deslocamentoX: -97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: -143, desenhoCarta: $"|invertido.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x: 247, xInicial: 247, y: 260, yInicial: 260, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: 97, pulaLinhaX: -143, pulaLinhaY: 0, desenhoCarta: $"|dir.png", silhuetaCarta: $"|dir.png"));
            }
            return configuracoes;
        }

        public static List<int> ObterOrdemMesa(string[] jogadorNaMaquina,int idPartida)
        {
            string[] retornoBruto = GerenciadorStrings.ObterInformacaoDosJogadores(idPartida);
            List<int> IdJogadores = new List<int>();

            foreach (string jogador in retornoBruto)
            {
                string retornoTratado = jogador.Split(',')[0];
                int id = int.Parse(retornoTratado);
                IdJogadores.Add(id);
            }

            int idJogadorMaquina = int.Parse(jogadorNaMaquina[0]);
            int indexJogadorMaquina = IdJogadores.FindIndex(x => x == idJogadorMaquina);

            if(indexJogadorMaquina == 0)
            {
                return IdJogadores;
            }
            List<int> ListaMenorParte = IdJogadores.GetRange(0, indexJogadorMaquina);
            List<int> ListaMaiorParte = IdJogadores.GetRange(indexJogadorMaquina, IdJogadores.Count - indexJogadorMaquina);

            foreach(int id in ListaMenorParte)
            {
                ListaMaiorParte.Add(id);
            }
            return ListaMaiorParte;
        }
    }
}
