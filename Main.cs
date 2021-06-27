using System;
using System.Windows.Forms;

namespace JIVT_GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                License.License used = new License.License();
                if (used.use == true)
                {
                    GetArticleInfo gai = new GetArticleInfo();
                    gai.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("许可证不允许您使用此程序!", "普通错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("您没有合适的许可证!","普通错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            AboutWe we = new JIVT_GUI.AboutWe();
            we.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
