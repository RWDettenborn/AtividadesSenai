void Crescente(ref int num1, ref int num2)
{
    if (num1 < num2)
    {
        return;
    }
    else
    {
        int temp = num2;
        num2 = num1;
        num1 = temp;
    }
}
void Decrescente(ref int num1, ref int num2)
{
    if (num1 > num2)
    {
        return;
    }
    else
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}

Console.WriteLine("Digite o primeiro número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Se for crescente digite (1) ou decrescente (2):");
int ordem = int.Parse(Console.ReadLine());

if (ordem == 1)
{
    Crescente(ref num1, ref num2);
    Console.WriteLine($"Os números em ordem crescente são: {num1}, {num2}.");
}
else if (ordem == 2)
{
    Decrescente(ref num1, ref num2);
    Console.WriteLine($"Os números em ordem decrescente são: {num1}, {num2}.");
}
else
{
    Console.WriteLine("Erro, escolha uma opção!");
}
