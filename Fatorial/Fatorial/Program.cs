int Fatorial(int num)
{
    int resultado = 1;
    for (int i = num; i >= 1; i--)
    {
        resultado *= i;
        Console.WriteLine(i);
    }
    return resultado;
}

Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"O Resultado: {Fatorial(numero)}.");

