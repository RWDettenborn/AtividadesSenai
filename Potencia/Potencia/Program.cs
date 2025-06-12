int CalcularPotencia(int numBase, int numExpoente)
{
    int potencia = 1;
    for (int i = 1; i <= numExpoente; i++)
    {
        potencia = potencia * numBase;
    }
    return potencia;
}

Console.WriteLine("Digite o número da Base:");
int numBase = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número do Expoente:");
int numExpoente = int.Parse(Console.ReadLine());

Console.WriteLine($"O Resultado é: {CalcularPotencia(numBase, numExpoente)}.");

