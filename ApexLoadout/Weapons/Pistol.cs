using System;

namespace ApexLoadout.Weapons
{
	class Pistol : Weapon
	{
		string[] weapons = { "REEE", "P2020", "Wingdude" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Pistol()
		{

		}
	}
}
