using System;

namespace ApexLoadout.Weapons
{
	class Pistol : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "REEE", "P2020", "Wingdude" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public Pistol()
		{

		}
	}
}
