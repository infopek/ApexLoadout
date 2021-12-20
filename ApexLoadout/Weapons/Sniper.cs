using System;

namespace ApexLoadout.Weapons
{
	class Sniper
	{
		Weapon[] weapons = { new Weapon("Sentinel"), new Weapon("Charge Rifle"), new Weapon("Longbow") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Sniper()
		{

		}
	}
}
