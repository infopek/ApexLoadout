using System;

namespace ApexLoadout.Weapons
{
	/// <summary>
	/// Class for a generic non-melee weapon in Apex Legends
	/// </summary>
	class Weapon
	{
		string name;
		string category;
		
		public string Name { get => name; set => name = value; }
		public string Category { get => category; set => category = value; }

		public Weapon(string name, string category)
		{
			this.name = name;
			this.category = category;
		}
	}
}
