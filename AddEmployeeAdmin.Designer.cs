
namespace WindowsFormsAppProject1
{
    partial class AddEmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddemployeeprevious = new System.Windows.Forms.Button();
            this.btnaddempad = new System.Windows.Forms.Button();
            this.txtaddempnid = new System.Windows.Forms.TextBox();
            this.txtaddempphonenumber = new System.Windows.Forms.TextBox();
            this.txtaddempname = new System.Windows.Forms.TextBox();
            this.cmbaddemgender = new System.Windows.Forms.ComboBox();
            this.cmbaddemprole = new System.Windows.Forms.ComboBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.lbladdnid = new System.Windows.Forms.Label();
            this.lbladdphonenumber = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbladdname = new System.Windows.Forms.Label();
            this.lbladminaddemployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnaddemployeeprevious);
            this.panel1.Controls.Add(this.btnaddempad);
            this.panel1.Controls.Add(this.txtaddempnid);
            this.panel1.Controls.Add(this.txtaddempphonenumber);
            this.panel1.Controls.Add(this.txtaddempname);
            this.panel1.Controls.Add(this.cmbaddemgender);
            this.panel1.Controls.Add(this.cmbaddemprole);
            this.panel1.Controls.Add(this.lblrole);
            this.panel1.Controls.Add(this.lbladdnid);
            this.panel1.Controls.Add(this.lbladdphonenumber);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lbladdname);
            this.panel1.Controls.Add(this.lbladminaddemployee);
            this.panel1.Location = new System.Drawing.Point(172, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 509);
            this.panel1.TabIndex = 0;
            // 
            // btnaddemployeeprevious
            // 
            this.btnaddemployeeprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnaddemployeeprevious.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemployeeprevious.Location = new System.Drawing.Point(3, 13);
            this.btnaddemployeeprevious.Name = "btnaddemployeeprevious";
            this.btnaddemployeeprevious.Size = new System.Drawing.Size(113, 39);
            this.btnaddemployeeprevious.TabIndex = 12;
            this.btnaddemployeeprevious.Text = "Back";
            this.btnaddemployeeprevious.UseVisualStyleBackColor = false;
            this.btnaddemployeeprevious.Click += new System.EventHandler(this.btnaddemployeeprevious_Click);
            // 
            // btnaddempad
            // 
            this.btnaddempad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnaddempad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnaddempad.Location = new System.Drawing.Point(169, 408);
            this.btnaddempad.Name = "btnaddempad";
            this.btnaddempad.Size = new System.Drawing.Size(151, 42);
            this.btnaddempad.TabIndex = 11;
            this.btnaddempad.Text = "Add";
            this.btnaddempad.UseVisualStyleBackColor = false;
            this.btnaddempad.Click += new System.EventHandler(this.btnaddempad_Click);
            // 
            // txtaddempnid
            // 
            this.txtaddempnid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddempnid.Location = new System.Drawing.Point(190, 268);
            this.txtaddempnid.Name = "txtaddempnid";
            this.txtaddempnid.Size = new System.Drawing.Size(184, 32);
            this.txtaddempnid.TabIndex = 10;
            // 
            // txtaddempphonenumber
            // 
            this.txtaddempphonenumber.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddempphonenumber.Location = new System.Drawing.Point(190, 226);
            this.txtaddempphonenumber.Name = "txtaddempphonenumber";
            this.txtaddempphonenumber.Size = new System.Drawing.Size(184, 32);
            this.txtaddempphonenumber.TabIndex = 9;
            // 
            // txtaddempname
            // 
            this.txtaddempname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddempname.Location = new System.Drawing.Point(190, 141);
            this.txtaddempname.Name = "txtaddempname";
            this.txtaddempname.Size = new System.Drawing.Size(184, 32);
            this.txtaddempname.TabIndex = 8;
            // 
            // cmbaddemgender
            // 
            this.cmbaddemgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaddemgender.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaddemgender.FormattingEnabled = true;
            this.cmbaddemgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbaddemgender.Location = new System.Drawing.Point(190, 179);
            this.cmbaddemgender.Name = "cmbaddemgender";
            this.cmbaddemgender.Size = new System.Drawing.Size(184, 32);
            this.cmbaddemgender.TabIndex = 7;
            // 
            // cmbaddemprole
            // 
            this.cmbaddemprole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaddemprole.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaddemprole.FormattingEnabled = true;
            this.cmbaddemprole.Items.AddRange(new object[] {
            "Security Guard",
            "Gardener"});
            this.cmbaddemprole.Location = new System.Drawing.Point(190, 310);
            this.cmbaddemprole.Name = "cmbaddemprole";
            this.cmbaddemprole.Size = new System.Drawing.Size(184, 32);
            this.cmbaddemprole.TabIndex = 6;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.BackColor = System.Drawing.Color.Transparent;
            this.lblrole.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(14, 310);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(51, 24);
            this.lblrole.TabIndex = 5;
            this.lblrole.Text = "Role";
            // 
            // lbladdnid
            // 
            this.lbladdnid.AutoSize = true;
            this.lbladdnid.BackColor = System.Drawing.Color.Transparent;
            this.lbladdnid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnid.Location = new System.Drawing.Point(14, 270);
            this.lbladdnid.Name = "lbladdnid";
            this.lbladdnid.Size = new System.Drawing.Size(43, 24);
            this.lbladdnid.TabIndex = 4;
            this.lbladdnid.Text = "NID";
            // 
            // lbladdphonenumber
            // 
            this.lbladdphonenumber.AutoSize = true;
            this.lbladdphonenumber.BackColor = System.Drawing.Color.Transparent;
            this.lbladdphonenumber.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdphonenumber.Location = new System.Drawing.Point(14, 226);
            this.lbladdphonenumber.Name = "lbladdphonenumber";
            this.lbladdphonenumber.Size = new System.Drawing.Size(144, 24);
            this.lbladdphonenumber.TabIndex = 3;
            this.lbladdphonenumber.Text = "Phone Number";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(16, 183);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(76, 24);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Gender";
            // 
            // lbladdname
            // 
            this.lbladdname.AutoSize = true;
            this.lbladdname.BackColor = System.Drawing.Color.Transparent;
            this.lbladdname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdname.Location = new System.Drawing.Point(14, 143);
            this.lbladdname.Name = "lbladdname";
            this.lbladdname.Size = new System.Drawing.Size(63, 24);
            this.lbladdname.TabIndex = 1;
            this.lbladdname.Text = "Name";
            // 
            // lbladminaddemployee
            // 
            this.lbladminaddemployee.AutoSize = true;
            this.lbladminaddemployee.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminaddemployee.Location = new System.Drawing.Point(153, 80);
            this.lbladminaddemployee.Name = "lbladminaddemployee";
            this.lbladminaddemployee.Size = new System.Drawing.Size(167, 29);
            this.lbladminaddemployee.TabIndex = 0;
            this.lbladminaddemployee.Text = "Add Employee";
            // 
            // AddEmployeeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployeeAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddempad;
        private System.Windows.Forms.TextBox txtaddempnid;
        private System.Windows.Forms.TextBox txtaddempphonenumber;
        private System.Windows.Forms.TextBox txtaddempname;
        private System.Windows.Forms.ComboBox cmbaddemgender;
        private System.Windows.Forms.ComboBox cmbaddemprole;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lbladdnid;
        private System.Windows.Forms.Label lbladdphonenumber;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbladdname;
        private System.Windows.Forms.Label lbladminaddemployee;
        private System.Windows.Forms.Button btnaddemployeeprevious;
    }
}