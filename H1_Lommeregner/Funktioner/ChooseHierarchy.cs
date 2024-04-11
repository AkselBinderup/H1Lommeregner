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

        int indexNum1 = func.IndexOf('*');
        indexNum1 = func.IndexOf('*', indexNum1 - 1);
        string result = func.Substring(0, indexNum1);

        int indexNum2 = func.IndexOf('*');
        
        indexNum2 = func.IndexOf('+', indexNum2 + 1);
        string num2 = func.Substring(0, indexNum2);
        


        Console.WriteLine(  result + " " + num2);


        return result;


    }
}
