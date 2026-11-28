namespace Inheritance
{
    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi, I'm the print method from the base class A");

        }
    }

    public class clsB : clsA
    {
        public override void Print()
        {
            Console.WriteLine("Hi, I'm the print method from the derived class B");
            base.Print();
        }

    }
    internal class Method_Overriding
    {

    }
}
