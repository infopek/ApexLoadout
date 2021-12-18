using System;

namespace ApexLoadout.Weapons
{
	/// <summary>
	/// Class for representing an assault rifle type weapon
	/// </summary>
	class AssaultRifle : Weapon
	{
		static string[] weapons = { "HAVOC Rifle", "VK-47 Flatline", "Hemlok Burst AR", "R-301 Carbine" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public AssaultRifle()
		{

		}
	}
}
