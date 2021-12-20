using System;

namespace ApexLoadout.Weapons
{
	class Marksman
	{
		Weapon[] weapons = { new Weapon("TakeTakeTake"), new Weapon("30-30"), new Weapon("Bocsek") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Marksman()
		{

		}
	}
}
