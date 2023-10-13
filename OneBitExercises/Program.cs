using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBitExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondExercise second = new SecondExercise();

            int[] masOne = new int[] {1, 3, 5, 7, 9}; // задание 4
            int[] masTwo = new int[] {2, 4, 6, 8, 10};
            int[] OneTwo = new int[masOne.Length + masTwo.Length];
            for(int i=0, j = 0, k = 0; ; k++)
            {
                if(i < masOne.Length && j < masTwo.Length)
                {
                    OneTwo[k] = masOne[i] < masTwo[j] ? masOne[i++]: masTwo[j++] ;
                }
                else if(i < masOne.Length)
                {
                    OneTwo[k] = masOne[i++];
                }
                else if(j < masTwo.Length)
                {
                    OneTwo[k] = masTwo[j++];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();

            foreach(int arrayNums in  OneTwo)
            {
                Console.Write($"{arrayNums} ");
            }
            Console.WriteLine();

            Dictionary<int, int> A = new Dictionary<int, int>() { {0, 2}, {1, 1} }; // задание 3
            Console.WriteLine("Введите знаение переменной А, при условии: \n" +
                              "Если А = 0, тогда В = 2, иначе В = 1(А может принимать значение 0 или 1)");
            int CallA = int.Parse(Console.ReadLine());
            if ( CallA != 0 || CallA != 1)

            Console.WriteLine($"B = { A[CallA]}");


            Console.WriteLine("Введите два числа: (Условие - Первое число должно быть больше второго!)"); //задание 2 
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            second.Sravnenie(num1, num2);
            Console.WriteLine();

            Console.WriteLine("Введите размер матрицы: "); //задание 1
            int N = int.Parse(Console.ReadLine());
            int[,] mas = new int[N, N];                                    
                                                                           
            for(int i = 0; i < mas.GetLength(0); i++)                     
            {                                                             
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for(int i = 0; i < N; i++)
            {
                sum += mas[i, N- i-1];
            }
            Console.WriteLine(sum);
              
            Console.ReadLine();
        }
    }
}
