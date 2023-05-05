using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal static class CountFunc
    {
        public static double Count(string input)
        {
            //строка конфликта
            char[] operators = new char[] { '+', '-', '*', '/', '%', '^' };
            int opIndex = CharacterStorageFunc.CharacterStorage(input);

            if (opIndex == -1)
            {
                return TransformationFunc.ParseOperand(input);
            }

            string leftString = input.Substring(0, opIndex);
            string rightString = input.Substring(opIndex + 1);

            double left, right;
            if (!double.TryParse(leftString, out left) || !double.TryParse(rightString, out right))
            {
                throw new FormatException("Неверный формат входной строки");
            }

            char op = input[opIndex];

            switch (op)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    if (right == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль");
                    }
                    return left / right;
                case '%':
                    return left % right;
                case '^':
                    return Math.Pow(left, right);
                default:
                    throw new ArgumentException("Неподдерживаемый оператор");
            }
        }
    }
}
