using System;

namespace ApexLoadout.Weapons
{
	class AssaultRifle : Weapon
	{
		static Random rand = new Random();
		string[] weapons = { "Havok", "Flatlin", "Homlok", "Karbajn" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public AssaultRifle()
		{

		}
	}
}
