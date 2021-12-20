using System;

namespace ApexLoadout.Weapons
{
	class AssaultRifle : Weapon
	{
		string[] weapons = { "Havok", "Flatlin", "Homlok", "Karbajn" };

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public AssaultRifle()
		{

		}
	}
}
