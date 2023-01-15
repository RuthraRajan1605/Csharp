using System;
namespace oops
{
    class funOverload
    {
        public string name;

       
        public void setName(string last)
        {
            name = last;
        }

        public void setName(string first, string last)
        {
            name = first + "" + last;
        }

        public void setName(string first, string middle, string last)
        {
            name = first + "" + middle + "" + last;
        }

       
        static void Main(string[] args)
        {
            funOverload obj = new funOverload();

            obj.setName("barack");
            obj.setName("barack "," obama ");
            obj.setName("barack ","hussian","obama");

        }
    }
}
