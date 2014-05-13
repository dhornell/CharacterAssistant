using System;

namespace Dnd_4e_Character_Assistant.Classes.Hybrids
{
	public class HybridFighter: HybridClass
	{
		public HybridFighter (SaveBonusType saveType) 
		{
			FortitudeBonus = 1;

			HpAtFirstLevel = 7.5;
			HpPerLevel = 3;
			BaseSurgesPerDay = 4.5;
		}
	}
}

