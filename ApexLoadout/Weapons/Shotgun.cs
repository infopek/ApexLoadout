using System;

namespace ApexLoadout.Weapons
{
	class Shotgun
	{
		Weapon[] weapons = { new Weapon("EVA"), new Weapon("Stiffy"), new Weapon("Bique"), new Weapon("PK") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Shotgun()
		{

		}
	}
}
