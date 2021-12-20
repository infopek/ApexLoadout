using System;
using ApexLoadout.Weapons;

namespace ApexLoadout
{
	class Program
	{
		static Random rand = new();

		static Weapon NumToType(int n)
		{
			Weapon w;

			switch (n)
			{
				case 0:
					w = new Pistol();
					break;
				case 1:
					w = new Shotgun();
					break;
				case 2:
					w = new Sniper();
					break;
				case 3:
					w = new Marksman();
					break;
				case 4:
					w = new LightMachineGun();
					break;
				case 5:
					w = new SubmachineGun();
					break;
				case 6:
					w = new AssaultRifle();
					break;
				default:
					w = new();
					break;
			}

			return w;
		}

		static void Main(string[] args)
		{
			int firstType = rand.Next(0, 7);
			int secondType = rand.Next(0, 7);

			while (secondType == firstType)
			{
				secondType = rand.Next(0, 7);
			}

			Weapon slotOne = NumToType(firstType);
			Weapon slotTwo = NumToType(secondType);
			CarePackage care = new();

			string[] carePacWeps = care.Allowed(rand);
		}
	}
}
