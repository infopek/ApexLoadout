using System;

namespace ApexLoadout.Weapons
{
	class LightMachineGun : Weapon
	{
		static string[] weapons = { "Devo", "W-Star", "Page" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public LightMachineGun()
		{

		}
	}
}
