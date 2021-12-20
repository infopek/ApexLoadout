using System;

namespace ApexLoadout.Weapons
{
	class Sniper : Weapon
	{
		string[] weapons = { "Sentinel", "Charge Rifle", "Longbow" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Sniper()
		{

		}
	}
}
