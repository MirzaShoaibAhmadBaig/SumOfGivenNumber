using System;

namespace SumOfGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Number");
            int inputnumer =Int32.Parse(Console.ReadLine());
            int backupvalue = inputnumer;
            int RemainderNumber = 0, Sum = 0;

            while (inputnumer != 0)
            {

                RemainderNumber = inputnumer % 10;
                Sum = Sum + RemainderNumber;
                inputnumer = inputnumer / 10;


            }

            Console.WriteLine("Sum of {0}  is {1}", backupvalue, Sum);

        }
    }
}
