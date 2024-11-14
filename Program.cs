using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 3;
            bool b00l = false;
            byte b = 1;
            short s = 0;
            long l = 0;
            float f = 2.3f;
            double d = 1.2;

            char c = 's';
            string str = "Hello";*/

            /*int a = 5;
            int b = 7;
            int c = 10;
            if (b > a && c > b)
            {
                Console.WriteLine($"Число {c} самое большое из этих чисел");
            }*/

            /*int a = 8;
            int b = 4;
            if (b > a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }*/
            /*int a = 7;
            int b = 7;
            if (b > a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else if (b < a)
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно числу {a}");
            }*/

            /*for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }*/
            /*int[] numbers = new int[5];
            int[] numbers2 = { 5, 6, 7, 8, 2 };
            Console.WriteLine(numbers2[3]);*/

            /*void HelloWorls()
            {
                Console.WriteLine("Hello");
            }
            HelloWorls();

            void Sum(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
            Sum(5, 7);*/

            /*string emaN = "Kirill";
            int egA = 22;

            void Human(string name, int age)
            {
                Console.WriteLine($"name = {name}, {age}");
            }
            Human(emaN, egA);*/
            House tower = new House();
            tower.street = "Красная";
            tower.number = 50;

            tower.Print();

            
        }
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"street,{number}");
            }
        }
    }
}
