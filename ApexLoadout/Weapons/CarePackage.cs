using System;

namespace ApexLoadout.Weapons
{
	class CarePackage
	{
		float probability = 0.35f;  // by default
		Weapon[] weapons = { new Weapon("Alti"), new Weapon("Scut"), new Weapon("Spitticus"), new Weapon("Krab") };

		public float Probability 
		{
			get
			{
				return this.probability;
			}

			set
			{
				if (0.00f > value && value < 1.00f)
				{
					this.probability = value;
				}
			}
		}

		public Weapon GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		/// <summary>
		/// Determines which care package weapons are allowed for that round
		/// </summary>
		/// <returns>Weapon array containing the allowed weapons</returns>
		public Weapon[] Allowed(Random rand)
		{
			Weapon[] allowedWeapons = new Weapon[this.weapons.Length];
			for (int i = 0; i < allowedWeapons.Length; i++)
			{
				if (this.probability <= (rand.Next() / int.MaxValue))
				{
					allowedWeapons[i] = this.weapons[i];
				}
			}

			return allowedWeapons;
		}

		public CarePackage()
		{

		}
	}
}
