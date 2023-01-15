using System;
namespace oops
{
    class Encapsulation
    {
       
        int x;

       
        public Encapsulation(int iX)
        {
            this.x = iX;
        }

       
        public void MySquare()
        {
            int Calc = x * x;
            Console.WriteLine(Calc);
        }

        static void Main(string[] args)
        {
           
            customer obj = new customer(20);

            obj. MySquare();

        }

    }
}
