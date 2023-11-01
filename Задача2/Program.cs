//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        string originalString = "HeLLo WoRLd"; // Ваша исходная строка

        // Заменяем все заглавные буквы на строчные
        string modifiedString = originalString.ToLower();

        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Измененная строка: " + modifiedString);
    }
}
