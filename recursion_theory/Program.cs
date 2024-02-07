using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_theory
{
    internal class Program
    {
        //Пользователь вводит некое число.
        //вычислить факториал числа с помощью рекурсивного метода
        static int recursion(int a)// создаём метод с параметрром а
        {
            if (a == 0 || a == 1) //объявляем базовый случай
            {
                return 1;//возвращаем 1 если а равен нулю или единице

            } 
            else
            {
                return recursion(a-1) * a ;// вызываем сам метод для вычисления факториала
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {a} = {recursion(a)}"); //вызываем метод
            Console.ReadKey();
        }
    }
}
