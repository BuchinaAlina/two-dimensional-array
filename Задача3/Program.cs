//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main()
    {
        string inputString = "Ехал Грека через реку"; // Здесь вы можете задать свою строку

        // Удаляем все пробелы и приводим строку к нижнему регистру
        string cleanedString = RemoveSpacesAndToLower(inputString);

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(cleanedString);

        Console.WriteLine("Исходная строка: " + inputString);
        if (isPalindrome)
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }

    // Метод для удаления пробелов и приведения строки к нижнему регистру
    static string RemoveSpacesAndToLower(string str)
    {
        return new string(str.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray()).ToLower();
    }

    // Метод для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
