using System;

namespace zad2
{
    public delegate double Delegat(int a, int b);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите действие:  +, -, *, /");
            string a = Console.ReadLine();
            Console.Write("Первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(5 / 3);
            switch (a)
            {
                case "+":
                    Delegat Delegat = (o, b) => { return o + b; };
                    double del = Delegat(x, y);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    Delegat Delegat1 = (c, b) => { return c - b; };
                    double del1 = Delegat1(x, y);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    Delegat Delegat2 = (c, b) => { return c * b; };
                    double del2 = Delegat2(x, y);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    Delegat Delegat3 = (c, b) =>
                    {
                        try
                        {
                            return c / b;
                        }
                        catch (Exception)
                        {
                            while (b == 0)
                            {
                                Console.WriteLine("b=0, введите число заново: ");
                                b = int.Parse(Console.ReadLine());

                            }
                        }
                        return c / b;

                    };
                    double del3 = Delegat3(x, y);
                    Console.WriteLine("Ответ:{0}", del3);
                    break;
            }
            Console.ReadKey();

        }
    }
}
