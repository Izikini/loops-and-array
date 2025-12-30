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
        int[] tablica_a = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] tablica_b = new int[tablica_a.Length];
        for (int i = 0; i < tablica_a.Length; i++)
        {
            tablica_b[i] = tablica_a[i] * 2;
        }
        Console.WriteLine($"Tablica A: {{ {string.Join(", ", tablica_a)} }}");
        Console.WriteLine($"Tablica B po operacji: {{ {string.Join(", ", tablica_b)} }}");
    }
    static void Zadanie6()
    {
        int[] tablica_liczb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Console.WriteLine("Podaj liczbe ktora chcesz znalezc");
        int liczba_szukana = int.Parse(Console.ReadLine());
        bool znaleziono = false;
        for (int i = 0; i < tablica_liczb.Length; i++)
        {
            if (tablica_liczb[i] == liczba_szukana)
            {
                Console.WriteLine($"Liczba {liczba_szukana} znajduje sie w tablicy na indeksie {i}");
                znaleziono = true;
                break;
            }
        }
        if (!znaleziono)
        {
            Console.WriteLine($"Liczba {liczba_szukana} nie znajduje sie w tablicy.");
        }
    }
    static void Zadanie7()
    {
        int[] tablica = new int[] { 12, 4, 5, 1, 54, 20 };
        for (int i = 0; i < tablica.Length / 2; i++)
        {
            int j = tablica.Length - 1 - i;
            int temp = tablica[i];
            tablica[i] = tablica[j];
            tablica[j] = temp;
            
        }
        Console.WriteLine($"Tablica B po operacji: {{ {string.Join(", ", tablica)} }}");
    }
    static void Main(string[] args)
    {
        Zadanie7();
    }
}