using System;

namespace Dnd_4e_Character_Assistant.Classes.Hybrids
{
	public class HybridClass
	{
		public static HybridClass Monk_Will = new HybridMonk(SaveBonusType.Will);
		public static HybridClass Monk_Fort = new HybridMonk(SaveBonusType.Fortitude);
		public static HybridClass Monk_Ref = new HybridMonk(SaveBonusType.Reflex);
		public static HybridClass Fighter = new HybridFighter(SaveBonusType.None);

		protected HybridClass ()
		{
		}
		public HybridClass (SaveBonusType saveBonusType)
		{
		}

		public static HybridClass FromClassName(string className,string bonusName) {
			SaveBonusType bonusType = (SaveBonusType)Enum.Parse(typeof(SaveBonusType),bonusName);

			Type classType = Type.GetType(string.Format("Dnd_4e_Character_Assistant.Classes.Hybrids.{0}",className));

			return (HybridClass)Activator.CreateInstance(classType,bonusType);
        }
        public string ClassName { get {
            return this.GetType().Name;
        } }

		#region DefenseBonus
        public double FortitudeBonus {get; protected set;}
        public double ReflexBonus { get; protected set; }
        public double WillBonus { get; protected set; }
        public double ArmorClassBonus { get; protected set; }
        #endregion

        #region Health
        public double HpAtFirstLevel { get; protected set; }
        public double HpPerLevel { get; protected set; }
        public double BaseSurgesPerDay { get; protected set; }
        #endregion

	}
}

