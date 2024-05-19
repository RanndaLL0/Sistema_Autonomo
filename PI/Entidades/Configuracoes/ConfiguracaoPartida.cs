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
            string[] listaDeJogadores = GerenciadorDeStrings.ObterInformacaoDosJogadores(idPartida);
            return listaDeJogadores.Length;
        }

        public static List<ConfiguracaoMao>PosicaoCartas(int idPartida)
        {

            List<ConfiguracaoMao> configuracoes = new List<ConfiguracaoMao>();
            int quantidadeDeJogadores = ContarJogadores(idPartida);

            if(quantidadeDeJogadores == 2)
            {
                configuracoes.Add(new ConfiguracaoMao(x:850, xInicial:850, y:690, yInicial:690, contador:0, largura:91, altura:137, deslocamentoX:97, deslocamentoY:0, pulaLinhaX:0, pulaLinhaY:143, $"|.png"));
                configuracoes.Add(new ConfiguracaoMao(x:1335, xInicial:1335, y:155, yInicial:155, contador:0, largura:91, altura:137, deslocamentoX :- 97, deslocamentoY:0, pulaLinhaX:0, pulaLinhaY:- 143, $"|invertido.png"));
            }
            else 
            {
                configuracoes.Add(new ConfiguracaoMao(x: 800, xInicial: 800, y: 690, yInicial: 690, contador: 0, largura: 91, altura: 137, deslocamentoX: 97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: 143, $"|.png"));
                configuracoes.Add(new ConfiguracaoMao(x: 1516, xInicial: 1516, y: 730, yInicial: 730, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: -97, pulaLinhaX: 143, pulaLinhaY: 0, $"|esq.png"));
                configuracoes.Add(new ConfiguracaoMao(x: 1382, xInicial: 1382, y: 155, yInicial: 155, contador: 0, largura: 91, altura: 137, deslocamentoX: -97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: -143, $"|invertido.png"));
                configuracoes.Add(new ConfiguracaoMao(x: 620, xInicial: 620, y: 147, yInicial: 147, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: 97, pulaLinhaX: -143, pulaLinhaY: 0, $"|dir.png"));
            }
            return configuracoes;
        }

        public static List<int> ObterOrdemMesa(string[] jogadorNaMaquina, int idPartida)
        {
            string[] retornoBruto = GerenciadorDeStrings.ObterInformacaoDosJogadores(idPartida);
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
