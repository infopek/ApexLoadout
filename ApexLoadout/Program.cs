using System;
using ApexLoadout.Weapons;

namespace ApexLoadout
{
	class Program
	{
		static Random rand = new();

		static void Main(string[] args)
		{
			// Next 10 rounds
			for (int i = 0; i < 10; i++)
			{
				int firstType = rand.Next(0, 7);
				int secondType = rand.Next(0, 7);

				while (secondType == firstType)
				{
					secondType = rand.Next(0, 7);
				}


				CarePackage care = new();

				string[] carePacWeps = care.Allowed(rand);

				Console.WriteLine($"{i}. round: {}");
			}
		}
	}
}
