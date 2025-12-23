int[] tabela = new int[] { 15, 10, 15, 20, 25 };
int min= tabela[0];
int max= tabela[0];

foreach (int liczba in tabela)
{
    if (liczba < min)
    {
        min = liczba;
    }
    if (liczba > max)
    {
        max = liczba;
    }
}
Console.WriteLine($"Wartosc minamlna: {min}\nWartosc maxymalna {max}");
