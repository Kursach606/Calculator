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
            try
            {
                // Строчка конфликтаа
                char[] operators = new char[] { '+', '-', '*', '/', '%', '^' };
                int opIndex = CharacterStorageFunc.CharacterStorage(input);

                if (opIndex == -1)
                {
                    return TransformationFunc.ParseOperand(input);
                }

                string leftString = input.Substring(0, opIndex);
                string rightString = input.Substring(opIndex + 1);

                double left = Count(leftString);
                double right = Count(rightString);

                char op = input[opIndex];

                return PerformFunc.Perform(left, right, op);
            }
            catch (Exception)
            {
                throw new ArgumentException("Непредвиденная ошибка!");
            }
        }    
    }
}
