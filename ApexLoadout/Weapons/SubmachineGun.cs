using System;

namespace ApexLoadout.Weapons
{
	class SubmachineGun : Weapon
	{
		string[] weapons = { "Prowler", "R-9", "Vilt", "Car" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public SubmachineGun()
		{

		}
	}
}
