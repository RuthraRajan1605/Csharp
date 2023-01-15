using System;
namespace oops
{
  
    public class Father
    {

       
        public Father()
        {
            Console.WriteLine("Father class constructor");
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

   
    public class Child : Father
    {
        public Child()
            : base()
        {
            Console.WriteLine("child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    class Inheritance
    {
        
        static void Main(string[] args)
        {
          
            Child cObj = new Child();
            cObj.FatherMethod();
            cObj.ChildMethod();
            Console.ReadKey();
        }
    }
}
