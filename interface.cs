using System;
namespace oops
{
    
    public interface xyz
    {
       void methodA();
       void methodB();
    }

  
    class test : xyz
    {
        public void methodA()
        {
            Console.WriteLine("methodA");
        }
        public void methodB()
        {
            Console.WriteLine("methodB");
        }
    }
    class interfaceDemo
    {
        static void Main(string[] args)
        {
            test obj = new test();
            obj.methodA();
            obj.methodB();
        }
    }
}
