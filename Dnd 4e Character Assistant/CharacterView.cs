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



    public partial class CharacterView : Form
    {
        bool editMode = true;
        IPersistance persist = null;
        FeatFile featFile = null;
        Character _character = null;


        public CharacterView(string characterFile) {
            editMode = false;
            InitializeCharacter(characterFile);

            InitializeComponent();
            
        }

        private void InitializeCharacter(string characterFile)
        {
            persist = new CharacterFile(characterFile);
            featFile = new FeatFile(Settings.WorkingDirectory + "feats.txt");
            _character = new Character(persist, featFile);
        }

        public CharacterView()
        {
            //In this case we want to use the values specified to generate a character file.
            featFile = new FeatFile(Settings.WorkingDirectory + "feats.txt");
            _character = new Character(featFile);
            InitializeComponent();
        }


		private string DropBoxLocation = MonoSupport.IsMono?@"/home/dave/Dropbox/CharacterAssistant/":@"C:\Users\Dave\Dropbox\CharacterAssistant\";

		static void DisplayCharacter (ref Character c)
		{
			CharacterSheet sheet = new CharacterSheet (ref c);
			MessageBox.Show (string.Format ("Race:{0}\r\nClass:{1}", c.Race.RaceName, c.Class.ClassName));
			MessageBox.Show (string.Format ("Defenses:\r\n\tAC:{0}\r\n\tFort:{1}\r\n\tRef:{2}\r\n\tWill:{3}", sheet.Defenses.ArmorClass.Value, sheet.Defenses.Fortitude.Value, sheet.Defenses.Reflex.Value, sheet.Defenses.Will.Value));
			MessageBox.Show (string.Format ("HP:{0}/{1}\r\nSurge:{2}\r\nSurges Per Day:{3}", c.Health.CurrentHP, c.Health.MaxHP, c.Health.Surge, c.Health.SurgesPerDay));
		}


        private void LoadCharacterData()
        {
            raceBox.SelectedText = _character.Race.RaceName;
            classBox.SelectedText = _character.Class.ClassName;
            levelNud.Value = _character.Level.Value;
            strNud.Value = _character.Abilities.Strength.Score;
            dexNud.Value = _character.Abilities.Dexterity.Score;
            conNud.Value = _character.Abilities.Constitution.Score;
            wisNud.Value = _character.Abilities.Wisdom.Score;
            intNud.Value = _character.Abilities.Inteligence.Score;
            chaNud.Value = _character.Abilities.Charisma.Score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            classBox.Enabled = (editMode);
            raceBox.Enabled = (editMode);
            PopulateRace();
            PopulateClass();

            if (_character != null) {
                LoadCharacterData();
            }




            /*Test Load*/
          //  string file = "myCleric.txt";
          //  //string file = "Zaine.txt";

          //  IPersistance persist = new CharacterFile(DropBoxLocation+file);
          //  FeatFile featFile = new FeatFile(DropBoxLocation+"feats.txt");
          //Character c = new Character(persist,featFile);
          //  DisplayCharacter (ref c);


        }

        private void UpdateValues() {
            if (_character == null) { return; }
            CharacterSheet sheet = new CharacterSheet(ref _character);
            acLbl.Text = sheet.Defenses.ArmorClass.Value.ToString();
            refLbl.Text = sheet.Defenses.Reflex.Value.ToString();
            fortLbl.Text = sheet.Defenses.Fortitude.Value.ToString();
            willLbl.Text = sheet.Defenses.Will.Value.ToString();
        }

        private void PopulateClass()
        {
            classBox.Items.Add(CharacterClass.Cleric.ClassName);
        }

        private void PopulateRace()
        {
            raceBox.Items.Add(CharacterRace.Human.RaceName);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            UpdateCharacter();
            if (ValidCharacter)
            {
                UpdateValues();
            }
        }

        private bool ValidCharacter { get {
            if (_character == null){return false;}
                if (_character.Race == null) { return false; }
                if (_character.Class == null) { return false; }

            return true;
        
        } }

        private void UpdateCharacter()
        {
            if (!string.IsNullOrEmpty(classBox.Text)) { _character.SetClass(CharacterClass.FromClassName(classBox.Text)); }
            if (!string.IsNullOrEmpty(raceBox.Text)) { _character.SetRace(CharacterRace.FromRaceName(raceBox.Text)); }
            _character.Level.Value = (int)levelNud.Value;

            _character.Abilities.Strength.Score = (int)strNud.Value;
            _character.Abilities.Dexterity.Score = (int)dexNud.Value;
            _character.Abilities.Constitution.Score = (int)conNud.Value;
            _character.Abilities.Wisdom.Score = (int)wisNud.Value;
            _character.Abilities.Inteligence.Score = (int)intNud.Value;
            _character.Abilities.Charisma.Score = (int)chaNud.Value;
        }
    }
}
