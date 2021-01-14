
namespace MYSQLConnector
{
    partial class ClassExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanSettings = new System.Windows.Forms.Panel();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.TbDatabaseName = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbDatabase = new System.Windows.Forms.TextBox();
            this.PanSQL = new System.Windows.Forms.Panel();
            this.DgDBOut = new System.Windows.Forms.DataGridView();
            this.BtRead = new System.Windows.Forms.Button();
            this.TbCreateName = new System.Windows.Forms.TextBox();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.TbReadName = new System.Windows.Forms.TextBox();
            this.BtCreateComplex = new System.Windows.Forms.Button();
            this.TbCreatePostcode = new System.Windows.Forms.TextBox();
            this.BtCreateSimple = new System.Windows.Forms.Button();
            this.TbCreateNameOnly = new System.Windows.Forms.TextBox();
            this.Pan_Student = new System.Windows.Forms.Panel();
            this.DgDBStudents = new System.Windows.Forms.DataGridView();
            this.Bt_Home = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Pan_HomePage = new System.Windows.Forms.Panel();
            this.Bt_Staff = new System.Windows.Forms.Button();
            this.Bt_Contacts = new System.Windows.Forms.Button();
            this.Bt_Student = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Pan_Staff = new System.Windows.Forms.Panel();
            this.DgDBStaff = new System.Windows.Forms.DataGridView();
            this.Bt_Home2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pan_Contacts = new System.Windows.Forms.Panel();
            this.DgDBContacts = new System.Windows.Forms.DataGridView();
            this.Bt_Home3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PanSettings.SuspendLayout();
            this.PanSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBOut)).BeginInit();
            this.Pan_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBStudents)).BeginInit();
            this.Pan_HomePage.SuspendLayout();
            this.Pan_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBStaff)).BeginInit();
            this.Pan_Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSettings
            // 
            this.PanSettings.Controls.Add(this.BtUpdate);
            this.PanSettings.Controls.Add(this.TbDatabaseName);
            this.PanSettings.Controls.Add(this.TbUsername);
            this.PanSettings.Controls.Add(this.TbPassword);
            this.PanSettings.Controls.Add(this.TbDatabase);
            this.PanSettings.Location = new System.Drawing.Point(28, 12);
            this.PanSettings.Name = "PanSettings";
            this.PanSettings.Size = new System.Drawing.Size(425, 225);
            this.PanSettings.TabIndex = 0;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdate.Location = new System.Drawing.Point(0, 182);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(420, 36);
            this.BtUpdate.TabIndex = 4;
            this.BtUpdate.Text = "UPDATE SETTINGS";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // TbDatabaseName
            // 
            this.TbDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDatabaseName.Location = new System.Drawing.Point(3, 45);
            this.TbDatabaseName.Name = "TbDatabaseName";
            this.TbDatabaseName.Size = new System.Drawing.Size(417, 35);
            this.TbDatabaseName.TabIndex = 3;
            this.TbDatabaseName.Text = "Enter DB Name";
            // 
            // TbUsername
            // 
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(3, 86);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(417, 35);
            this.TbUsername.TabIndex = 2;
            this.TbUsername.Text = "Enter Username";
            this.TbUsername.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(0, 127);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(417, 35);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.Text = "Enter User Password";
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            this.TbPassword.Enter += new System.EventHandler(this.TbPassword_Enter);
            // 
            // TbDatabase
            // 
            this.TbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDatabase.Location = new System.Drawing.Point(3, 4);
            this.TbDatabase.Name = "TbDatabase";
            this.TbDatabase.Size = new System.Drawing.Size(417, 35);
            this.TbDatabase.TabIndex = 0;
            this.TbDatabase.Text = "Enter Database Address";
            // 
            // PanSQL
            // 
            this.PanSQL.Controls.Add(this.DgDBOut);
            this.PanSQL.Controls.Add(this.BtRead);
            this.PanSQL.Controls.Add(this.TbCreateName);
            this.PanSQL.Controls.Add(this.BtRefresh);
            this.PanSQL.Controls.Add(this.TbReadName);
            this.PanSQL.Controls.Add(this.BtCreateComplex);
            this.PanSQL.Controls.Add(this.TbCreatePostcode);
            this.PanSQL.Controls.Add(this.BtCreateSimple);
            this.PanSQL.Controls.Add(this.TbCreateNameOnly);
            this.PanSQL.Location = new System.Drawing.Point(877, 12);
            this.PanSQL.Name = "PanSQL";
            this.PanSQL.Size = new System.Drawing.Size(430, 373);
            this.PanSQL.TabIndex = 1;
            // 
            // DgDBOut
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgDBOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgDBOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgDBOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgDBOut.Location = new System.Drawing.Point(3, 168);
            this.DgDBOut.Name = "DgDBOut";
            this.DgDBOut.Size = new System.Drawing.Size(417, 199);
            this.DgDBOut.TabIndex = 14;
            this.DgDBOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDBOut_CellContentClick);
            // 
            // BtRead
            // 
            this.BtRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRead.Location = new System.Drawing.Point(270, 86);
            this.BtRead.Name = "BtRead";
            this.BtRead.Size = new System.Drawing.Size(150, 36);
            this.BtRead.TabIndex = 13;
            this.BtRead.Text = "Read ID";
            this.BtRead.UseVisualStyleBackColor = true;
            this.BtRead.Click += new System.EventHandler(this.BtRead_Click);
            // 
            // TbCreateName
            // 
            this.TbCreateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCreateName.Location = new System.Drawing.Point(3, 46);
            this.TbCreateName.Name = "TbCreateName";
            this.TbCreateName.Size = new System.Drawing.Size(121, 35);
            this.TbCreateName.TabIndex = 12;
            // 
            // BtRefresh
            // 
            this.BtRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRefresh.Location = new System.Drawing.Point(3, 126);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(417, 36);
            this.BtRefresh.TabIndex = 11;
            this.BtRefresh.Text = "Refresh DgDBOut";
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // TbReadName
            // 
            this.TbReadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbReadName.Location = new System.Drawing.Point(3, 86);
            this.TbReadName.Name = "TbReadName";
            this.TbReadName.Size = new System.Drawing.Size(261, 35);
            this.TbReadName.TabIndex = 10;
            // 
            // BtCreateComplex
            // 
            this.BtCreateComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateComplex.Location = new System.Drawing.Point(270, 46);
            this.BtCreateComplex.Name = "BtCreateComplex";
            this.BtCreateComplex.Size = new System.Drawing.Size(150, 36);
            this.BtCreateComplex.TabIndex = 9;
            this.BtCreateComplex.Text = "Write Complex";
            this.BtCreateComplex.UseVisualStyleBackColor = true;
            this.BtCreateComplex.Click += new System.EventHandler(this.BtCreateComplex_Click);
            // 
            // TbCreatePostcode
            // 
            this.TbCreatePostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCreatePostcode.Location = new System.Drawing.Point(143, 46);
            this.TbCreatePostcode.Name = "TbCreatePostcode";
            this.TbCreatePostcode.Size = new System.Drawing.Size(121, 35);
            this.TbCreatePostcode.TabIndex = 8;
            // 
            // BtCreateSimple
            // 
            this.BtCreateSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCreateSimple.Location = new System.Drawing.Point(270, 4);
            this.BtCreateSimple.Name = "BtCreateSimple";
            this.BtCreateSimple.Size = new System.Drawing.Size(150, 36);
            this.BtCreateSimple.TabIndex = 5;
            this.BtCreateSimple.Text = "Write Simple";
            this.BtCreateSimple.UseVisualStyleBackColor = true;
            this.BtCreateSimple.Click += new System.EventHandler(this.BtCreateSimple_Click);
            // 
            // TbCreateNameOnly
            // 
            this.TbCreateNameOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCreateNameOnly.Location = new System.Drawing.Point(3, 5);
            this.TbCreateNameOnly.Name = "TbCreateNameOnly";
            this.TbCreateNameOnly.Size = new System.Drawing.Size(261, 35);
            this.TbCreateNameOnly.TabIndex = 4;
            // 
            // Pan_Student
            // 
            this.Pan_Student.Controls.Add(this.DgDBStudents);
            this.Pan_Student.Controls.Add(this.Bt_Home);
            this.Pan_Student.Controls.Add(this.textBox4);
            this.Pan_Student.Location = new System.Drawing.Point(31, 243);
            this.Pan_Student.Name = "Pan_Student";
            this.Pan_Student.Size = new System.Drawing.Size(382, 234);
            this.Pan_Student.TabIndex = 2;
            // 
            // DgDBStudents
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgDBStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgDBStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgDBStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgDBStudents.Location = new System.Drawing.Point(14, 86);
            this.DgDBStudents.Name = "DgDBStudents";
            this.DgDBStudents.Size = new System.Drawing.Size(356, 139);
            this.DgDBStudents.TabIndex = 15;
            this.DgDBStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bt_Home
            // 
            this.Bt_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Home.Location = new System.Drawing.Point(91, 3);
            this.Bt_Home.Name = "Bt_Home";
            this.Bt_Home.Size = new System.Drawing.Size(181, 36);
            this.Bt_Home.TabIndex = 4;
            this.Bt_Home.Text = "back to home ";
            this.Bt_Home.UseVisualStyleBackColor = true;
            this.Bt_Home.Click += new System.EventHandler(this.Bt_Home_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(102, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 35);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Students Table";
            // 
            // Pan_HomePage
            // 
            this.Pan_HomePage.Controls.Add(this.Bt_Staff);
            this.Pan_HomePage.Controls.Add(this.Bt_Contacts);
            this.Pan_HomePage.Controls.Add(this.Bt_Student);
            this.Pan_HomePage.Controls.Add(this.textBox7);
            this.Pan_HomePage.Location = new System.Drawing.Point(880, 401);
            this.Pan_HomePage.Name = "Pan_HomePage";
            this.Pan_HomePage.Size = new System.Drawing.Size(417, 179);
            this.Pan_HomePage.TabIndex = 6;
            this.Pan_HomePage.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_HomePage_Paint);
            // 
            // Bt_Staff
            // 
            this.Bt_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Staff.Location = new System.Drawing.Point(239, 75);
            this.Bt_Staff.Name = "Bt_Staff";
            this.Bt_Staff.Size = new System.Drawing.Size(171, 36);
            this.Bt_Staff.TabIndex = 10;
            this.Bt_Staff.Text = "STAFF";
            this.Bt_Staff.UseVisualStyleBackColor = true;
            this.Bt_Staff.Click += new System.EventHandler(this.Bt_Staff_Click);
            // 
            // Bt_Contacts
            // 
            this.Bt_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Contacts.Location = new System.Drawing.Point(131, 127);
            this.Bt_Contacts.Name = "Bt_Contacts";
            this.Bt_Contacts.Size = new System.Drawing.Size(171, 36);
            this.Bt_Contacts.TabIndex = 9;
            this.Bt_Contacts.Text = "CONTACTS";
            this.Bt_Contacts.UseVisualStyleBackColor = true;
            this.Bt_Contacts.Click += new System.EventHandler(this.Bt_Contacts_Click);
            // 
            // Bt_Student
            // 
            this.Bt_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Student.Location = new System.Drawing.Point(14, 75);
            this.Bt_Student.Name = "Bt_Student";
            this.Bt_Student.Size = new System.Drawing.Size(171, 36);
            this.Bt_Student.TabIndex = 4;
            this.Bt_Student.Text = "STUDENTS";
            this.Bt_Student.UseVisualStyleBackColor = true;
            this.Bt_Student.Click += new System.EventHandler(this.Bt_Student_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(147, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 35);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "Home Page ";
            // 
            // Pan_Staff
            // 
            this.Pan_Staff.Controls.Add(this.DgDBStaff);
            this.Pan_Staff.Controls.Add(this.Bt_Home2);
            this.Pan_Staff.Controls.Add(this.textBox1);
            this.Pan_Staff.Location = new System.Drawing.Point(474, 197);
            this.Pan_Staff.Name = "Pan_Staff";
            this.Pan_Staff.Size = new System.Drawing.Size(397, 271);
            this.Pan_Staff.TabIndex = 7;
            this.Pan_Staff.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_Staff_Paint);
            // 
            // DgDBStaff
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgDBStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgDBStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgDBStaff.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgDBStaff.Location = new System.Drawing.Point(17, 121);
            this.DgDBStaff.Name = "DgDBStaff";
            this.DgDBStaff.Size = new System.Drawing.Size(356, 139);
            this.DgDBStaff.TabIndex = 15;
            // 
            // Bt_Home2
            // 
            this.Bt_Home2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Home2.Location = new System.Drawing.Point(216, 3);
            this.Bt_Home2.Name = "Bt_Home2";
            this.Bt_Home2.Size = new System.Drawing.Size(181, 36);
            this.Bt_Home2.TabIndex = 4;
            this.Bt_Home2.Text = "back to home ";
            this.Bt_Home2.UseVisualStyleBackColor = true;
            this.Bt_Home2.Click += new System.EventHandler(this.Bt_Home2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Staff Table";
            // 
            // Pan_Contacts
            // 
            this.Pan_Contacts.Controls.Add(this.DgDBContacts);
            this.Pan_Contacts.Controls.Add(this.Bt_Home3);
            this.Pan_Contacts.Controls.Add(this.textBox2);
            this.Pan_Contacts.Location = new System.Drawing.Point(304, 483);
            this.Pan_Contacts.Name = "Pan_Contacts";
            this.Pan_Contacts.Size = new System.Drawing.Size(391, 255);
            this.Pan_Contacts.TabIndex = 8;
            // 
            // DgDBContacts
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgDBContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgDBContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgDBContacts.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgDBContacts.Location = new System.Drawing.Point(12, 103);
            this.DgDBContacts.Name = "DgDBContacts";
            this.DgDBContacts.Size = new System.Drawing.Size(356, 139);
            this.DgDBContacts.TabIndex = 15;
            // 
            // Bt_Home3
            // 
            this.Bt_Home3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Home3.Location = new System.Drawing.Point(207, 3);
            this.Bt_Home3.Name = "Bt_Home3";
            this.Bt_Home3.Size = new System.Drawing.Size(181, 36);
            this.Bt_Home3.TabIndex = 4;
            this.Bt_Home3.Text = "back to home ";
            this.Bt_Home3.UseVisualStyleBackColor = true;
            this.Bt_Home3.Click += new System.EventHandler(this.Bt_Home3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(92, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 35);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Contacts Table";
            // 
            // ClassExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 749);
            this.Controls.Add(this.Pan_Contacts);
            this.Controls.Add(this.Pan_Staff);
            this.Controls.Add(this.Pan_HomePage);
            this.Controls.Add(this.Pan_Student);
            this.Controls.Add(this.PanSQL);
            this.Controls.Add(this.PanSettings);
            this.Name = "ClassExample";
            this.Text = "DB Connector Example";
            this.Load += new System.EventHandler(this.ClassExample_Load);
            this.PanSettings.ResumeLayout(false);
            this.PanSettings.PerformLayout();
            this.PanSQL.ResumeLayout(false);
            this.PanSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBOut)).EndInit();
            this.Pan_Student.ResumeLayout(false);
            this.Pan_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBStudents)).EndInit();
            this.Pan_HomePage.ResumeLayout(false);
            this.Pan_HomePage.PerformLayout();
            this.Pan_Staff.ResumeLayout(false);
            this.Pan_Staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBStaff)).EndInit();
            this.Pan_Contacts.ResumeLayout(false);
            this.Pan_Contacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSettings;
        private System.Windows.Forms.Panel PanSQL;
        private System.Windows.Forms.TextBox TbDatabaseName;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbDatabase;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.DataGridView DgDBOut;
        private System.Windows.Forms.Button BtRead;
        private System.Windows.Forms.TextBox TbCreateName;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.TextBox TbReadName;
        private System.Windows.Forms.Button BtCreateComplex;
        private System.Windows.Forms.TextBox TbCreatePostcode;
        private System.Windows.Forms.Button BtCreateSimple;
        private System.Windows.Forms.TextBox TbCreateNameOnly;
        private System.Windows.Forms.Panel Pan_Student;
        private System.Windows.Forms.Button Bt_Home;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel Pan_HomePage;
        private System.Windows.Forms.Button Bt_Student;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Bt_Staff;
        private System.Windows.Forms.Button Bt_Contacts;
        private System.Windows.Forms.DataGridView DgDBStudents;
        private System.Windows.Forms.Panel Pan_Staff;
        private System.Windows.Forms.DataGridView DgDBStaff;
        private System.Windows.Forms.Button Bt_Home2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Pan_Contacts;
        private System.Windows.Forms.DataGridView DgDBContacts;
        private System.Windows.Forms.Button Bt_Home3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

