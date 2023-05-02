namespace MedicalInventory.Windows.Accounts
{
    partial class AccountsTypeWindow
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
            this.accountTypeGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.accountTypeGV);
            this.panel6.Size = new System.Drawing.Size(954, 438);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(182, 20);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(954, 493);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(954, 55);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(255, 593);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(954, 100);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(954, 493);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(954, 593);
            // 
            // accountTypeGV
            // 
            this.accountTypeGV.AllowUserToAddRows = false;
            this.accountTypeGV.AllowUserToDeleteRows = false;
            this.accountTypeGV.AllowUserToOrderColumns = true;
            this.accountTypeGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTypeGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.accountTypeGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.accountTypeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTypeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.accountTypeIDGV,
            this.accountNameGV,
            this.statusGV});
            this.accountTypeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTypeGV.Location = new System.Drawing.Point(0, 0);
            this.accountTypeGV.Name = "accountTypeGV";
            this.accountTypeGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.accountTypeGV.RowHeadersVisible = false;
            this.accountTypeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountTypeGV.Size = new System.Drawing.Size(954, 438);
            this.accountTypeGV.TabIndex = 3;
            this.accountTypeGV.VirtualMode = true;
            this.accountTypeGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTypeGV_CellClick);
            this.accountTypeGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTypeGV_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // accountTypeIDGV
            // 
            this.accountTypeIDGV.HeaderText = "ID Type Compte";
            this.accountTypeIDGV.Name = "accountTypeIDGV";
            this.accountTypeIDGV.ReadOnly = true;
            this.accountTypeIDGV.Visible = false;
            // 
            // accountNameGV
            // 
            this.accountNameGV.HeaderText = "Nom du compte";
            this.accountNameGV.Name = "accountNameGV";
            this.accountNameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom du type de compte";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactif"});
            this.statusDD.Location = new System.Drawing.Point(39, 223);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(190, 21);
            this.statusDD.TabIndex = 15;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(39, 159);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(190, 20);
            this.nameTxt.TabIndex = 16;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // AccountsTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 593);
            this.Name = "AccountsTypeWindow";
            this.Text = "AccountTypeWindow";
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountTypeGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}