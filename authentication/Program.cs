using System;

namespace authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code");
            var code = Console.ReadLine();
            if(code=="secret")
            {
                Console.WriteLine("U r authenticated");
            }
            else if(code!="secret")
            {
                Console.WriteLine("oops");
            }
            
        }
    }
}
