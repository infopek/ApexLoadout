using System;

namespace ApexLoadout.Weapons
{
	/// <summary>
	/// Enum for representing certain weapon categories
	/// </summary>
	enum Category
	{
		CarePackage = 0,
		AssaultRifle = 1,
		SubmachineGun = 2,
		LightMachineGun = 3,
		Marksman = 4,
		Sniper = 5,
		Shotgun = 6,
		Pistol = 7,
	}

	/// <summary>
	/// Class for a generic non-melee weapon in Apex Legends
	/// </summary>
	class Weapon
	{
		string name;
		Category category;
		float probability;	// only for carepac weapons
		
		public string Name { get => name; set => name = value; }
		public Category Category { get => category; set => category = value; }
		public float Probability	// only for carepac weapons
		{
			get
			{
				if (this.category == 0)
				{
					return this.probability;
				}

				return 1.00f;
			}

			set
			{
				if (this.category == 0 && value >= 0.00f && value <= 1.00f)
				{
					this.probability = value;
				}
			}
		}
	
		// Constructor
		public Weapon(string name, int category)
		{
			this.name = name;
			this.category = (Category)category;

			// Default value
			if (category == 0)
			{
				this.probability = 0.50f;
			}
		}
	}
}
