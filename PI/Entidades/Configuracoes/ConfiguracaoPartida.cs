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

        private int IdPartida { get; set; }
        private GerenciadorStrings gerenciadorDeStrings;
        public ConfiguracaoPartida(int idPartida) 
        {
            IdPartida = idPartida;
            gerenciadorDeStrings = new GerenciadorStrings(idPartida); 
        }

        public int ContarJogadores()
        {
            string[] listaDeJogadores = gerenciadorDeStrings.ObterInformacaoDosJogadores();
            return listaDeJogadores.Length;
        }

        public List<PosicaoCartas>PosicaoCartas()
        {

            List<PosicaoCartas> configuracoes = new List<PosicaoCartas>();
            int quantidadeDeJogadores = ContarJogadores();

            if(quantidadeDeJogadores == 2)
            {
                configuracoes.Add(new PosicaoCartas(x:850, xInicial:850, y:690, yInicial:690, contador:0, largura:91, altura:137, deslocamentoX:97, deslocamentoY:0, pulaLinhaX:0, pulaLinhaY:143, desenhoCarta: $"|.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x:1335, xInicial:1335, y:155, yInicial:155, contador:0, largura:91, altura:137, deslocamentoX :- 97, deslocamentoY:0, pulaLinhaX:0, pulaLinhaY:- 143, desenhoCarta: $"|invertido.png", silhuetaCarta: $"|.png"));
            }
            else 
            {
                configuracoes.Add(new PosicaoCartas(x: 800, xInicial: 800, y: 690, yInicial: 690, contador: 0, largura: 91, altura: 137, deslocamentoX: 97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: 143, desenhoCarta: $"|.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x: 1516, xInicial: 1516, y: 730, yInicial: 730, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: -97, pulaLinhaX: 143, pulaLinhaY: 0, desenhoCarta: $"|esq.png", silhuetaCarta: $"|dir.png"));
                configuracoes.Add(new PosicaoCartas(x: 1382, xInicial: 1382, y: 155, yInicial: 155, contador: 0, largura: 91, altura: 137, deslocamentoX: -97, deslocamentoY: 0, pulaLinhaX: 0, pulaLinhaY: -143, desenhoCarta: $"|invertido.png", silhuetaCarta: $"|.png"));
                configuracoes.Add(new PosicaoCartas(x: 620, xInicial: 620, y: 147, yInicial: 147, contador: 0, largura: 137, altura: 91, deslocamentoX: 0, deslocamentoY: 97, pulaLinhaX: -143, pulaLinhaY: 0, desenhoCarta: $"|dir.png", silhuetaCarta: $"|dir.png"));
            }
            return configuracoes;
        }

        public List<int> ObterOrdemMesa(string[] jogadorNaMaquina)
        {
            string[] retornoBruto = gerenciadorDeStrings.ObterInformacaoDosJogadores();
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
