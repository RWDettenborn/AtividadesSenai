int[] Inverter(int[] v)
{
    for (int i = 0; i < v.Length /2; i++)
    {
        int temp = v[i];
        v[i] = v [v.Length - 1 - i];
        v[v.Length - 1 - i] = temp;
    }
    return v;
}

int[] number = { 1, 2, 3, 4, 5, 6 };

number = Inverter(number);

foreach (int item in number)
{
    Console.WriteLine($"Conteúdo {item}");
}