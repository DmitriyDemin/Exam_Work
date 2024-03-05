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
            set_strings[i] = Console.ReadLine();
        }
        Console.WriteLine($"Начальный массив: [{string.Join(", ", set_strings)}]");
    
    }


}

