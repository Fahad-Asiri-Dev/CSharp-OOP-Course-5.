using Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        MyBaseClass myBaseoObj = new MyBaseClass();
        Console.WriteLine("\nBase Object:\n");
        myBaseoObj.MyMethod();
        myBaseoObj.MyOtherMethod();


        MyDerivedClass myDerivedObj = new MyDerivedClass();
        Console.WriteLine("\nDerived Object:\n");
        myDerivedObj.MyMethod();
        myDerivedObj.MyOtherMethod();

        MyBaseClass myDerivedObjAsBase = myDerivedObj;
        Console.WriteLine("\nAfter Casting:\n");
        myDerivedObjAsBase.MyMethod();
        myDerivedObjAsBase.MyOtherMethod();

        Console.ReadKey();

    }
}

