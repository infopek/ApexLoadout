using System;

namespace ApexLoadout.Weapons
{
	class Shotgun
	{
		static string[] weapons = { "EVA", "Stiffy", "Bique", "PK" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public Shotgun()
		{

		}
	}
}
