using System;

namespace ApexLoadout.Weapons
{
	class CarePackage : Weapon 
	{
		static Random rand = new Random();
		string[] weapons = { "Alti", "Scut", "Spitticus", "Krab" };

		public string GetRandomWeapon()
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		public CarePackage()
		{

		}
	}
}
