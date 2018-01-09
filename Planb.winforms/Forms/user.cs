using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planb.winforms.Forms
{
    public partial class user : MaterialSkin.Controls.MaterialForm
    {
        int t1 = 41;
        int t2 = 41;
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.panel2.Size=new Size(this.panel2.Width,t2);
            timer1.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            t1 = 41;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1>205)
            {
                timer1.Stop();
            }
            else
            {
                this.panel2.Size = new Size(this.panel2.Size.Width, t1);
                t1 += 41;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void user_MouseHover(object sender, EventArgs e)
        {
            this.panel2.Size = new Size(this.panel2.Width, t2);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            UserControl uctransaction = new UserControl();
            uctransaction.Show();
            Panel.Controls.Add(uctransaction);
            if(Panel.Controls.Contains(uctransaction.Instance))    
        }

        private void Oldertransaction_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
