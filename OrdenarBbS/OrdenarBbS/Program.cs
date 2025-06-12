int[] Ordenar(int[] B)
{
    for (int i = B.Length - 1; i > 0; i--)
    {
        for (int l = 0; l < B.Length - i - 1; l++)
        {
            if (B[l] > B[l + 1])
            {
                int temp = B[l];
                B[l] = B[l + 1];
                B[l + 1] = temp;
                int r = 1;
                Console.WriteLine("erro");
                
            }

        }
    }
    return B;
}

int[] number = { 5, 3, 4, 1, 2 };

number = Ordenar(number);

foreach (int num in number)
{
    Console.WriteLine(num);
}
