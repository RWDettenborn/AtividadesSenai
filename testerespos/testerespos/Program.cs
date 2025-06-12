const int TOTAL_VENDAS = 8;

int ContarAcimaMedia(double[] vendas, double media)
{
    int cont = 0;
    for (int i = 0; i < vendas.Length; i++)
    {
        if (vendas[i] > media)
        {
            cont++;
        }
    }
    return cont;
}

double CalcularMedia(double[] vendas)
{
    double totalVendas = 0;
    double media = 0;
    for (int i = 0; i < vendas.Length; i++)
    {
        totalVendas += vendas[i];
    }
    media = totalVendas / vendas.Length;
    return media;
}

double MaiorVenda(double[] vendas)
{
    double maiorVenda = 0;
    for (int i = 0; i < vendas.Length; i++)
    {
        if (i == 0)
        {
            maiorVenda = vendas[i];
        }
        else if (vendas[i] > maiorVenda)
        {
            maiorVenda = vendas[i];
        }
    }
    return maiorVenda;
}

double MenorVenda(double[] vendas)
{
    double menorVenda = 0;
    for (int i = 0; i < vendas.Length; i++)
    {
        if (i == 0)
        {
            menorVenda = vendas[i];
        }
        else if ((vendas[i] < menorVenda) && (i != 0))
        {
            menorVenda = vendas[i];
        }
    }
    return menorVenda;
}

double[] vendas = new double[TOTAL_VENDAS];
double media = 0;
double totalVendasAcimaMedia = 0;
double maiorVenda = 0;
double menorVenda = 0;

for (int i = 0; i < vendas.Length; i++)
{
    Console.Write($"Informe o valor da venda {i}: ");
    vendas[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("----------------------------------");
media = CalcularMedia(vendas);
Console.WriteLine($"Média das vendas......: {media:C}");
totalVendasAcimaMedia = ContarAcimaMedia(vendas, media);
Console.WriteLine($"Vendas acima da média.: {totalVendasAcimaMedia}");
maiorVenda = MaiorVenda(vendas);
Console.WriteLine($"Maior venda...........: {maiorVenda:C}");
menorVenda = MenorVenda(vendas);
Console.WriteLine($"Menor venda...........: {menorVenda:C}");