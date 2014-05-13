using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dnd_4e_Character_Assistant.Persistance;

namespace Dnd_4e_Character_Assistant
{
    /// <summary>
    /// This utility should eventaully contain all classes/races and powers
    /// 
    /// Starting off it will only handle Monk/Fighter hybrid and or Cleric for humans
    /// 
    /// 
    /// Main features will be dynamic macro creation for abilities. This will allow status triggers to be added such as cleric abilities that give +1d6 dmg until end of encounter.
    /// Starting off the macro format needs only be Roll20 format.
    /// 
    /// Character info is saved to a file or some format(Phase1: flat file)
    /// Powers the character has should be listed easily. Eventaully include a lookup of all powers from the handbooks
    /// 
    /// Phase i: Display defenses
    /// 
    /// 
    /// 
    /// </summary>



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


		private string DropBoxLocation = MonoSupport.IsMono?@"/home/dave/Dropbox/CharacterAssistant/":@"C:\Users\Dave\Dropbox\CharacterAssistant\";

		static void DisplayCharacter (ref Character c)
		{
			CharacterSheet sheet = new CharacterSheet (ref c);
			MessageBox.Show (string.Format ("Race:{0}\r\nClass:{1}", c.Race.RaceName, c.Class.ClassName));
			MessageBox.Show (string.Format ("Defenses:\r\n\tAC:{0}\r\n\tFort:{1}\r\n\tRef:{2}\r\n\tWill:{3}", sheet.Defenses.ArmorClass.Value, sheet.Defenses.Fortitude.Value, sheet.Defenses.Reflex.Value, sheet.Defenses.Wisdom.Value));
			MessageBox.Show (string.Format ("HP:{0}/{1}\r\nSurge:{2}\r\nSurges Per Day:{3}", c.Health.CurrentHP, c.Health.MaxHP, c.Health.Surge, c.Health.SurgesPerDay));
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            //ICharacterPersistance persist = new CharacterFile(DropBoxLocation+"myCleric.txt");
            //Character c = new Character(persist);
			//DisplayCharacter (ref c);


			ICharacterPersistance persist2 = new CharacterFile(DropBoxLocation+"Zaine.txt");
            Character c2 = new Character(persist2);
			DisplayCharacter (ref c2);


        }
    }
}
