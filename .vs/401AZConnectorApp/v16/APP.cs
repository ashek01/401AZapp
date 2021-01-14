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
            PanSettings.Location = new Point(12, 12);//move the panels
            Pan_HomePage.Visible = false;
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
                    Pan_HomePage.Location = new Point(468, 12);
                    PanSettings.Visible = false;
                    Pan_Contacts.Visible = false;
                    Pan_Staff.Visible = false;
                    Pan_Student.Visible = false;
                    Pan_HomePage.Visible = true;
                    PanSQL.Visible = false;
                    DgDBOut.DataSource = sqlCon.readAll().Tables[0];
                }
                else { MessageBox.Show("Connection error, \r\ncheck details"); }
            }
            else { MessageBox.Show("Please Enter Details"); }
            //Confirm login, or show error
            //if correct, make next pannel visible (hide this one)
            // populate datagrid
            
        }
        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void TbPassword_Enter(object sender, EventArgs e)
        {
            TbPassword.PasswordChar = '*';
            TbPassword.Text = "";
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {// run dataset fill in connector, return dataset to datagrid

            DgDBOut.DataSource = sqlCon.readAll().Tables[0];//specifies what table number you want to use
       
        }

        private void BtCreateSimple_Click(object sender, EventArgs e)
        {//pass table text to connecter method to write to database, return if error present textbox
            if (!sqlCon.createName(TbCreateNameOnly.Text)); { MessageBox.Show("Error when inserting record"); }
            BtRefresh_Click(BtCreateSimple, null);       
        }

        private void BtCreateComplex_Click(object sender, EventArgs e)
        {//pass table text to connecter method to write to database, return if error present textbox

            if (!sqlCon.createNamePostcode(TbCreateName.Text, TbCreateNameOnly.Text)) ; { MessageBox.Show("Error when inserting record"); }
            BtRefresh_Click(BtCreateComplex, null);
        }

        private void BtRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sqlCon.getID(TbReadName.Text));
        }

        

        private void Bt_Student_Click(object sender, EventArgs e)
        {
            Pan_Student.Location = new Point(468, 12);
            Pan_Student.Visible = true;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = false;
            Pan_Staff.Visible = false;
            Pan_Contacts.Visible = false;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];


        }

        private void DgDBOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pan_HomePage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pan_Staff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_Staff_Click(object sender, EventArgs e)
        {
            Pan_Staff.Location = new Point(468, 12);
            Pan_Student.Visible = false;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = false;
            Pan_Staff.Visible = true;
            Pan_Contacts.Visible = false;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];

        }

        private void Bt_Contacts_Click(object sender, EventArgs e)
        {
            Pan_Contacts.Location = new Point(468, 12);
            Pan_Student.Visible = false;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = false;
            Pan_Staff.Visible = false;
            Pan_Contacts.Visible = true;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];
        }

        private void Bt_Home_Click(object sender, EventArgs e)
        {
            Pan_HomePage.Location = new Point(468, 12);
            Pan_Student.Visible = false;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = true;
            Pan_Staff.Visible = false;
            Pan_Contacts.Visible = false;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];
        }

        private void Bt_Home2_Click(object sender, EventArgs e)
        {
            Pan_HomePage.Location = new Point(468, 12);
            Pan_Student.Visible = false;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = true;
            Pan_Staff.Visible = false;
            Pan_Contacts.Visible = false;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];
        }

        private void Bt_Home3_Click(object sender, EventArgs e)
        {
            Pan_HomePage.Location = new Point(468, 12);
            Pan_Student.Visible = false;
            PanSettings.Visible = false;
            Pan_HomePage.Visible = true;
            Pan_Staff.Visible = false;
            Pan_Contacts.Visible = false;
            PanSQL.Visible = false;
            DgDBOut.DataSource = sqlCon.readAll().Tables[0];
        }
    }
}
