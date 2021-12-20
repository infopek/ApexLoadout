using System;

namespace ApexLoadout.Weapons
{
	class Marksman : Weapon
	{
		string[] weapons = { "TakeTakeTake", "30-30", "Bocsek" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Marksman()
		{

		}
	}
}
