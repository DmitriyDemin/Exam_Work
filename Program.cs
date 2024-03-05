using System;
namespace Exam_Work;
class Work_string
{
    public static void Main()
    {
        Console.Clear();
        string[] set_strings = new string [4];
        
        Console.WriteLine("Введите элементы строчного массива");
        for (int i= 0; i< set_strings.Length; i++)
        {
            set_strings[i] = Console.ReadLine()!;
        }
        // for (int j= 0; j< set_strings.Length; j++)
        // {
        //     if (set_strings[j] == " " | set_strings[j] == "")
        //     Console.WriteLine($"Начальный массив: [fgfh, 342, !2, %]");
        //  }
        Console.Write("Начальный массив: ");
        for (int j= 0; j< set_strings.Length; j++)
        {
            Console.Write($"[{set_strings[j]}]");
        }
        Console.WriteLine();
        string[] set_new = new string[4];
        for (int k= 0; k< set_strings.Length; k++)
        {
            string a = set_strings[k]; 
            if (a.Length <=3)
            set_new[k] = set_strings[k];
        }
    Console.WriteLine($"массив новых строк: [{string.Join(", ", set_new)}]");
    }


}

