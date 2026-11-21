namespace ConsoleApp2
{
    class Auto_clsEmployee
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

    }

    internal class Program
    {



        static void Main(string[] args)
        {
            Auto_clsEmployee Employee2 = new Auto_clsEmployee();



            Employee2.Name = "Mohammed ali";
            Employee2.ID = 77289177;



            Console.WriteLine(Employee2.ID);
            Console.WriteLine(Employee2.Name);

        }
    }
}
