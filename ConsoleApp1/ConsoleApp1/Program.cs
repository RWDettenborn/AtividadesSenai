int ValorMaximo(int[] valores)
{
    int max = valores[0];
    foreach (int valor in valores)
    {
        if (valor > max)
        {
            max = valor;
        }
    }
    return max;
}   
int ValorMinimo(int[] valores)
{
    int min = valores[0];
    foreach (int valor in valores)
    {
        if (valor < min)
        {
            min = valor;
        }
    }
    return min;
}

int[] valores = new int[10];

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Digite o número {i + 1}: ");
    valores[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Os números digitados foram:");
foreach (int num in valores)
{
    Console.WriteLine(num);
}

Console.WriteLine($"O maior valor é: {ValorMaximo(valores)} {}.");

Console.WriteLine($"O menor valor é: {ValorMinimo(valores)}.");

/*INVERTER O VALOR DE MIN E MAX PARA O INDICE(VETOR)*/