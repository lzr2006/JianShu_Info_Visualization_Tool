using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace JVIT_GUI
{
    public partial class Form1 : Form
    {

        public List<string> files = new List<string>();
        public int X = 142;
        public int Y = 120;
        public bool z = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tt = DateTime.Now.ToString();
            label5.Text = tt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.White;
            panel5.BackColor = panel7.BackColor = panel8.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:用户信息查询";
            tabControl1.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.BackColor = System.Drawing.Color.White;
            panel6.BackColor = panel7.BackColor = panel8.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:文章信息查询";
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.BackColor = System.Drawing.Color.White;
            panel5.BackColor = panel6.BackColor = panel8.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:小岛信息查询";
            tabControl1.SelectedIndex = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel8.BackColor = System.Drawing.Color.White;
            panel5.BackColor = panel6.BackColor = panel7.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:简书贝小岛查询";
           // MessageBox.Show("还未开发!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedIndex = 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel9.BackColor = System.Drawing.Color.White;
            panel5.BackColor = panel6.BackColor = panel7.BackColor = panel8.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:设置项";
            tabControl1.SelectedIndex = 4;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.tabControl1.Region = new Region(new RectangleF(this.tabPage1.Left, this.tabPage1.Top, this.tabPage1.Width, this.tabPage1.Height));
            this.Location = new Point(142, 120);
            StreamReader st = new StreamReader(Application.StartupPath + "\\Me.txt");
            if (st.ReadToEnd() != string.Empty)
            {

                z = true;
                checkBox1.Checked = true;
                
               
            }
            st.Close();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter address = new StreamWriter(Application.StartupPath + "\\ArticleAddress.txt");
            address.Write(textBox1.Text);
            address.Flush();
            address.Close();
            System.Threading.Thread.Sleep(2000);
            System.Diagnostics.Process.Start(Application.StartupPath + "\\AutoArticle.exe");
            MessageBox.Show("黑色窗口自动关掉后请点击获取按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader info = new StreamReader(Application.StartupPath + "\\Article.txt"); //打开文件
                string article_info = info.ReadToEnd();
                string[] info_array = article_info.Split(';'); //分割
                                                               //回显
                textBox2.Text = info_array[0];
                textBox3.Text = info_array[1];
                textBox4.Text = info_array[2];
                textBox5.Text = info_array[3];
                textBox6.Text = info_array[4];
                textBox7.Text = info_array[5];
                textBox8.Text = info_array[6];
                textBox9.Text = info_array[7];
                textBox10.Text = info_array[8];
                textBox11.Text = info_array[9];
                textBox12.Text = info_array[10];
            }
            catch
            {
                MessageBox.Show("请先输入文章链接并查询哦~_~", "普通错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/52698676395f");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/0ca8563df322");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.toysworld.ml");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/65565c15c468");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wolai.com/jianshu/mDPp1ukoQt8iyDZJTFxxcP");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://share.streamlit.io/fhu-yezi/diszeroerhelper/main/main.py");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/2c09f3d73666");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/d1bef91888d8");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/framework/get-started/overview");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.jianshu.com/p/06d33efe8b35");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://toysworld.lanzoui.com/iPpiqqn870j");
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://toysworld.lanzoui.com/ihVApmmxlcf");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://toysworld.lanzoui.com/ioLiyog66zc");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢使用JVIT!","退出",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Environment.Exit(0);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            panel5.BackColor = panel6.BackColor = panel7.BackColor = panel8.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamWriter address = new StreamWriter(Application.StartupPath + "\\UserAddress.txt");
            address.Write(textBox13.Text);
            address.Flush();
            address.Close();
            System.Threading.Thread.Sleep(2000);
            System.Diagnostics.Process.Start(Application.StartupPath + "\\AutoUser.exe");
            MessageBox.Show("黑色窗口自动关掉后请点击获取按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader info = new StreamReader(Application.StartupPath + "\\User.txt"); //打开文件
                string article_info = info.ReadToEnd();
                info.Close();
                string[] info_array = article_info.Split(';'); //分割
                                                               //回显
                textBox24.Text = info_array[0];
                textBox23.Text = info_array[1];
                textBox22.Text = info_array[2];
                textBox21.Text = info_array[3];
                textBox20.Text = info_array[4];
                textBox19.Text = info_array[5];
                textBox25.Text = info_array[6];
                textBox18.Text = info_array[7];
                textBox26.Text = info_array[8];
                textBox17.Text = info_array[9];
                textBox15.Text = info_array[10];

                string[] article_array = info_array[11].Split('-');
                foreach (var item in article_array)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("请先输入用户链接并查询哦~_~", "普通错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter address = new StreamWriter(Application.StartupPath + "\\IslandAddress.txt");
            address.Write(textBox14.Text);
            address.Flush();
            address.Close();
            System.Threading.Thread.Sleep(2000);
            System.Diagnostics.Process.Start(Application.StartupPath + "\\AutoIsland.exe");
            MessageBox.Show("黑色窗口自动关掉后请点击获取按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

                StreamReader info = new StreamReader(Application.StartupPath + "\\Island.txt"); //打开文件               
                string island_info = info.ReadToEnd();
                info.Close();
                string[] info_array = island_info.Split(';'); //分割

                textBox36.Text = info_array[0];
                textBox35.Text = info_array[1];
                textBox34.Text = info_array[2];

                string[] t_array = info_array[3].Split('&');

                foreach (var item in t_array)
                {
                

                if (item != string.Empty)
                {

                    
                    string[] nr = item.Split('$');

                    files.Add(nr[7]);

                    if (Convert.ToInt32(nr[1]) >= 100)
                    {
                        listBox2.Items.Add(nr[0].ToString() + "      " + nr[1].ToString() + "         " + nr[2].ToString() + "       " + nr[3].ToString() + "        " + nr[4].ToString() + "        " + nr[5].ToString() + "        " + nr[6].ToString());
                    }
                    else if (Convert.ToInt32(nr[1]) < 10 && Convert.ToInt32(nr[2]) < 10)
                    {
                        listBox2.Items.Add(nr[0].ToString() + "       " + nr[1].ToString() + "          " + nr[2].ToString() + "        " + nr[3].ToString() + "        " + nr[4].ToString() + "        " + nr[5].ToString() + "        " + nr[6].ToString());
                    }
                    else if (Convert.ToInt32(nr[1]) > 10 && Convert.ToInt32(nr[2]) < 10)
                    {
                        listBox2.Items.Add(nr[0].ToString() + "      " + nr[1].ToString() + "          " + nr[2].ToString() + "        " + nr[3].ToString() + "        " + nr[4].ToString() + "        " + nr[5].ToString() + "        " + nr[6].ToString());
                    }

                    else if (Convert.ToInt32(nr[1]) >= 10)
                    {
                        listBox2.Items.Add(nr[0].ToString() + "      " + nr[1].ToString() + "         " + nr[2].ToString() + "        " + nr[3].ToString() + "        " + nr[4].ToString() + "        " + nr[5].ToString() + "        " + nr[6].ToString());
                    }         

                }

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int temp = listBox2.SelectedIndex;
            MessageBox.Show(files[temp],"察看窗口",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除后不可恢复，是否删除？","普通警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //其实就是Remove没法用 不想做了
                MessageBox.Show("没有权限！","普通错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Y = Y - 20;
            Location = new Point(X, Y);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Y = Y + 20;
            Location = new Point(X, Y);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            X = X - 20;
            Location = new Point(X, Y);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            X = X + 20;
            Location = new Point(X, Y);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.White;
            panel5.BackColor = panel7.BackColor = panel8.BackColor = panel9.BackColor = System.Drawing.Color.FromArgb(0, 71, 160);
            label4.Text = "当前模块:用户信息查询";
            tabControl1.SelectedIndex = 2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\AutoSheelIsland.exe");
            MessageBox.Show("黑色窗口自动关掉后请点击获取按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            StreamReader BI = new StreamReader(Application.StartupPath + "\\BeikeIsland.txt");
            string info = BI.ReadToEnd();
            string[] info_array = info.Split(';');
            textBox28.Text = info_array[0];
            textBox27.Text = info_array[1];
            string[] ingo = info_array[2].Split('%');
            foreach (var item in ingo)
            {
                if (item != string.Empty)
                {
                    string[] infomationR = item.Split('-');
                    if (Convert.ToInt32(infomationR[0]) != 10)
                    {
                        listBox3.Items.Add(infomationR[0] + "                      " + infomationR[1] + "                     " + infomationR[2]);
                    }
                    else
                    {
                        listBox3.Items.Add(infomationR[0] + "                     " + infomationR[1] + "                     " + infomationR[2]);
                    }
                
                }            
                 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\GetFans.exe"))
            {
                if (textBox16.Text == string.Empty && !z)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("请先填写主页地址！", "普通错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Me.txt");
                    sw.Write(textBox16.Text);
                    MessageBox.Show("配置成功！请重新启动JVIT", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    sw.Flush();
                    sw.Close();
                    z = true;
                }
            }
            else
            {
                checkBox1.Checked = false;
                MessageBox.Show("您还没有下载此扩展程序！", "普通错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            MKDown md = new JVIT_GUI.MKDown();
            md.Show();
        }
    }
}
