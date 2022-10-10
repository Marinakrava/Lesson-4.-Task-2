using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;// счетчик положительных чисел
            int sum2 = 0;// счетчик отрицательных чисел
            do// выполнять действие пока...
            {
                
                if (n > 0)
                    sum1++;             
                if (n < 0)
                    sum2++;
                n = Convert.ToInt32(Console.ReadLine());// последовательность ввода числа. т.е. проверяется условие "пока" не равно 0 и снова вводим
            }
            while (n != 0);// ... n не равно 0
            {
                if (sum1 < sum2)
                    Console.WriteLine("Количество отрицательных больше и равно {0}", sum2);
                if (sum1 > sum2)
                    Console.WriteLine("Количество положительных больше и равно {0}", sum1);
            }

            Console.ReadKey(); 

        }
    }
}
