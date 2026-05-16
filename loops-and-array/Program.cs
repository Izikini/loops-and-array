using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Exercise1()
    {
        int[] array = new int[] { 5, 10, 15, 20, 25 };
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }
    static void Exercise2()
    {
        int[] array = new int[] { 15, 10, 15, 20, 25 };
        int min = array[0];
        int max = array[0];

        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Minimum value: {min}\nMaximum value: {max}");
    }
    static void Exercise3()
    {
        string[] name = new string[] { "Jan", "Krzysztof", "Anna", "Maria" };
        for (int i = name.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(name[i]);
        }
    }
    static void Exercise4()
    {
        int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9 };
        int even_count = 0;
        int odd_count = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                even_count++;
            }
            else if (number % 2 == 1)
            {
                odd_count++;
            }
        }
        Console.WriteLine($"Number of even: {even_count}\nNumber of odd: {odd_count}");
    }
    static void Exercise5()
    {
        int[] array_a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] array_b = new int[array_a.Length];
        for (int i = 0; i < array_a.Length; i++)
        {
            array_b[i] = array_a[i] * 2;
        }
        Console.WriteLine($"Array A: {{ {string.Join(", ", array_a)} }}");
        Console.WriteLine($"Array B after operation: {{ {string.Join(", ", array_b)} }}");
    }
    static void Exercise6()
    {
        int[] array_numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Console.WriteLine("Enter the number you want to find");
        int searched_number = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < array_numbers.Length; i++)
        {
            if (array_numbers[i] == searched_number)
            {
                Console.WriteLine($"Number {searched_number} is in the array at index {i}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Number {searched_number} is not in the array.");
        }
    }
    static void Exercise7()
    {
        int[] array = new int[] { 12, 4, 5, 1, 54, 20 };
        for (int i = 0; i < array.Length / 2; i++)
        {
            int j = array.Length - 1 - i;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        Console.WriteLine($"Array after operation: {{ {string.Join(", ", array)} }}");
    }
    static void Main(string[] args)
    {
        Exercise7();
    }
}