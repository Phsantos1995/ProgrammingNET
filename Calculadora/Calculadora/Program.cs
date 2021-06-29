using System;

namespace Calculadora
{

    



    
    
    
    class Program
    





    {


        public int soma(int x, int y)
        {
            return x + y;
        }


        public int sub(int x, int y)
        {
            return x -y;
        }

        public int mult(int x, int y)
        {
            return x * y;

        }


        public int div(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 4;
            Program p1 = new Program();

            


            Console.WriteLine("Hello World");

            Console.WriteLine("Soma:" + p1.soma(n1, n2));
            Console.WriteLine("Sub:" + p1.sub(n1, n2));
            Console.WriteLine("Mult:" + p1.mult(n1, n2));
            Console.WriteLine("Div:" + p1.div(n1, n2));







        }
    }
}
