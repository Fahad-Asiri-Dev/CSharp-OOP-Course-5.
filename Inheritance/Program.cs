using Inheritance;

namespace Inheritance
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }

    public class Employee : Person
    {
        public string Company { get; set; }
        public decimal Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"I work at {Company} and earn {Salary:C} per year.");
        }
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        //Upcasting
        Employee employee1 = new Employee { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 50000 };
        Person persone1 = employee1;
        employee1.Greet();

        //Downcasting

        Person person2 = new Employee { Name = "Jane", Age = 25, Company = "XYZ Corp. ", Salary = 30300 };
        Employee employee2 = (Employee)person2;
        employee2.Work();

    }
}

