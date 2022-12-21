
namespace WindowsFormsAppProject1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearchemployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnremoveemployeeadmin = new System.Windows.Forms.Button();
            this.btnaddemployeeadmin = new System.Windows.Forms.Button();
            this.btnadminchangepassword = new System.Windows.Forms.Button();
            this.lbladminpanel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnsearchemployee);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnremoveemployeeadmin);
            this.panel1.Controls.Add(this.btnaddemployeeadmin);
            this.panel1.Controls.Add(this.btnadminchangepassword);
            this.panel1.Controls.Add(this.lbladminpanel);
            this.panel1.Location = new System.Drawing.Point(183, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 542);
            this.panel1.TabIndex = 0;
            // 
            // btnsearchemployee
            // 
            this.btnsearchemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsearchemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchemployee.Location = new System.Drawing.Point(116, 330);
            this.btnsearchemployee.Name = "btnsearchemployee";
            this.btnsearchemployee.Size = new System.Drawing.Size(220, 33);
            this.btnsearchemployee.TabIndex = 6;
            this.btnsearchemployee.Text = "Search Employee";
            this.btnsearchemployee.UseVisualStyleBackColor = false;
            this.btnsearchemployee.Click += new System.EventHandler(this.btnsearchemployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(164, 449);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnremoveemployeeadmin
            // 
            this.btnremoveemployeeadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnremoveemployeeadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveemployeeadmin.Location = new System.Drawing.Point(116, 271);
            this.btnremoveemployeeadmin.Name = "btnremoveemployeeadmin";
            this.btnremoveemployeeadmin.Size = new System.Drawing.Size(220, 33);
            this.btnremoveemployeeadmin.TabIndex = 3;
            this.btnremoveemployeeadmin.Text = "Remove Employee";
            this.btnremoveemployeeadmin.UseVisualStyleBackColor = false;
            this.btnremoveemployeeadmin.Click += new System.EventHandler(this.btnremoveemployeeadmin_Click);
            // 
            // btnaddemployeeadmin
            // 
            this.btnaddemployeeadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnaddemployeeadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemployeeadmin.Location = new System.Drawing.Point(116, 210);
            this.btnaddemployeeadmin.Name = "btnaddemployeeadmin";
            this.btnaddemployeeadmin.Size = new System.Drawing.Size(220, 32);
            this.btnaddemployeeadmin.TabIndex = 2;
            this.btnaddemployeeadmin.Text = "Add Employee";
            this.btnaddemployeeadmin.UseVisualStyleBackColor = false;
            this.btnaddemployeeadmin.Click += new System.EventHandler(this.btnaddemployeeadmin_Click);
            // 
            // btnadminchangepassword
            // 
            this.btnadminchangepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnadminchangepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminchangepassword.Location = new System.Drawing.Point(116, 150);
            this.btnadminchangepassword.Name = "btnadminchangepassword";
            this.btnadminchangepassword.Size = new System.Drawing.Size(220, 35);
            this.btnadminchangepassword.TabIndex = 1;
            this.btnadminchangepassword.Text = "Change Password";
            this.btnadminchangepassword.UseVisualStyleBackColor = false;
            this.btnadminchangepassword.Click += new System.EventHandler(this.btnadminchangepassword_Click);
            // 
            // lbladminpanel
            // 
            this.lbladminpanel.AutoSize = true;
            this.lbladminpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminpanel.Location = new System.Drawing.Point(110, 42);
            this.lbladminpanel.Name = "lbladminpanel";
            this.lbladminpanel.Size = new System.Drawing.Size(234, 32);
            this.lbladminpanel.TabIndex = 0;
            this.lbladminpanel.Text = "Welcome Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladminpanel;
        private System.Windows.Forms.Button btnremoveemployeeadmin;
        private System.Windows.Forms.Button btnaddemployeeadmin;
        private System.Windows.Forms.Button btnadminchangepassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnsearchemployee;
    }
}