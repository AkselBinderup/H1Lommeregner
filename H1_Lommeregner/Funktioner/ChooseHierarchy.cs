using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Lommeregner.Funktioner;

internal class ChooseHierarchy
{
    internal string getFunctions(string func)
    {
        Funktioner calculate = new Funktioner();

        char[] operators = { '*', '/' };

        while (true)
        {
            int operatorIndex = func.IndexOfAny(operators);
            if (!int.TryParse(func, out var InvalidOperator))
            {
                if (operatorIndex != -1)
                {
                    int occurenceOne = func.LastIndexOfAny(new char[] { '*', '/', '+', '-' }, operatorIndex - 1);
                    if (occurenceOne == null)
                        occurenceOne = 0;

                    int occurenceTwo = func.IndexOfAny(new char[] { '*', '/', '+', '-'}, operatorIndex + 1);

                    int firstIndex = occurenceOne + 1;
                    string num1 = func.Substring(firstIndex, operatorIndex - firstIndex);

                    int secondIndex = operatorIndex + 1;
                    int endIndex = occurenceTwo == -1 ? func.Length : occurenceTwo;
                    string num2 = func.Substring(secondIndex, endIndex - secondIndex);

                    char splitOperator = func[operatorIndex];
                    var calculation = num1 + splitOperator.ToString() + num2;
                    string num;
                    num = calculate.Calculate(int.Parse(num1), int.Parse(num2), splitOperator);
                    if (!operators.Contains(splitOperator))
                        num = calculation;
                    func = func.Replace(calculation, num);
                }
                else
                {
                    operators[0] = ('+');
                    operators[1] = ('-');
                }
            }
            else
            {
                return func;
            }
        }
    }
}
