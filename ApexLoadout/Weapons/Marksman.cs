using System;

namespace ApexLoadout.Weapons
{
	class Marksman : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "TakeTakeTake", "30-30", "Bocsek" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Marksman()
		{

		}
	}
}
