//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        string inputString = "казнить нельзя, помиловать"; // Здесь вы можете задать свою строку

        // Разбиваем исходную строку на слова
        string[] words = inputString.Split(' ');

        // Обратно упорядочиваем слова и объединяем их в новую строку
        Array.Reverse(words);
        string reversedString = string.Join(" ", words);

        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка с обратным порядком слов: " + reversedString);
    }
}
