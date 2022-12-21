
namespace WindowsFormsAppProject1
{
    partial class ShowUtilityBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUtilityBills));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvutilitybills = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnshowutility = new System.Windows.Forms.Button();
            this.btnutilitybillshowback = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GasBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaterBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Securitycharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gardenercharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvutilitybills)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvutilitybills);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 278);
            this.panel1.TabIndex = 0;
            // 
            // dgvutilitybills
            // 
            this.dgvutilitybills.AllowUserToAddRows = false;
            this.dgvutilitybills.AllowUserToDeleteRows = false;
            this.dgvutilitybills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvutilitybills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.GasBill,
            this.WaterBill,
            this.CurrentBill,
            this.Securitycharge,
            this.Gardenercharge,
            this.ServiceCharge});
            this.dgvutilitybills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvutilitybills.Location = new System.Drawing.Point(0, 0);
            this.dgvutilitybills.Name = "dgvutilitybills";
            this.dgvutilitybills.ReadOnly = true;
            this.dgvutilitybills.RowHeadersWidth = 51;
            this.dgvutilitybills.RowTemplate.Height = 24;
            this.dgvutilitybills.Size = new System.Drawing.Size(824, 278);
            this.dgvutilitybills.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnutilitybillshowback);
            this.panel2.Controls.Add(this.btnshowutility);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 342);
            this.panel2.TabIndex = 1;
            // 
            // btnshowutility
            // 
            this.btnshowutility.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnshowutility.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowutility.Location = new System.Drawing.Point(685, 292);
            this.btnshowutility.Name = "btnshowutility";
            this.btnshowutility.Size = new System.Drawing.Size(127, 35);
            this.btnshowutility.TabIndex = 0;
            this.btnshowutility.Text = "showinfo>>";
            this.btnshowutility.UseVisualStyleBackColor = false;
            this.btnshowutility.Click += new System.EventHandler(this.btnshowutility_Click);
            // 
            // btnutilitybillshowback
            // 
            this.btnutilitybillshowback.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnutilitybillshowback.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnutilitybillshowback.Location = new System.Drawing.Point(12, 32);
            this.btnutilitybillshowback.Name = "btnutilitybillshowback";
            this.btnutilitybillshowback.Size = new System.Drawing.Size(127, 36);
            this.btnutilitybillshowback.TabIndex = 1;
            this.btnutilitybillshowback.Text = "Back";
            this.btnutilitybillshowback.UseVisualStyleBackColor = false;
            this.btnutilitybillshowback.Click += new System.EventHandler(this.btnutilitybillshowback_Click);
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // GasBill
            // 
            this.GasBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GasBill.DataPropertyName = "GasBill";
            this.GasBill.HeaderText = "Gas Bill";
            this.GasBill.MinimumWidth = 6;
            this.GasBill.Name = "GasBill";
            this.GasBill.ReadOnly = true;
            // 
            // WaterBill
            // 
            this.WaterBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaterBill.DataPropertyName = "WaterBill";
            this.WaterBill.HeaderText = "Water Bill";
            this.WaterBill.MinimumWidth = 6;
            this.WaterBill.Name = "WaterBill";
            this.WaterBill.ReadOnly = true;
            // 
            // CurrentBill
            // 
            this.CurrentBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentBill.DataPropertyName = "CurrentBill";
            this.CurrentBill.HeaderText = "Current Bill";
            this.CurrentBill.MinimumWidth = 6;
            this.CurrentBill.Name = "CurrentBill";
            this.CurrentBill.ReadOnly = true;
            // 
            // Securitycharge
            // 
            this.Securitycharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Securitycharge.DataPropertyName = "Securitycharge";
            this.Securitycharge.HeaderText = "Security charge";
            this.Securitycharge.MinimumWidth = 6;
            this.Securitycharge.Name = "Securitycharge";
            this.Securitycharge.ReadOnly = true;
            // 
            // Gardenercharge
            // 
            this.Gardenercharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gardenercharge.DataPropertyName = "Gardenercharge";
            this.Gardenercharge.HeaderText = "Gardener charge";
            this.Gardenercharge.MinimumWidth = 6;
            this.Gardenercharge.Name = "Gardenercharge";
            this.Gardenercharge.ReadOnly = true;
            // 
            // ServiceCharge
            // 
            this.ServiceCharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceCharge.DataPropertyName = "ServiceCharge";
            this.ServiceCharge.HeaderText = "Service Charge";
            this.ServiceCharge.MinimumWidth = 6;
            this.ServiceCharge.Name = "ServiceCharge";
            this.ServiceCharge.ReadOnly = true;
            // 
            // ShowUtilityBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowUtilityBills";
            this.Text = "ShowUtilityBills";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowUtilityBills_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvutilitybills)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvutilitybills;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnshowutility;
        private System.Windows.Forms.Button btnutilitybillshowback;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn GasBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaterBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Securitycharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gardenercharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCharge;
    }
}