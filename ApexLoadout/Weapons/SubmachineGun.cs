using System;

namespace ApexLoadout.Weapons
{
	class SubmachineGun : Weapon
	{
		static string[] weapons = { "Prowler", "R-9", "Vilt", "Car" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public SubmachineGun()
		{

		}
	}
}
