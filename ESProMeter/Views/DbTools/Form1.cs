using ESProMeter.DataAccess;
using Microsoft.SqlServer.Dac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.DbTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DacPack(*.dacpac)|*.dacpac";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bk = new SqlUtility();
            DacServices srv = new DacServices("Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            srv.Message += (s, e) =>
            {
              
                System.Threading.Thread.Sleep(500);
                listBox1.Items.Add(e.Message.Message);
            };
            bk.DeployDatabase(srv,textBox1.Text, textBox2.Text);
        }
    }
}
