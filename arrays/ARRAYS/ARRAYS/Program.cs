using System;

namespace ARRAYS
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            double number;
            double sum = 0;
            Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
            number = Convert.ToDouble(Console.ReadLine());
           

            for (int i = 7; i <= number; i+=2)
            {
                sum += i;


            }
            Console.WriteLine($"THE SUM OF ODD NUMBERS BETWEEN 7 to {number} IS {sum}");
            Console.ReadLine();
            */

            int number;
            int sum=0;
            Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 & number <= 15)
            {
                Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
                number = Convert.ToInt32(Console.ReadLine());

                for (int i = 7; i <= number; i += 2)
                {
                    sum += i;
                };
            }
            else {
                Console.Write("PLEASE ENTER ONLY ODD NUMBERS BETWEEN 7 AND 15: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"THE SUM OF ODD NUMBERS BETWEEN 7 to  IS:",sum);
            Console.ReadLine();
        }
    }
}
