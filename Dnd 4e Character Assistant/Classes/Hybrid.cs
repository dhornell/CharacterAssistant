using System;
using Dnd_4e_Character_Assistant.Persistance;
using Dnd_4e_Character_Assistant.Classes.Hybrids;

namespace Dnd_4e_Character_Assistant.Classes
{
	public class Hybrid : CharacterClass
	{
		public static Hybrid Load(ref IPersistance persistance){
		
			string classAName = persistance.Get("ClassA");
			string classBName = persistance.Get("ClassB");

			string classABonusName = persistance.Get("ClassABonus");
			string classBBonusName = persistance.Get("ClassBBonus");


			HybridClass a = HybridClass.FromClassName(string.Format("Hybrid{0}",classAName),classABonusName);
			HybridClass b = HybridClass.FromClassName(string.Format("Hybrid{0}",classBName),classBBonusName);

			return new Hybrid(a,b);
		}




		public Hybrid (HybridClass classA, HybridClass classB)
		{
			FortitudeBonus = (int)Math.Floor (classA.FortitudeBonus + classB.FortitudeBonus);
			ReflexBonus = (int)Math.Floor (classA.ReflexBonus + classB.ReflexBonus);
			WillBonus = (int)Math.Floor (classA.WillBonus + classB.WillBonus);
			ArmorClassBonus = (int)Math.Floor (classA.ArmorClassBonus + classB.ArmorClassBonus);

			HpAtFirstLevel = (int)Math.Floor (classA.HpAtFirstLevel + classB.HpAtFirstLevel);
			HpPerLevel = (int)Math.Floor (classA.HpPerLevel + classB.HpPerLevel);
			BaseSurgesPerDay = (int)Math.Floor (classA.BaseSurgesPerDay + classB.BaseSurgesPerDay);
		}
	}
}

