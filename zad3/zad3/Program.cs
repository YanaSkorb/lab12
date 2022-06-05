using System;

namespace задание_3
{
    public delegate string Stroka(string a);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите действие: \n1 Удалить первое слово \n2 Замена всех букв о на ОК  \n3 Удаление точек ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите строку: ");
            string x = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Stroka calc = (c) => c;
                    string del = x.Remove(0, x.IndexOf(' ') + 1);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "2":
                    Stroka calc1 = (c) => c;
                    string del1 = x.Replace("о", "ОК");
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "3":
                    Stroka calc2 = (c) => c;
                    string zamena = x.Replace(".", "");
                    Console.WriteLine("Ответ: {0}", zamena);
                    break;
            }
            Console.ReadKey();
        }
    }
}
