using System;

namespace ApexLoadout.Weapons
{
	class AssaultRifle
	{
		Weapon[] weapons = { new Weapon("Havok"), new Weapon("Flatlin"), new Weapon("Homlok"), new Weapon("Karbajn") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public AssaultRifle()
		{

		}
	}
}
