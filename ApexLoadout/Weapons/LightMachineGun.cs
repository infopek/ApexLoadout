using System;

namespace ApexLoadout.Weapons
{
	class LightMachineGun
	{
		Weapon[] weapons = { new Weapon("Devo"), new Weapon("W-Star"), new Weapon("Page") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public LightMachineGun()
		{

		}
	}
}
