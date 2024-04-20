public class Jogador
{
    public int X { get; set; }
    public int XInicial { get; set; }
    public int Y { get; set; }
    public int YInicial { get; set; }
    public int Count { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int DeslocamentoX { get; set; }
    public int DeslocamentoY { get; set; }
    public int PulaLinha { get; set; }
    public string DiretorioImagem { get; set; }

    public Jogador(int x, int xInicial, int y, int yInicial, int count, int width, int height, int deslocamentoX, int deslocamentoY, int pulaLinha, string diretorioImagem)
    {
        X = x;
        XInicial = xInicial;
        Y = y;
        YInicial = yInicial;
        Count = count;
        Width = width;
        Height = height;
        DeslocamentoX = deslocamentoX;
        DeslocamentoY = deslocamentoY;
        PulaLinha = pulaLinha;
        DiretorioImagem = diretorioImagem;
    }
}
}