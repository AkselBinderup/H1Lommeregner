using H1_Lommeregner.Funktioner;

class Program
{
	public void Main(string[] args)
	{
		Funktioner lommeregner = new Funktioner();
		
		// 112+84 = 196
		WriteInColor(ConsoleColor.DarkGray, "write your calculation");
		Console.Write("Write your calculation: ");
		string calculation = Console.ReadLine();

		ChooseHierarchy hierachy = new ChooseHierarchy();

		var result = hierachy.getFunctions(calculation);

		WriteInColor(ConsoleColor.Green, $"the result is {result}");
	}

	void WriteInColor(ConsoleColor color, string text)
	{
		Console.ForegroundColor = color;
		Console.WriteLine(text);
		Console.ResetColor();
	}

}

