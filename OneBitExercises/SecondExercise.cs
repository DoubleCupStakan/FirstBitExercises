using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBitExercises
{
    internal class SecondExercise
    {
        public void Sravnenie(double a, double b) 
        {
            double c = a;
            if(a == 0)
            {
                Console.WriteLine("Деление на ноль равняется нулю");
            }
            if(a != 0)
            {
                if (a > b || a == b)
                {
                    if (b != 0)
                    {
                        while (a != 0 && a > 0)
                        {
                            a = a - b;
                        }
                        if (a == 0)
                        {
                            Console.WriteLine($"Число {c} целочисленно делится на {b}");
                        }
                        else
                        {
                            Console.WriteLine($"Число {c} не делится целочисленно на {b}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нельзя делить на ноль");
                    }
                }
                else
                {
                    Console.WriteLine("Данные не соответсвуют условию задачи");
                }
            }
        }
    }
}
