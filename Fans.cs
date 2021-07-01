using System;
using System.Windows.Forms;

namespace JVIT_GUI
{
    public partial class Fans : Form
    {
        public Fans()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\GetFans.exe");
            System.Threading.Thread.Sleep(5000);
            System.IO.StreamReader sp = new System.IO.StreamReader(Application.StartupPath + "\\Fans.txt");
            string fans = sp.ReadToEnd();
            label1.Text = fans;
            sp.Close();
        }
    }
}
