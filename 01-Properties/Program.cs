namespace ConsoleApp2
{

    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }

    }


    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);

            Settings.ProjectPath = @"PC\C\Users\";

            Console.WriteLine(Settings.ProjectPath);

        }
    }
}
