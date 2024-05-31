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
        public static string[] TratarEntrada(string entrada)
        {
            if (entrada.Length > 4 && entrada.StartsWith("ERRO"))
            {
                MessageBox.Show($"Ocorreu um erro :\n{entrada.Substring(5)}", "MagicTrick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            entrada = entrada.Replace("\r", "");
            if (entrada.Length > 0)
                entrada = entrada.Substring(0, entrada.Length - 1);

            return entrada.Split('\n');
        }

        public static string[] ObterCartasDaPartida(int IdPartida)
        {

            string CartasList = Jogo.ConsultarMao(IdPartida);
            return TratarEntrada(CartasList);
        }

        public static string[] ObterVez(int idPartida)
        {
            string retornoBruto = Jogo.VerificarVez2(idPartida);
            return TratarEntrada(retornoBruto);
        }

        public static string[] ObterInformacaoDosJogadores(int idPartida)
        {
            string retornoBruto = Jogo.ListarJogadores2(idPartida);
            return TratarEntrada(retornoBruto);

        }

        public static string ObterNomeDoJogador(int idJogador, int idPartida)
        {
            string[] retornoBruto = ObterInformacaoDosJogadores(idPartida);

            foreach (string jogador in retornoBruto)
            {
                string[] retornoTratado = jogador.Split(',');
                if (idJogador == int.Parse(retornoTratado[0]))
                {
                    return retornoTratado[1];
                }
            }
            return null;
        }

        public static List<int> ObterJogadasPeloJogador(int idPartida, int idJogador)
        {
            string[] retornoBruto = ObterJogadas(idPartida);
            if (retornoBruto[0] == "")
            {
                return null;
            }
            List<int> listaDeCartasJogadas = new List<int>();

            foreach(string jogada in retornoBruto)
            {
                string[] retornoTratado = jogada.Split(',');
                if (idJogador == int.Parse(retornoTratado[1]))
                {
                    listaDeCartasJogadas.Add(int.Parse(retornoTratado[4]));
                }
            }
            return listaDeCartasJogadas;
        }

        public static string[] ObterJogadas(int idPartida)
        {
            string retornoBruto = Jogo.ExibirJogadas2(idPartida);
            return TratarEntrada(retornoBruto);
        }

        public static List<string> ObterCartasApostadas(int idPartida)
        {
            string[] retornoBruto = ObterVez(idPartida);
            if (retornoBruto[0] == "")
            {
                return null;
            }
            List<string> cartasApostadas = new List<string>();
            foreach (string informacaoRodadaAtual in retornoBruto)
            {
                if (informacaoRodadaAtual.StartsWith("A"))
                {
                    cartasApostadas.Add(informacaoRodadaAtual);
                }
            }
            return cartasApostadas;

        }

        public static List<int> ObterIdsCartasApostadas(int idPartida)
        {
            List<string> cartasApostadas = ObterCartasApostadas(idPartida);
            if (cartasApostadas == null)
            {
                return null;
            }
            List<int> idCartasApostadas = new List<int>();
            foreach (string Carta in cartasApostadas)
            {
                int idCarta = int.Parse(Carta.Split(',')[4]);
                idCartasApostadas.Add(idCarta);
            }
            return idCartasApostadas;
        }
        public static string[] UltimaCartaJogada(int idPartida)
        {
            string[] retornoBruto = ObterJogadas(idPartida);
            string[] ultimaJogada = retornoBruto[retornoBruto.Length - 1].Split(',');

            return ultimaJogada;
        }
    }
}
