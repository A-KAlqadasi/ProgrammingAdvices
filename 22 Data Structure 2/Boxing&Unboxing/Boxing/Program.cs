internal class Program
{
	static void Main(string[] args)
	{
		int value = 10;
		object objValue = value;  // Boxing

		int unboxedValue = (int)objValue; // un boxing -> must be for the same type of boxing

		Console.WriteLine("Original value "+ value);
		Console.WriteLine("Boxed value " + objValue);
		Console.WriteLine("Unboxed value " + unboxedValue);


		Console.ReadKey();
	}

	
}

