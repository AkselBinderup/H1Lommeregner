using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Lommeregner.Funktioner;

internal class Funktioner
{
    public int Calculate(int num1, int num2, char operationMethod)
    {
        switch (operationMethod)
        {
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
        }
        return 0;
    }


}
