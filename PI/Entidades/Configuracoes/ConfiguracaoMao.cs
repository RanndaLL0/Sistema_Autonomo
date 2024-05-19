public class ConfiguracaoMao
{
    public int X { get; set; }
    public int XInicial { get; set; }
    public int Y { get; set; }
    public int YInicial { get; set; }
    public int Contador { get; set; }
    public int Largura { get; set; }
    public int Altura { get; set; }
    public int DeslocamentoX { get; set; }
    public int DeslocamentoY { get; set; }
    public int PulaLinhaX { get; set; }
    public int PulaLinhaY { get; set; }
    public string DesenhoCarta { get; set; }


    public ConfiguracaoMao(int x, int xInicial, int y, int yInicial, int contador, int largura, int altura, int deslocamentoX, int deslocamentoY, int pulaLinhaX, int pulaLinhaY, string desenhoCarta)
    {
        X = x;
        XInicial = xInicial;
        Y = y;
        YInicial = yInicial;
        Contador = contador;
        Largura = largura;
        Altura = altura;
        DeslocamentoX = deslocamentoX;
        DeslocamentoY = deslocamentoY;
        PulaLinhaX = pulaLinhaX;
        PulaLinhaY = pulaLinhaY;
        DesenhoCarta = desenhoCarta;
    }
}