using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Lommeregner.Funktioner;

internal class ChooseHierarchy
{
    internal string getFunctions(string func)
    {
        Funktioner calculate = new Funktioner();
        int firstIndex = 0;
        int secondIndex = 0;
        string remaining = "";

        char[] operators = { '*', '+', '-', '/' };

        int operatorIndex = func.IndexOfAny(operators);

        if ( operatorIndex != -1)
        {
            int occurenceOne = func.LastIndexOfAny(operators, operatorIndex - 1);
            if (occurenceOne == null)
                occurenceOne = 0;

            int occurenceTwo = func.IndexOfAny(operators, operatorIndex + 1);

            firstIndex = occurenceOne + 1;
            string num1 = func.Substring(firstIndex, operatorIndex - firstIndex);

            secondIndex = operatorIndex + 1;
            int endIndex = occurenceTwo == -1 ? func.Length : occurenceTwo;
            string num2 = func.Substring(secondIndex, endIndex - secondIndex);

            if(endIndex < func.Length)
            {
                remaining = func.Substring(endIndex);
            }

            Console.WriteLine($"num 1: {num1} Num 2: {num2} End: {remaining}");
        }

        return "";


    }
}
