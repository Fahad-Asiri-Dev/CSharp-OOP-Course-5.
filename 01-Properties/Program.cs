namespace ConsoleApp2
{
    class clsEmployee
    {
        private int _ID;
        private string _Name = string.Empty;

        public int ID
        {
            get
            {
                return _ID = 7;
            }



        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value.ToUpper(); }
        }


    }

    internal class Program
    {



        static void Main(string[] args)
        {
            clsEmployee Employee1 = new clsEmployee();


            Employee1.Name = "Fahad asiri";


            Console.WriteLine(Employee1.ID);
            Console.WriteLine(Employee1.Name);

        }
    }
}
