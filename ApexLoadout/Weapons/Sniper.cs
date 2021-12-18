using System;

namespace ApexLoadout.Weapons
{
	class Sniper : Weapon
	{
		static string[] weapons = { "Sentinel", "Charge Rifle", "Longbow" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public Sniper()
		{

		}
	}
}
