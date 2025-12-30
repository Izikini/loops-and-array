using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Zadanie1()
    {
        int[] tabela = new int[] { 5, 10, 15, 20, 25 };
        int suma = 0;
        for (int i = 0; i <= tabela.Length; i++)
        {
            suma += tabela[i];
        }
        Console.WriteLine(suma);
    }
    static void Zadanie2() {
        int[] tabela = new int[] { 15, 10, 15, 20, 25 };
        int min = tabela[0];
        int max = tabela[0];

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

    }
    static void Zadanie3()
    {
        string[] imie = new string[] { "Jan", "Krzysztof", "Anna", "Maria" };
        for (int i = imie.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(imie[i]);
        }

    }
    static void Zadanie4()
    {
        int[] liczby = { 1, 2, 3, 5, 6, 7, 8, 9 };
        int ilosc_parzystych = 0;
        int ilosc_nieparzystych = 0;
        foreach (int liczba in liczby)
        {
            if (liczba % 2 == 0)
            { 
                ilosc_parzystych++;
            }
            else if (liczba % 2 == 1)
            {
                ilosc_nieparzystych++;
            }
        }
        Console.WriteLine($"Liczba parzystych: {ilosc_parzystych}\nLiczba nieparzystych: {ilosc_nieparzystych}");
    }
    static void Zadanie5()
    {
        int[] tablica_a = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] tablica_b = new int[tablica_a.Length];
        for (int i = 0; i < tablica_a.Length; i++)
        {
            tablica_b[i] = tablica_a[i] * 2;
        }
        Console.WriteLine($"Tablica A: {{ {string.Join(", ", tablica_a)} }}");
        Console.WriteLine($"Tablica B po operacji: {{ {string.Join(", ", tablica_b)} }}");
    }
    static void Main(string[] args)
    {
        Zadanie5();
    }
}