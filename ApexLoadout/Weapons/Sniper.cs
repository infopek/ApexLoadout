using System;

namespace ApexLoadout.Weapons
{
	class Sniper : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "Sentinel", "Charge Rifle", "Longbow" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Sniper()
		{

		}
	}
}
