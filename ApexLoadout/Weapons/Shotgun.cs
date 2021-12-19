using System;

namespace ApexLoadout.Weapons
{
	class Shotgun : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "EVA", "Stiffy", "Bique", "PK" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Shotgun()
		{

		}
	}
}
