using Inheritance;

namespace Inheritance
{
    public class clsPerson
    {
        public clsPerson(int Id, string FirstName, string LastName, string Title)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Title { get; private set; }

        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }

    }
    public class clsEmployee : clsPerson
    {
        public clsEmployee(int Id, string FirstName, string LastName, string Title
            , float Salary, string DepartmentName) : base(Id, FirstName, LastName, Title)
        {
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }

        public float Salary { get; private set; }
        public string DepartmentName { get; private set; }

        public void IncreaseSalaryBy(float Amount)
        {
            Salary += Amount;
        }

    }


}
internal class Program
{
    static void Main(string[] args)
    {
        clsEmployee Employee1 = new clsEmployee(10, "Fahad", "Asiri", "Mr", 9000, "IT");
        Console.WriteLine("Accessing Object 1 (Employee1):\n");
        Console.WriteLine("ID :={0}", Employee1.Id);
        Console.WriteLine("Title :={0}", Employee1.Title);
        Console.WriteLine("Full Name :={0}", Employee1.FullName);
        Console.WriteLine("Department Name :={0}", Employee1.DepartmentName);
        Console.WriteLine("Salary :={0}", Employee1.Salary);

        Employee1.IncreaseSalaryBy(100);

        Console.WriteLine("Salary after increase =:{0}", Employee1.Salary);


    }
}

