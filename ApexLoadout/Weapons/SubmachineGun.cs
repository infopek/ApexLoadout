using System;

namespace ApexLoadout.Weapons
{
	class SubmachineGun
	{
		Weapon[] weapons = { new Weapon("Prowler"), new Weapon("R-9"), new Weapon("Vilt"), new Weapon("Car") };

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public SubmachineGun()
		{

		}
	}
}
