using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//this program currently does not access the database (which means notes no longer save) because the database is no longer turned on. 
//It was only turned on during the hackathon when we worked on it.

//In this app you can create notes, save them to a database and access them later. You could access the same notes from different computers 
//because the notes are stored in a database in the cloud. as of right now the database is currently turned off. If it was turned on it would work.

//by Jonathan Yakimow, Nick Spreitzer, Jake Loyd, Michael Schweitzer, and Temish Christiansen during a 5 hour "mini hackathon"

namespace NoteTaker
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
            Application.Run(new Form1());
        }
    }
}
