using Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Doctor doctor = new Doctor();
        doctor.Name = "Fahad";
        doctor.Age = 30;
        doctor.EmployeeId = 123;
        doctor.Salary = 20000;
        doctor.Speciality = "Cardiology";
        doctor.Introduce();
        doctor.Work();
        doctor.Heal();

        Console.ReadKey();

    }
}

