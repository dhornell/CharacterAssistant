using System;
using Dnd_4e_Character_Assistant.Persistance;

namespace Dnd_4e_Character_Assistant.Feats
{
	/*Probably best if feats are loaded from a file system or something*/
	/*Flat file database?*/
	/*Somehow use the persistance model? Nested somehow?*/
	/*FEAT_NAME=REF=REF_BNS|FORT=FORT_BNS|WILL=WILL_BNS|AC=AC_BNS*/
	/*Which can then be 'persistance'd again to:
	/*
		REF=REF_BNS
		FORT=FORT_BNS
		WILL=WILL_BNS
		AC=AC_BNS

	 */
	public class Feat
	{
		private Feat ()
		{
		}
	
		public static Feat Load(FeatFile file, string featName){
			Feat ret = new Feat();
			ret.Name = featName;

			FeatFileFeat ff = file.GetFeat(featName);

			ret.FortitudeBonus = GetValueFromString(ff,"FortitudeBonus");
			ret.ReflexBonus = GetValueFromString(ff,"ReflexBonus");
			ret.WillBonus = GetValueFromString(ff,"WillBonus");
			ret.ArmorClassBonus = GetValueFromString(ff,"ArmorClassBonus");

			return ret;
		}

		static int GetValueFromString (FeatFileFeat ff, string key)
		{
			string v = ff.Get (key);
			if (string.IsNullOrEmpty (v)) {
				return 0;
			}
			return int.Parse(v);
		}

		public string Name{ get; protected set; }

		public int FortitudeBonus {get; protected set;}
        public int ReflexBonus { get; protected set; }
        public int WillBonus { get; protected set; }
        public int ArmorClassBonus { get; protected set; }
	}
}

