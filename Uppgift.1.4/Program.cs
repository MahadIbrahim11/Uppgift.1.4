using System;
namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 16)
            {
                Console.WriteLine("du får inte vara med");
            }
             else if (ålder >19)
            {
                Console.WriteLine("du får inte vara med tävlingen");
            }
            else
            {
                Console.WriteLine("du får inte vara med");  
            }

        }
    }
}
