using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("a=?");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("b=?");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("a+b=" + (a+b));

            //for(int i=1; i<=10; i=i+1)
            //{
            //    Console.WriteLine(i);
            //}

            int k;
            Console.WriteLine("Is Int?");
            string s = Console.ReadLine();
            if(int.TryParse(s,out k))
            {
                Console.WriteLine("is Int");
            }
            else
            {
                Console.WriteLine("not Int");
            }

            Console.ReadKey();
        }
    }
}
