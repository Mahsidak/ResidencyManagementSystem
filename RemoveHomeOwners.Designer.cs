
namespace WindowsFormsAppProject1
{
    partial class RemoveHomeOwners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveHomeOwners));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnremovehoeowner = new System.Windows.Forms.Button();
            this.txthomeowneridremove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblremovehomeowner = new System.Windows.Forms.Label();
            this.btnremovehomeownerback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnremovehoeowner);
            this.panel1.Controls.Add(this.txthomeowneridremove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblremovehomeowner);
            this.panel1.Controls.Add(this.btnremovehomeownerback);
            this.panel1.Location = new System.Drawing.Point(182, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 524);
            this.panel1.TabIndex = 0;
            // 
            // btnremovehoeowner
            // 
            this.btnremovehoeowner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremovehoeowner.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovehoeowner.Location = new System.Drawing.Point(162, 337);
            this.btnremovehoeowner.Name = "btnremovehoeowner";
            this.btnremovehoeowner.Size = new System.Drawing.Size(117, 47);
            this.btnremovehoeowner.TabIndex = 4;
            this.btnremovehoeowner.Text = "Remove";
            this.btnremovehoeowner.UseVisualStyleBackColor = false;
            this.btnremovehoeowner.Click += new System.EventHandler(this.btnremovehoeowner_Click);
            // 
            // txthomeowneridremove
            // 
            this.txthomeowneridremove.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthomeowneridremove.Location = new System.Drawing.Point(113, 266);
            this.txthomeowneridremove.Name = "txthomeowneridremove";
            this.txthomeowneridremove.Size = new System.Drawing.Size(208, 32);
            this.txthomeowneridremove.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "HomeOwner Id";
            // 
            // lblremovehomeowner
            // 
            this.lblremovehomeowner.AutoSize = true;
            this.lblremovehomeowner.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremovehomeowner.Location = new System.Drawing.Point(94, 90);
            this.lblremovehomeowner.Name = "lblremovehomeowner";
            this.lblremovehomeowner.Size = new System.Drawing.Size(240, 29);
            this.lblremovehomeowner.TabIndex = 1;
            this.lblremovehomeowner.Text = "Remove HomeOwner";
            // 
            // btnremovehomeownerback
            // 
            this.btnremovehomeownerback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnremovehomeownerback.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovehomeownerback.Location = new System.Drawing.Point(3, 23);
            this.btnremovehomeownerback.Name = "btnremovehomeownerback";
            this.btnremovehomeownerback.Size = new System.Drawing.Size(102, 31);
            this.btnremovehomeownerback.TabIndex = 0;
            this.btnremovehomeownerback.Text = "Back";
            this.btnremovehomeownerback.UseVisualStyleBackColor = false;
            this.btnremovehomeownerback.Click += new System.EventHandler(this.btnremovehomeownerback_Click);
            // 
            // RemoveHomeOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveHomeOwners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveHomeOwners";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoveHomeOwners_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremovehomeownerback;
        private System.Windows.Forms.Label lblremovehomeowner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthomeowneridremove;
        private System.Windows.Forms.Button btnremovehoeowner;
    }
}