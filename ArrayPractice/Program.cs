using System;

namespace ArrayPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] numbers = new float[10];
			float totalPositive = 0.0f;
			float totalNegative = 0.0f;
			int countPositive = 0;
			int countNegative = 0;

			for (int i = 0; i < 10; i++)
			{
				Console.Write("Number {0}= ", i + 1);
				numbers[i] = Convert.ToSingle(Console.ReadLine());
			}

			for (int i = 0; i < 10; i++)
			{
				//Negative
				if (numbers[i] < 0)
				{
					totalNegative = totalNegative + numbers[i];
					countNegative++;


					//Positive
					if (numbers[i] > 0)
					{
						totalPositive = totalPositive + numbers[i];
						countPositive++;
					}
					Console.WriteLine("Average numbers negatives = {0}", totalNegative /
					countNegative);
					Console.WriteLine("Average numbers positives = {0}", totalPositive /
					countPositive);
				}
			}
		}
	}
}

/*{
        int[] numbers = new int[10];
 
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Numero {0}= ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
 
        for (int i = 0; i < 10; i++)
            if (numbers[i] % 2 == 0)
                Console.Write("{0} ", numbers[i]);
    }*/
