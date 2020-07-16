using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how old are you?: ");
            int y = Convert.ToInt32(Console.ReadLine());
             
            if (y >= 13)
            {
                Console.WriteLine("you are old so you can use website");
            }
            else
            {
                Console.WriteLine("you to yung to use webstite so go out side and die");
            }
                
            
        }
    }
}
