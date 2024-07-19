//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {    
        static void Main()
        {
            char[,] charArray = {
            { 'c', 'h', 'a', 'r', ' ' },
            { '&', ' ', 's', 'i', 'm' }, 
            { 'b', 'o', 'l', '!', ' '}
        };

            string result = Convert2DArrayToString(charArray);
            Console.WriteLine(result);
        }

        static string Convert2DArrayToString(char[,] array)
        {
            char[] result = new char[array.GetLength(0) * array.GetLength(1)];
            int index = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[index++] = array[i, j];
                }
            }

            return new string(result);
        }
    }

}*/

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

/*using System;

class Program
{
    static void Main()
    {
        string input = "AbRaCaDaBrA";

        string result = input.ToLower();

        Console.WriteLine(result);
    }
}*/

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Convert.ToString (Console.ReadLine());

        string _Input = input.Replace(" ", "").ToLower();

        char[] charArray = _Input.ToCharArray();
        Array.Reverse(charArray);
        string _reversed = new string(charArray);

        if (_Input == _reversed)
        {
            Console.WriteLine("Сие есть палиндром.");
        }
        else
        {
            Console.WriteLine("Сие не является палиндромом.");
        }
    }
}*/


//4.Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку неменее одного слова:");
        string input = Convert.ToString(Console.ReadLine());
        
        string[] individual_words = input.Split(' ');

        Array.Reverse(individual_words);

        string reversed = string.Join(" ", individual_words);

        Console.WriteLine("Обратный порядок:");
        Console.WriteLine(reversed);
    }
}





