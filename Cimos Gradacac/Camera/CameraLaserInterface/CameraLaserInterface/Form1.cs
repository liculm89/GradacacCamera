using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace CameraLaserInterface
{
    public partial class Form1 : Form
    {

        string xcoordinate;
        string ycoordinate;

        public Form1()
        {
            

            InitializeComponent();

            promjerTxt.Text = "60";
            kutText.Text = "30";
            dmCode.Text = "12345678";
            get_coordinates();

            if (File.Exists(@"F:\Cimos Gradacac\Koordinate\coords.txt"))
            {
                File.Delete(@"F:\Cimos Gradacac\Koordinate\coords.txt");
            }

        }

        private void get_coordinates()
        {
            Double r, alpha;
            r = (Convert.ToDouble(promjerTxt.Text)) / 2;
            alpha = Convert.ToDouble(kutText.Text);
            double alpha_rad = (alpha * Math.PI) / 180.0;


            Console.WriteLine("Radius: " + r.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine("Kut: " + alpha_rad.ToString(CultureInfo.CreateSpecificCulture("en-GB")));

            xcoordinate = (Math.Round((Math.Cos(alpha_rad) * r), 3)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            ycoordinate = (Math.Round((Math.Sin(alpha_rad) * r), 3)).ToString(CultureInfo.CreateSpecificCulture("en-GB"));

            Console.WriteLine("X cord: " + xcoordinate);
            Console.WriteLine("Y cord: " + ycoordinate);

            //xcoordinate = Math.Round(xcoordinate, 2);

            xCord.Text = xcoordinate;
            yCord.Text = ycoordinate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void genFile_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"F:\Cimos Gradacac\Koordinate\coords.txt"))
            {
                File.Delete(@"F:\Cimos Gradacac\Koordinate\coords.txt");
            }
            string xcoord; string ycoord; string dmcode;
            xcoord = xCord.Text;
            ycoord = yCord.Text;
            dmcode = dmCode.Text;
                
            string[] lines = { xcoord, ycoord, dmcode };

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"F:\Cimos Gradacac\Koordinate\coords.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                   
                        file.WriteLine(line);
                    
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(@"F:\Cimos Gradacac\Koordinate\coords.txt"))
            {
                File.Delete(@"F:\Cimos Gradacac\Koordinate\coords.txt");
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"F:\Cimos Gradacac\Koordinate\coords.txt"))
            {
                File.Delete(@"F:\Cimos Gradacac\Koordinate\coords.txt");
            }
        }

        private void calc_coordinates_Click(object sender, EventArgs e)
        {
            get_coordinates();
        }
    }
}
