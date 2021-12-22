using System;
using ApexLoadout.Weapons;
using System.IO;
using System.Collections.Generic;

namespace ApexLoadout
{
	class Program
	{
		static Random rand = new();

		static Weapon GetRandomWeapon(Weapon[,] weapons)
		{
			int category = rand.Next(1, weapons.GetLength(0));
			int index = rand.Next(0, weapons.GetLength(1));

			while (weapons[category, index] == null)
			{
				index = rand.Next(0, weapons.GetLength(1));
			}

			return weapons[category, index];
		}

		static void Main(string[] args)
		{
			Weapon[,] weapons =
			{
				{ new Weapon("Alti", 0), new Weapon("Spitticus", 0), new Weapon("Scut", 0), new Weapon("Krab", 0) },
				{ new Weapon("HAVOK", 1), new Weapon("Flatlin", 1), new Weapon("Homlok", 1), new Weapon("R-301", 1) },
				{ new Weapon("Prowla", 2), new Weapon("R-9", 2), new Weapon("Vilt", 2), new Weapon("Car", 2) },
				{ new Weapon("Devo", 3), new Weapon("W-Star", 3), new Weapon("Page", 3), null },
				{ new Weapon("TakeTakeTake", 4), new Weapon("Peti", 4), new Weapon("Bocsek", 4), null },
				{ new Weapon("ChargeRifla", 5), new Weapon("Longboo", 5), new Weapon("Senti", 5), null },
				{ new Weapon("EVA", 6), new Weapon("Stiffy", 6), new Weapon("Bique", 6), new Weapon("PK", 6) },
				{ new Weapon("REE", 7), new Weapon("P20", 7), new Weapon("Wingdud", 7), null }
			};

			int numRounds = 100;
			List<string> rounds = new();

			for (int i = 1; i < numRounds + 1; i++)
			{
				Weapon slotOne = GetRandomWeapon(weapons);
				Weapon slotTwo = GetRandomWeapon(weapons);

				// Weapons should be of different category!
				while (slotTwo.Category == slotOne.Category)
				{
					slotTwo = GetRandomWeapon(weapons);
				}

				string allowedCP = "";
				for (int j = 0; j < weapons.GetLength(1); j++)
				{
					if (weapons[0, j].Probability < ((float)rand.Next() / int.MaxValue))
					{
						allowedCP += $" {weapons[0, j].Name},";
					}
				}

				rounds.Add($"{i}. ROUND");
				rounds.Add($"Weapons: {slotOne.Name}, {slotTwo.Name}");
				rounds.Add($"Care Package:{allowedCP}");
				rounds.Add("\n");
			}

			File.WriteAllLines("apex_loadout.txt", rounds);
		}
	}
}
