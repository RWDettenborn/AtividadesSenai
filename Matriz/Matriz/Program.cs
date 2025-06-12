int[,] matriz = new int[1,3]{{ 1, 2, 3 }};
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine( matriz[i, j]);
    }
}