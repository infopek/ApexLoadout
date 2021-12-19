using System;

namespace ApexLoadout.Weapons
{
	class SubmachineGun : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "Prowler", "R-9", "Vilt", "Car" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public SubmachineGun()
		{

		}
	}
}
