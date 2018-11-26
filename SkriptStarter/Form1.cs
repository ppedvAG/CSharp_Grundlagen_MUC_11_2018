using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkriptStarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "Hintergrundskript_Für_SkriptStarter.exe";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;

            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
            while(!p.StandardOutput.EndOfStream)
            {
                listBox1.Items.Add(p.StandardOutput.ReadLine());
                Application.DoEvents();
            }
            //p.WaitForExit();
        }
    }
}
