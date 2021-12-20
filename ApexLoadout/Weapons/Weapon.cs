using System;

namespace ApexLoadout.Weapons
{
	/// <summary>
	/// Class for a generic non-melee weapon in Apex Legends
	/// </summary>
	class Weapon
	{
		string name;
		public string Name { get => name; set => name = value; }

		public Weapon(string name)
		{
			this.name = name;
		}
	}
}
