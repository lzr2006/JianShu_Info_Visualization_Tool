using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIVT_GUI
{
    public partial class GetArticleInfo : Form
    {
        public GetArticleInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter address = new StreamWriter(Application.StartupPath + "\\ArticleAddress.txt");
            address.Write(textBox1.Text);
            address.Flush();
            address.Close();
            System.Threading.Thread.Sleep(2000);
            System.Diagnostics.Process.Start(Application.StartupPath + "\\AutoArticle.exe");
            MessageBox.Show("黑色窗口自动关掉后请点击获取按钮！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("请先输入文章链接并查询哦~_~","普通错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void GetArticleInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //终止所有线程
        }
    }
}
