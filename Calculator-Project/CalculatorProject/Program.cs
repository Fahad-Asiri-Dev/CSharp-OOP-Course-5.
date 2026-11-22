namespace CalculatorProject
{

    class clsCalculator
    {

        private float _Result = 0;
        private float _LastNumber = 0;
        private string _LastOperation = "Clear";

        private bool _IsZero(float Number)
        {
            return (Number == 0);
        }


        public void Clear()
        {
            _Result = 0;
            _LastNumber = 0;
            _LastOperation = "Clear";
        }

        public void Add(float Number)
        {
            _LastNumber = Number;
            _LastOperation = " Adding ";
            _Result += Number;
        }

        public void Subtracting(float Number)
        {
            _LastNumber = Number;
            _LastOperation = " Subtracting ";
            _Result -= Number;
        }

        public bool Dividing(float Number)
        {
            bool Succeeded = true;
            _LastOperation = " Dividing ";

            if (_IsZero(Number))
            {
                _LastNumber = Number;
                _Result /= 1;
                Succeeded = false;
            }
            else
            {
                _LastNumber = Number;
                _Result /= Number;
            }
            return Succeeded;

        }
        public void Multiplying(float Number)
        {
            _LastNumber = Number;
            _LastOperation = " Multiplying ";
            _Result *= Number;
        }

        public float GetFinalResults()
        {
            return _Result;
        }
        public void PrintResult()
        {
            Console.WriteLine("Result after{0} {1} is: {2}", _LastOperation, _LastNumber, _Result);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator c = new clsCalculator();

            c.Add(10);
            c.PrintResult();

            c.Add(100);
            c.PrintResult();

            c.Subtracting(20);
            c.PrintResult();

            c.Dividing(0);
            c.PrintResult();

            c.Dividing(2);
            c.PrintResult();

            c.Multiplying(3);
            c.PrintResult();

            c.Clear();
            c.PrintResult();
        }
    }
}
