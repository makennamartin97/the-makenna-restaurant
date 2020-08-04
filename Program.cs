using System;
using hungry_ninja.models;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Makenna Restaurant!");
            Customer customer = new Customer();
            Buffet buffet = new Buffet();

            while(!customer.IsFull){
                customer.Eat(buffet.Serve());
            }
            customer.Eat(buffet.Serve());
        }


        
    }
}
