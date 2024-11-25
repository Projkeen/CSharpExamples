using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorViaOOP
{
    internal class Calculator
    {
        public double numberOne { get; set; }
        public double numberTwo { get; set; }

        public double Plus()
        {
            return numberOne + numberTwo;
        }

        public double Minus()
        {
            return numberOne - numberTwo;
        }

        public double Pow()
        {
            return numberOne * numberTwo;
        }

        public double  Divide()
        {         
           return numberOne / numberTwo;
        }
    }
}
