using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat__Windows_Forms_App_
{
        public abstract class Student
        {
            public static int numberOfRow = 0;
            public int Id { get; protected set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public int Godine { get; set; }
            public StudiskiProgram studiskiProgram { get; set; }

            public enum StudiskiProgram
            {
                Informacione_Tehnologije,
                Računarstvo_i_Automatika,
                Web_Dizajn,
                Softversko_inženjerstvo,
                Mašinstvo
            }

            public static void Podaci()
            {
                MessageBox.Show("Unos podataka će biti izvršen...", "Unos podataka!", MessageBoxButtons.OK);
            }

            public override string ToString()
            {
                return Ime + " " + Prezime + " je student Visoke tehnicke škole strukovnih studija u Novom Sadu!";
            }
        }
}
