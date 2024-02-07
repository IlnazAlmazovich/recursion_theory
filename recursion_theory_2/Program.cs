using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_theory_2
{
    internal class Program
    {
        //Фибоначчи
        //Пользователь вводит число. Определить какое число в последовательности Фибоначи находится под номером который ввёл пользователь.
        static  int Fibo(int n) // создаём метод с параметром n
        {
            if (n == 1) //Базовый варинт
            {
                return 1;
            }
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2); //вычисление двух предыдущих чисел которое образует следующее
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine()); //пользователь вводит число
            Console.WriteLine(Fibo(n));//вызываем метод при выводе на консоль
            Console.ReadKey();
        }
    }
}
