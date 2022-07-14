using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter
{
    public partial class Form1 : Form
    {
        Bitmap closeImage;
        public Form1()
        {
            InitializeComponent();
            closeImage = ESProMeter.Properties.Resources.closeR;
        }

        int x = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage p1 = new TabPage();
            p1.Text = $"Text----{x}-- ";
            //p1.BackColor = Color.Red;
            Views.Items.AddItemFrm item = new Views.Items.AddItemFrm();
            item.TopMost = true;
            item.TopLevel = false;
            item.FormBorderStyle = FormBorderStyle.None;
            p1.Controls.Add(item);
            item.Show();
            tabControl1.TabPages.Add(p1);
            p1.Select();
            x++;
        }
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            //e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            //e.DrawFocusRectangle();

            try
            {
                Image img = new Bitmap(closeImage);
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(0, 0);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.tabControl1.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

                if (tabControl1.SelectedIndex >= 1)
                {
                    e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }
            }
            catch (Exception) { }
        }
    }
}
