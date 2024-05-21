using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAutonomo.Entidades
{
    public class GerenciadorStrings
    {
        public int IdPartida { get; set; }
        public GerenciadorStrings(int idPartida)
        {
            IdPartida = idPartida;
        }

        public string[] TratarEntrada(string entrada)
        {
            if (entrada.Length > 4 && entrada.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro :\n{entrada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            entrada = entrada.Replace("\r", "");
            if (entrada.Length > 0)
                entrada = entrada.Substring(0, entrada.Length - 1);

            return entrada.Split('\n');
        }

        public string[] ObterCartasDaPartida()
        {

            string CartasList = Jogo.ConsultarMao(IdPartida);
            return TratarEntrada(CartasList);
        }

        public string[] ObterInformacaoDosJogadores()
        {
            string retornoBruto = Jogo.ListarJogadores(IdPartida);
            return TratarEntrada(retornoBruto);

        }

        public string ObterNomeDoJogador(int idJogador)
        {
            string[] retornoBruto = ObterInformacaoDosJogadores();

            foreach(string jogador in retornoBruto)
            {
                string[] retornoTratado = jogador.Split(',');
                if (idJogador == int.Parse(retornoTratado[0]))
                {
                    return retornoTratado[1];
                }
            }
            return null;
        }

        public string[] ObterJogadas()
        {
            string retornoBruto = Jogo.ExibirJogadas2(IdPartida);
            return TratarEntrada(retornoBruto);
        }
    }
}
