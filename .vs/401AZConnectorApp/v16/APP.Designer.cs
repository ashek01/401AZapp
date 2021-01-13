
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.PanSettings.SuspendLayout();
            this.PanSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDBOut)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSettings
            // 
            this.PanSettings.Controls.Add(this.BtUpdate);
            this.PanSettings.Controls.Add(this.TbDatabaseName);
            this.PanSettings.Controls.Add(this.TbUsername);
            this.PanSettings.Controls.Add(this.TbPassword);
            this.PanSettings.Controls.Add(this.TbDatabase);
            this.PanSettings.Location = new System.Drawing.Point(12, 12);
            this.PanSettings.Name = "PanSettings";
            this.PanSettings.Size = new System.Drawing.Size(423, 482);
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
            this.PanSQL.Location = new System.Drawing.Point(481, 12);
            this.PanSQL.Name = "PanSQL";
            this.PanSQL.Size = new System.Drawing.Size(423, 482);
            this.PanSQL.TabIndex = 1;
            // 
            // DgDBOut
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgDBOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgDBOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgDBOut.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgDBOut.Location = new System.Drawing.Point(3, 168);
            this.DgDBOut.Name = "DgDBOut";
            this.DgDBOut.Size = new System.Drawing.Size(417, 275);
            this.DgDBOut.TabIndex = 14;
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
            // ClassExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 530);
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
    }
}

