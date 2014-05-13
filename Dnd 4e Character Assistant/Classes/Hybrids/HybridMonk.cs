using System;

namespace Dnd_4e_Character_Assistant.Classes.Hybrids
{
	public class HybridMonk : HybridClass
	{
		public HybridMonk (SaveBonusType saveType)
		{
			switch (saveType) {
			case SaveBonusType.Will: WillBonus = 1;break;
			case SaveBonusType.Reflex: ReflexBonus = 1;break;
			case SaveBonusType.Fortitude: FortitudeBonus = 1; break;
			}

			HpAtFirstLevel=6;
			HpPerLevel=2.5;
			BaseSurgesPerDay=3.5;

		}
	}
}

