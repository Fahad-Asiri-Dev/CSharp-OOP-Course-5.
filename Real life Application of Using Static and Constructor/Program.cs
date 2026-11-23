namespace Real_life_Application_of_Using_Static_and_Constructor
{


    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public clsPerson(int Id, string name, int age)
        {
            this.Id = Id;
            this.Name = name;
            this.Age = age;
        }

        public static clsPerson Find(int Id)
        {
            if (Id == 10)
            {
                return new clsPerson(10, "Fahad", 40);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string UserName, string Password)
        {
            if (UserName == "Fahad" && Password == "A123")
                return new clsPerson(10, "Fahad", 40);
            else
                return null;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Person by ID");

            clsPerson Person1 = clsPerson.Find(10);

            if (Person1 != null)
            {
                Console.WriteLine("ID:={0}", Person1.Id);
                Console.WriteLine("Name:={0}", Person1.Name);
                Console.WriteLine("Age:={0}", Person1.Age);
            }
            else
            {
                Console.WriteLine("Couldn't find the person by id");
            }

            Console.WriteLine("\n\nFinding Person2 by UserName and Password");

            clsPerson Person2 = clsPerson.Find("Fahad", "A123");

            if (Person2 != null)
            {
                Console.WriteLine("ID:={0}", Person1.Id);
                Console.WriteLine("Name:={0}", Person1.Name);
                Console.WriteLine("Age:={0}", Person1.Age);
            }

            else
            {
                Console.WriteLine("Couldn't find the person by UserName and Password");
            }
        }
    }
}
