using System;

namespace ElementofMaxValue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int sumOfAll = 0;
			int biggest = int.MinValue;

			for (int i = 0; i < n; i++)
			{

				int inputNumber = int.Parse (Console.ReadLine ());
				sumOfAll += inputNumber;
				if (inputNumber > biggest) {
					biggest = inputNumber;
				}
			}
			int sumOfRest = sumOfAll - biggest;
			if (sumOfRest == biggest) 
			{ 
				Console.WriteLine ("Yes\nSum ={0}", biggest);
			}
			else
			{
				Console.WriteLine("No\nDiff = {0}", Math.Abs(biggest-sumOfRest));
			}
		}
	}
}