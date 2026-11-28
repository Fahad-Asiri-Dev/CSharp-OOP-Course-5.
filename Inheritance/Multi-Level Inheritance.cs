namespace Inheritance
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and i'm {Age} years old>");

        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");

        }
    }

    public class Doctor : Employee
    {
        public string Speciality { get; set; }

        public void Heal()
        {
            Console.WriteLine($"Doctor {Name} with ID {EmployeeId}, salary {Salary:C}, and specialty {Speciality} is healing a patient.");

        }
    }


}
