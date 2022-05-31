using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/UsAHMqNnvw");
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\YullyCrackedByFlux"))
            {
                Process.GetProcessesByName("volumeID.exe");
            }
            else Directory.CreateDirectory("C:\\YullyCrackedByFlux");
            Process.Start("C:\\YullyCrackedByFlux\\volumeID.exe");
        }
    }
}
