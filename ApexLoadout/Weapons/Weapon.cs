using System;

namespace ApexLoadout.Weapons
{
	/// <summary>
	/// Enum for representing certain weapon categories
	/// </summary>
	enum Category
	{
		AssaultRifle = 1,
		SubmachineGun = 2,
		LightMachineGun = 3,
		Marksman = 4,
		Sniper = 5,
		Shotgun = 6,
		Pistol = 7
	}

	/// <summary>
	/// Class for a generic non-melee weapon in Apex Legends
	/// </summary>
	class Weapon
	{
		string name;
		Category category;
		
		public string Name { get => name; set => name = value; }
		public Category Category { get => category; set => category = value; }

		public Weapon(string name, int category)
		{
			this.name = name;
			this.category = (Category)category;
		}
	}
}
