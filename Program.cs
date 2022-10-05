using System;
namespace assignment5ism4300
{
    internal class Program
    {

        static int[] Method1(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int Method2(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15");
                int input = int.Parse(Console.ReadLine());
                int[] MyArray = Method1(input);
                if (input > 4 && input < 16)
                {
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.Write("The elements in the random array are: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + Method2(MyArray));
                }
                else
                {
                    Console.WriteLine("Please enter a integer value in the range and try again");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }

        }
    }
}