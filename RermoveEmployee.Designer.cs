
namespace WindowsFormsAppProject1
{
    partial class RermoveEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RermoveEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndeleteemployeeprevious = new System.Windows.Forms.Button();
            this.btnremoveemployee = new System.Windows.Forms.Button();
            this.txtdeleteemployee = new System.Windows.Forms.TextBox();
            this.lblremoveemployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btndeleteemployeeprevious);
            this.panel1.Controls.Add(this.btnremoveemployee);
            this.panel1.Controls.Add(this.txtdeleteemployee);
            this.panel1.Controls.Add(this.lblremoveemployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 473);
            this.panel1.TabIndex = 0;
            // 
            // btndeleteemployeeprevious
            // 
            this.btndeleteemployeeprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndeleteemployeeprevious.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteemployeeprevious.Location = new System.Drawing.Point(15, 15);
            this.btndeleteemployeeprevious.Name = "btndeleteemployeeprevious";
            this.btndeleteemployeeprevious.Size = new System.Drawing.Size(102, 31);
            this.btndeleteemployeeprevious.TabIndex = 4;
            this.btndeleteemployeeprevious.Text = "Back";
            this.btndeleteemployeeprevious.UseVisualStyleBackColor = false;
            this.btndeleteemployeeprevious.Click += new System.EventHandler(this.btndeleteemployeeprevious_Click);
            // 
            // btnremoveemployee
            // 
            this.btnremoveemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremoveemployee.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveemployee.Location = new System.Drawing.Point(148, 322);
            this.btnremoveemployee.Name = "btnremoveemployee";
            this.btnremoveemployee.Size = new System.Drawing.Size(117, 47);
            this.btnremoveemployee.TabIndex = 3;
            this.btnremoveemployee.Text = "Remove";
            this.btnremoveemployee.UseVisualStyleBackColor = false;
            this.btnremoveemployee.Click += new System.EventHandler(this.btnremoveemployee_Click);
            // 
            // txtdeleteemployee
            // 
            this.txtdeleteemployee.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeleteemployee.Location = new System.Drawing.Point(83, 275);
            this.txtdeleteemployee.Name = "txtdeleteemployee";
            this.txtdeleteemployee.Size = new System.Drawing.Size(258, 32);
            this.txtdeleteemployee.TabIndex = 2;
            // 
            // lblremoveemployee
            // 
            this.lblremoveemployee.AutoSize = true;
            this.lblremoveemployee.BackColor = System.Drawing.Color.Transparent;
            this.lblremoveemployee.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremoveemployee.Location = new System.Drawing.Point(157, 226);
            this.lblremoveemployee.Name = "lblremoveemployee";
            this.lblremoveemployee.Size = new System.Drawing.Size(121, 24);
            this.lblremoveemployee.TabIndex = 1;
            this.lblremoveemployee.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Employee";
            // 
            // RermoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RermoveEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RermoveEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RermoveEmployee_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremoveemployee;
        private System.Windows.Forms.TextBox txtdeleteemployee;
        private System.Windows.Forms.Label lblremoveemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeleteemployeeprevious;
    }
}