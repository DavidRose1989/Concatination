using System;

namespace Concatination
{

    class Program
    {
    static void Main(string[] args) 
        {
            string myname = "David";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();


        
        }
    }
}