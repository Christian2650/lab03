int[] tabela = new int[14] { 0, 45, 23, 14, 46, 57, 324, 56, 57, 43, 5, 435, 234, 45 };
int max;
int min;
int MaxIMin = tabela.Length;
max = tabela[0];
min = tabela[0];
foreach (int i in tabela)
{
    if (i > max)
    {
        max = i;
    }
    if (i < min)
    {
        min = i;
    }
}

Console.WriteLine("Największa Liczba z tabeli:" + max);
Console.WriteLine("Największa Liczba z tabeli:" + min);
