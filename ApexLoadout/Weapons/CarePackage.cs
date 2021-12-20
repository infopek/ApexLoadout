using System;

namespace ApexLoadout.Weapons
{
	class CarePackage : Weapon 
	{
		float probability = 0.35f;	// by default
		string[] weapons = { "Alti", "Scut", "Spitticus", "Krab" };

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

		public string GetRandomWeapon(Random rand)
		{
			return weapons[rand.Next(0, this.weapons.Length)];
		}

		/// <summary>
		/// Determines which care package weapons are allowed for that round
		/// </summary>
		/// <returns>String array containing the allowed weapons</returns>
		public string[] Allowed(Random rand)
		{
			string[] allowedWeapons = new string[this.weapons.Length];
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
