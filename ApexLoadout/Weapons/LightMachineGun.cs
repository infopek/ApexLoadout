using System;

namespace ApexLoadout.Weapons
{
	class LightMachineGun : Weapon
	{
		string[] weapons = { "Devo", "W-Star", "Page" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public LightMachineGun()
		{

		}
	}
}
