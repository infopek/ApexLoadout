using System;

namespace ApexLoadout.Weapons
{
	class Shotgun : Weapon
	{
		string[] weapons = { "EVA", "Stiffy", "Bique", "PK" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Shotgun()
		{

		}
	}
}
