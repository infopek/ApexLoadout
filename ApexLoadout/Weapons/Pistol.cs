using System;

namespace ApexLoadout.Weapons
{
	class Pistol
	{
		Weapon[] weapons = { new Weapon("REEE"), new Weapon("P2020"), new Weapon("Wingdude") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Pistol()
		{

		}
	}
}
