using System;
namespace oops
{
    
    public abstract class Employess
    {
        
        public abstract void displayData();
    }

   
    public class test : Employess
    {
       
        public override void displayData()
        {
            Console.WriteLine("Abstract class method");
        }
    }
    class abstractClass
    {
        static void Main(string[] args)
        {
           
            new test().displayData();
        }
    }
}
