using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSQLConnector
{
    public partial class ClassExample : Form
    {
        private Connector sqlCon = new Connector();

        public ClassExample()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClassExample_Load(object sender, EventArgs e)
        {
            setup();
        }

        private void setup()
        {//runs on form load and make my form organized for end user
            this.Size = new Size(452, 535);//resize form
            PanSQL.Location = new Point(12, 12);//move the panels
            PanSettings.Visible = true;//show show pannels 
            PanSQL.Visible = false;//hide unshown pannels
            TbCreateName.Text = "Enter Name";
            TbCreateNameOnly.Text = "Enter Name";
            TbCreatePostcode.Text = "Enter Postcode";
            TbReadName.Text = "Name to search";
            TbDatabase.Text = "Enter Database Address";
            TbDatabaseName.Text = "Enter DB Name";
            TbPassword.Text = "Enter DB User password";
            TbUsername.Text = "Enter DB Username";
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (
                TbUsername.Text != "DB user name" &&
                (TbPassword.Text != "DB user name" || TbPassword.Text != "")
                ) 
            { 
                sqlCon.setDataSource(TbDatabase.Text);
                sqlCon.setInitialCatalog(TbDatabaseName.Text);
                sqlCon.setUserID(TbUsername.Text);
                sqlCon.setPassword(TbPassword.Text);
                sqlCon.setConnectionString();
                if (sqlCon.connTest())
                {
                    PanSettings.Visible = false;
                    PanSQL.Visible = true;
                }
                else { MessageBox.Show("Connection error, \r\ncheck details"); }


            }
            else { MessageBox.Show("Please Enter Details"); }
           
            //Confirm login, or show error
            //if correct, make next pannel visible (hide this one)
            
        }
        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void TbPassword_Enter(object sender, EventArgs e)
        {
            TbPassword.PasswordChar = '*';
            TbPassword.Text = "";
        }
    }
}
