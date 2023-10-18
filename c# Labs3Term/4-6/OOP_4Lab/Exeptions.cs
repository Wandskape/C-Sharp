using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_4Lab
{
    public class CustomException1 : Exception
    {
        public CustomException1() { }
        public CustomException1(string message) : base(message) { }
    }

    public class CustomException2 : InvalidOperationException
    {
        public CustomException2() { }
        public CustomException2(string message) : base(message) { }
    }

    public class CustomException3 : ArgumentException
    {
        public CustomException3() { }
        public CustomException3(string message) : base(message) { }
        public CustomException3(string message, string paramName) : base(message, paramName) { }
    }

    public class Calculator
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new CustomException3("Divisor cannot be zero.", nameof(divisor));
            }

            return dividend / divisor;
        }
    }
}
