using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Planb.winforms.Forms
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManage = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange100, MaterialSkin.TextShade.WHITE);

        }
       
        static int attempt = 3;
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            
            
                if (attempt == 0)
                {
                    lbl_Msg.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                    return;
                }
            try
            {
                MySqlConnection scn = new MySqlConnection();
                scn.ConnectionString = @"server=Evil-Hunter;user id=root;password=Root;database=digital";
                MySqlCommand scmd = new MySqlCommand("select * from login1 where Username='" + this.Username.Text + "' and Password='" + this.Password.Text + "'", scn);

                scn.Open();
                MySqlDataReader myreader;
                myreader = scmd.ExecuteReader();
                int count = 0;
                while (myreader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                    this.Hide();
                    user c1 = new user();
                    c1.ShowDialog();
                }

                else
                {


                    MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                    lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                    --attempt;
                    Username.Clear();
                    Password.Clear();
                }
                scn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        
    }

    
}
