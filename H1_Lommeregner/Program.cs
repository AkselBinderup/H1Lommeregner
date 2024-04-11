using H1_Lommeregner.Funktioner;
using System.Text;

class Program
{
	public static void Main(string[] args)
	{
		Funktioner lommeregner = new Funktioner();
		
		WriteInColor(ConsoleColor.White, "write your calculation: ");
		
		var calculationSymbols = Console.ReadLine().ToCharArray();
		
		string calculation = "";
		char[] operators = { '*', '+', '-', '/' };

		for (int i = 0; i < calculationSymbols.Length; i++)
		{
			if (operators.Contains(calculationSymbols[i]) || int.TryParse(calculationSymbols[i].ToString(), out int _))
			{
				calculation += calculationSymbols[i].ToString();
			}
		}

		ChooseHierarchy hierachy = new ChooseHierarchy();

		var result = hierachy.getFunctions(calculation);

		WriteInColor(ConsoleColor.Green, $"the result is {result}");
	}

	static void WriteInColor(ConsoleColor foregroundColor, string text)
	{
		Console.ForegroundColor = foregroundColor;
		Console.Write(text);
		Console.ResetColor();
	}

}

