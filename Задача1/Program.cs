//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив символов
        char[,] charArray = {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        // Выводим исходный массив
        Console.WriteLine("Двумерный массив символов:");
        PrintCharArray(charArray);

        // Создаем строку из массива и выводим её
        string result = new string(charArray.Cast<char>().ToArray());
        Console.WriteLine("\nСтрока из массива:");
        Console.WriteLine(result);
    }

    // Метод для вывода двумерного массива символов
    static void PrintCharArray(char[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}

