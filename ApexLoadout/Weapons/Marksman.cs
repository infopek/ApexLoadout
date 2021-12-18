using System;

namespace ApexLoadout.Weapons
{
	class Marksman : Weapon
	{
		static string[] weapons = { "TakeTakeTake", "30-30", "Bocsek" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public Marksman()
		{

		}
	}
}
