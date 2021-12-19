using System;

namespace ApexLoadout.Weapons
{
	class LightMachineGun : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "Devo", "W-Star", "Page" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public LightMachineGun()
		{

		}
	}
}
