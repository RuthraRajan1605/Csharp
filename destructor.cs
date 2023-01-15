using System;
namespace oops
{
    class customer
    {
        public int x, y;
       
        customer()
        {
            Console.WriteLine("Fields inititalized");
            x = 10;
        }
       
        public void getData()
        {
            y = x * x;
            Console.WriteLine(y);
        }
      
        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
            y = 0;
        }
       
        ~customer()
        {
            Dispose();
        }
        
        static void Main(string[] args)
        {
           
            customer obj = new customer();

            obj.getData();

        }
    }
}
