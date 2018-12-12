using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1212
{
    class Program
    {

        static bool IsADividedByBNoModule(int a, int b)
        {
            // longer
            //if (a % b == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            // shorter trick
            return a % b == 0;

        }

        static void Aplus1Bmul2(ref int a, ref int b)
        {
            a = a + 1;
            b = b * 2;
        }


        private static void InputFromUserTwoNumbers(out int c, out int d)
        {
            Console.WriteLine("Enter first number:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number:");
            d = Convert.ToInt32(Console.ReadLine());
        }

        private static double PrintPowerOfNumbers(params int[] numbers)
        {
            double sum = 0;

            // 3, 4, 8
            // sum = 3 power 1 + 4 power 2 + 8 power 3
            // numbers[0] = 3

            for (int i = 0;  i < numbers.Length; i++)
            {
                double hezka = Math.Pow(numbers[i], i + 1);
                sum = sum + hezka;

                // shorter
                //sum = sum + Math.Pow(numbers[i], i + 1);


                // manual hezka
                /*
                int hezakManual = 1;
                for (int j = 0; j < i + 1; j++)
                {
                    hezakManual = hezakManual * numbers[i];
                }
                */
            }

            return sum;
        }
        private static void PrintMultiply(int a, int b = 3, int c = -1)
        {
            Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
        }

        static void ThreeArrays(int[] a, out int[] b, out int[] c)
        {
            // count how many positive numbers
            int positiveNumbers = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    positiveNumbers++;
                }

                // magnificant trick - this is instead of:
                //   if (a[i] > 0)
                //   {
                //       positiveNumbers++;
                //   }
                // positiveNumbers = positiveNumbers + (a[i] > 0 ? 1 : 0);
            }

            // count how many negative numbers
            int negativeNumbers = a.Length - positiveNumbers;

            b = new int[positiveNumbers]; // this is my positive array
            c = new int[negativeNumbers]; // this is my negative array

            int indexb = 0;
            int indexc = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[indexb] = a[i];
                    indexb++;

                    // shorter is nicer :)
                    // b[indexb++] = a[i]; // this increment the indexb by 1 after putting a[i] into b[indexb]
                }
                else
                {
                    c[indexc] = a[i];
                    indexc++;

                    // shorter is nicer :)
                    // c[indexc++] = a[i]; // this increment the indexc by 1 after putting a[i] into c[indexc]
                }
            }
        }

        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (IsADividedByBNoModule(a, b))
            {
                Console.WriteLine("No module");
            }
            else
            {
                Console.WriteLine("There is some module");
            }

            // trick shorter
            Console.WriteLine(IsADividedByBNoModule(a, b) ? "No module" : "There is some module");

            // 2
            Console.WriteLine($"a = {a} b = {b}");

            Aplus1Bmul2(ref a, ref b);

            Console.WriteLine($"a = {a} b = {b}");

            // 3
            int c, d;
            //Console.WriteLine($"c = {c} d = {d}"); -- not allowed - compilation error!

            InputFromUserTwoNumbers(out c, out d);

            Console.WriteLine($"c = {c} d = {d}");

            // 4
            double sum = PrintPowerOfNumbers(5, 7, 8);
            sum = PrintPowerOfNumbers(5, 7, 8, 10, 20);
            sum = PrintPowerOfNumbers();

            // 5 - 6
            PrintMultiply(3, 5, 7);
            PrintMultiply(3);
            PrintMultiply(3, 4);
            PrintMultiply(3, c: 10);

            // 7
            int[] a1 = { 4, 7, -10, -100, 400 };
            int[] b1;
            int[] c1;

            ThreeArrays(a1, out b1, out c1);
            for (int i = 0; i < b1.Length; i++)
            {
                Console.Write($"{b1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < c1.Length; i++)
            {
                Console.Write($"{c1[i]} ");
            }
            Console.WriteLine();

        }


    }
}
