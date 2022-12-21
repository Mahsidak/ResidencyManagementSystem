
namespace WindowsFormsAppProject1
{
    partial class SearchEmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEmployeeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvshowinfo = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearchemployeeprevious = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.lblemployeeidsearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowinfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvshowinfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 283);
            this.panel1.TabIndex = 0;
            // 
            // dgvshowinfo
            // 
            this.dgvshowinfo.AllowUserToAddRows = false;
            this.dgvshowinfo.AllowUserToDeleteRows = false;
            this.dgvshowinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvshowinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.Gender,
            this.PhoneNumber,
            this.Nid,
            this.Role});
            this.dgvshowinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvshowinfo.Location = new System.Drawing.Point(0, 0);
            this.dgvshowinfo.Name = "dgvshowinfo";
            this.dgvshowinfo.ReadOnly = true;
            this.dgvshowinfo.RowHeadersWidth = 51;
            this.dgvshowinfo.RowTemplate.Height = 24;
            this.dgvshowinfo.Size = new System.Drawing.Size(856, 283);
            this.dgvshowinfo.TabIndex = 0;
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Nid
            // 
            this.Nid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nid.DataPropertyName = "Nid";
            this.Nid.HeaderText = "Nid";
            this.Nid.MinimumWidth = 6;
            this.Nid.Name = "Nid";
            this.Nid.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnsearchemployeeprevious);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txtemployeeid);
            this.panel2.Controls.Add(this.lblemployeeidsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 319);
            this.panel2.TabIndex = 1;
            // 
            // btnsearchemployeeprevious
            // 
            this.btnsearchemployeeprevious.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsearchemployeeprevious.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchemployeeprevious.Location = new System.Drawing.Point(12, 12);
            this.btnsearchemployeeprevious.Name = "btnsearchemployeeprevious";
            this.btnsearchemployeeprevious.Size = new System.Drawing.Size(114, 37);
            this.btnsearchemployeeprevious.TabIndex = 7;
            this.btnsearchemployeeprevious.Text = "Previous";
            this.btnsearchemployeeprevious.UseVisualStyleBackColor = false;
            this.btnsearchemployeeprevious.Click += new System.EventHandler(this.btnsearchemployeeprevious_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(578, 152);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(118, 32);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeid.Location = new System.Drawing.Point(294, 152);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(251, 32);
            this.txtemployeeid.TabIndex = 5;
            // 
            // lblemployeeidsearch
            // 
            this.lblemployeeidsearch.AutoSize = true;
            this.lblemployeeidsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblemployeeidsearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeidsearch.Location = new System.Drawing.Point(143, 152);
            this.lblemployeeidsearch.Name = "lblemployeeidsearch";
            this.lblemployeeidsearch.Size = new System.Drawing.Size(121, 24);
            this.lblemployeeidsearch.TabIndex = 4;
            this.lblemployeeidsearch.Text = "Employee Id";
            // 
            // SearchEmployeeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchEmployeeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchEmployeeAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchEmployeeAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowinfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvshowinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label lblemployeeidsearch;
        private System.Windows.Forms.Button btnsearchemployeeprevious;
    }
}