﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal class PerformFunc
    {
        public static double Perform(double left, double right, char op)
        {
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/': return left / right;
                case '%': return left % right;
                case '^': return Math.Pow(left, right);
                default: throw new ArgumentException("Неизвестный оператор: " + op);
            }
        }
    }
}
