using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        //Equation
        public Equation()
        {
            Left = 0;
            Right = 0;
        }
        // Equation (double left, double right)
        public Equation(double left, double right)
        {
            left = Left;
            right = Right;
        }
        // Addition
        public double Add()
        {
            double add;
            add = Left + Right;
            return add;
        }
        // Subtraction- Double
        public double Subtract()
        {
            double subtract;
            subtract = Left - Right;
            return subtract;
        }
        // Multiplication- Double
        public double Multiply()
        {
            double multiply;
            multiply = Left * Right;
            return multiply;
        }
        // Applied Power to Left- Double
        public double LeftToThePower(int power)
        {
            power = (int)Right;
            double leftPower = Math.Pow(Left, power);
            return leftPower;
        }
        // Applied Power to Right- Double
        public double RightToThePower(int power)
        {
            power = (int)Left;
            double rightPower = Math.Pow(Right, power);
            return rightPower;
        }

    }
}
