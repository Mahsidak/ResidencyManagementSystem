
namespace WindowsFormsAppProject1
{
    partial class SearchHomeOwners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchHomeOwners));
            this.pnlsearchhomeowners = new System.Windows.Forms.Panel();
            this.dgvsearhomeowners = new System.Windows.Forms.DataGridView();
            this.OwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupassion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearchhomeownerprevious = new System.Windows.Forms.Button();
            this.lblowneridsearch = new System.Windows.Forms.Label();
            this.txtowneridsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhomeownersearch = new System.Windows.Forms.Button();
            this.pnlsearchhomeowners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearhomeowners)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlsearchhomeowners
            // 
            this.pnlsearchhomeowners.Controls.Add(this.dgvsearhomeowners);
            this.pnlsearchhomeowners.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlsearchhomeowners.Location = new System.Drawing.Point(0, 341);
            this.pnlsearchhomeowners.Name = "pnlsearchhomeowners";
            this.pnlsearchhomeowners.Size = new System.Drawing.Size(824, 279);
            this.pnlsearchhomeowners.TabIndex = 0;
            // 
            // dgvsearhomeowners
            // 
            this.dgvsearhomeowners.AllowUserToAddRows = false;
            this.dgvsearhomeowners.AllowUserToDeleteRows = false;
            this.dgvsearhomeowners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearhomeowners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnerId,
            this.Age,
            this.Phone,
            this.Occupassion,
            this.FlatNumber,
            this.Type});
            this.dgvsearhomeowners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsearhomeowners.Location = new System.Drawing.Point(0, 0);
            this.dgvsearhomeowners.Name = "dgvsearhomeowners";
            this.dgvsearhomeowners.ReadOnly = true;
            this.dgvsearhomeowners.RowHeadersWidth = 51;
            this.dgvsearhomeowners.RowTemplate.Height = 24;
            this.dgvsearhomeowners.Size = new System.Drawing.Size(824, 279);
            this.dgvsearhomeowners.TabIndex = 0;
            // 
            // OwnerId
            // 
            this.OwnerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerId.DataPropertyName = "OwnerId";
            this.OwnerId.HeaderText = "OwnerId";
            this.OwnerId.MinimumWidth = 6;
            this.OwnerId.Name = "OwnerId";
            this.OwnerId.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Occupassion
            // 
            this.Occupassion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Occupassion.DataPropertyName = "Occupassion";
            this.Occupassion.HeaderText = "Occupassion";
            this.Occupassion.MinimumWidth = 6;
            this.Occupassion.Name = "Occupassion";
            this.Occupassion.ReadOnly = true;
            // 
            // FlatNumber
            // 
            this.FlatNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlatNumber.DataPropertyName = "FlatNumber";
            this.FlatNumber.HeaderText = "FlatNumber";
            this.FlatNumber.MinimumWidth = 6;
            this.FlatNumber.Name = "FlatNumber";
            this.FlatNumber.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // btnsearchhomeownerprevious
            // 
            this.btnsearchhomeownerprevious.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsearchhomeownerprevious.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchhomeownerprevious.Location = new System.Drawing.Point(12, 31);
            this.btnsearchhomeownerprevious.Name = "btnsearchhomeownerprevious";
            this.btnsearchhomeownerprevious.Size = new System.Drawing.Size(114, 37);
            this.btnsearchhomeownerprevious.TabIndex = 1;
            this.btnsearchhomeownerprevious.Text = "Previous";
            this.btnsearchhomeownerprevious.UseVisualStyleBackColor = false;
            this.btnsearchhomeownerprevious.Click += new System.EventHandler(this.btnsearchhomeownerprevious_Click);
            // 
            // lblowneridsearch
            // 
            this.lblowneridsearch.AutoSize = true;
            this.lblowneridsearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblowneridsearch.Location = new System.Drawing.Point(86, 171);
            this.lblowneridsearch.Name = "lblowneridsearch";
            this.lblowneridsearch.Size = new System.Drawing.Size(91, 24);
            this.lblowneridsearch.TabIndex = 2;
            this.lblowneridsearch.Text = "Owner Id";
            // 
            // txtowneridsearch
            // 
            this.txtowneridsearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtowneridsearch.Location = new System.Drawing.Point(238, 163);
            this.txtowneridsearch.Name = "txtowneridsearch";
            this.txtowneridsearch.Size = new System.Drawing.Size(232, 32);
            this.txtowneridsearch.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnhomeownersearch);
            this.panel1.Controls.Add(this.txtowneridsearch);
            this.panel1.Controls.Add(this.lblowneridsearch);
            this.panel1.Controls.Add(this.btnsearchhomeownerprevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 341);
            this.panel1.TabIndex = 1;
            // 
            // btnhomeownersearch
            // 
            this.btnhomeownersearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnhomeownersearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomeownersearch.Location = new System.Drawing.Point(499, 158);
            this.btnhomeownersearch.Name = "btnhomeownersearch";
            this.btnhomeownersearch.Size = new System.Drawing.Size(114, 37);
            this.btnhomeownersearch.TabIndex = 4;
            this.btnhomeownersearch.Text = "Search";
            this.btnhomeownersearch.UseVisualStyleBackColor = false;
            this.btnhomeownersearch.Click += new System.EventHandler(this.btnhomeownersearch_Click);
            // 
            // SearchHomeOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlsearchhomeowners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchHomeOwners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchHomeOwners";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchHomeOwners_FormClosed);
            this.pnlsearchhomeowners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearhomeowners)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsearchhomeowners;
        private System.Windows.Forms.DataGridView dgvsearhomeowners;
        private System.Windows.Forms.Button btnsearchhomeownerprevious;
        private System.Windows.Forms.Label lblowneridsearch;
        private System.Windows.Forms.TextBox txtowneridsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnhomeownersearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupassion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}