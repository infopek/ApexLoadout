using System;

namespace ApexLoadout.Weapons
{
	class Pistol : Weapon
	{
		static string[] weapons = { "RE-45 Auto", "P2020", "Wingman" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public Pistol()
		{

		}
	}
}
