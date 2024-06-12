using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SMG4Project");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/vendettathevhsdvr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vendettathevhsdvr.github.io/puzzlevisiontvarchive_18_04_2024/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://smg4project.github.io/betasmg4radioweb/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vendettathevhsdvr.github.io/haroldnewschannelsite/index.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //there nothing
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // This is bad
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://smg4project.github.io/smg4launcherserver/jd17pc_controller_fixer.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://smg4project.github.io/SMG4IPTV-Site/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://smg4project.github.io/smg4launcherserver/XP.End.of.support.application.exe");
        }
    }
}
