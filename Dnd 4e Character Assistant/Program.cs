using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dnd_4e_Character_Assistant
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CharacterView(Settings.WorkingDirectory+file));
            Application.Run(new CharacterView());
        }

        static string file = "myCleric.txt";
        //static string file = "Zaine.txt";

    }
}
