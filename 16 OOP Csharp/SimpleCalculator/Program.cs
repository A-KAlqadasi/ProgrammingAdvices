using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{

    class clsCalculator
    {
        private  float _Result;
        private float _LastNumber;
        private string _LastOperation = string.Empty;

        private bool _IsZero(float number)
        {
            return (number == 0);
        }

        public void Add(float value)
        {
            _LastNumber = value;
            _Result += value;
            _LastOperation = "Adding";
        }
        public void Subtract(float value)
        {
            _LastNumber = value;
            _Result -= value;
            _LastOperation = "Subtracting";

        }

        public void Multiply(float value)
        {
            _LastNumber = value;
            _Result *= value;
            _LastOperation = "Multiplying";

        }

        public bool Divide(float value)
        {
            _LastOperation = "Dividing";
            
            bool succeeded = true;
            _LastNumber = value;

            if (_IsZero(value))
            {
                _Result /= 1;
                succeeded = false;
                return succeeded;
            }
            else
            {
                _Result /= value;
            }

            return succeeded;
            

        }

        public void Clear()
        {
            _Result = 0;
            _LastNumber = 0;
            _LastOperation = "Clear";
        }

        public float GetFinalResult()
        {
            return _Result;
        }

        public void PrintResult()
        {
            Console.WriteLine($"Result after {_LastOperation} {_LastNumber} is : {_Result}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();

            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();



            Console.ReadKey();

        }
    }
}
