
namespace WindowsFormsAppProject1
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtUserid);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblUserid);
            this.panel1.Controls.Add(this.lbllogin);
            this.panel1.Location = new System.Drawing.Point(186, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 487);
            this.panel1.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclear.Location = new System.Drawing.Point(19, 401);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 37);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(119, 183);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(214, 32);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtUserid
            // 
            this.txtUserid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.Location = new System.Drawing.Point(119, 123);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(214, 32);
            this.txtUserid.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(266, 401);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(98, 37);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(6, 185);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(99, 24);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.Location = new System.Drawing.Point(6, 123);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(75, 24);
            this.lblUserid.TabIndex = 1;
            this.lblUserid.Text = "User Id";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(100, 22);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(233, 29);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login with your credentials";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Button btnclear;
    }
}

