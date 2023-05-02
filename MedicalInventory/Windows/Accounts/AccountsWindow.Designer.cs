namespace MedicalInventory
{
    partial class AccountsWindow
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
            this.accountIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountPhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountAddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accountTypeDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel6.Size = new System.Drawing.Size(854, 414);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(854, 469);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(854, 55);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.accountTypeDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.nameLabel);
            this.leftPanel.Size = new System.Drawing.Size(255, 569);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.accountTypeDD, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(854, 100);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(854, 469);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(854, 569);
            // 
            // accountTypeGV
            // 
            this.accountTypeGV.AllowUserToAddRows = false;
            this.accountTypeGV.AllowUserToDeleteRows = false;
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
            this.accountIDGV,
            this.accountNameGV,
            this.accountPhoneGV,
            this.accountAddressGV,
            this.typeGV,
            this.statusGV,
            this.accountTypeIDGV});
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
            this.accountTypeGV.Size = new System.Drawing.Size(854, 414);
            this.accountTypeGV.TabIndex = 2;
            this.accountTypeGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountGV_CellClick);
            this.accountTypeGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTypeGV_CellDoubleClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // accountIDGV
            // 
            this.accountIDGV.HeaderText = "ID Type Compte";
            this.accountIDGV.Name = "accountIDGV";
            this.accountIDGV.ReadOnly = true;
            this.accountIDGV.Visible = false;
            // 
            // accountNameGV
            // 
            this.accountNameGV.HeaderText = "Nom du compte";
            this.accountNameGV.Name = "accountNameGV";
            this.accountNameGV.ReadOnly = true;
            // 
            // accountPhoneGV
            // 
            this.accountPhoneGV.HeaderText = "Téléphone";
            this.accountPhoneGV.Name = "accountPhoneGV";
            this.accountPhoneGV.ReadOnly = true;
            // 
            // accountAddressGV
            // 
            this.accountAddressGV.HeaderText = "Adresse";
            this.accountAddressGV.Name = "accountAddressGV";
            this.accountAddressGV.ReadOnly = true;
            // 
            // typeGV
            // 
            this.typeGV.HeaderText = "Type de compte";
            this.typeGV.Name = "typeGV";
            this.typeGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Visible = false;
            // 
            // accountTypeIDGV
            // 
            this.accountTypeIDGV.HeaderText = "Account Type ID";
            this.accountTypeIDGV.Name = "accountTypeIDGV";
            this.accountTypeIDGV.ReadOnly = true;
            this.accountTypeIDGV.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nom";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(31, 155);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(190, 20);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(31, 276);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(190, 20);
            this.addressTxt.TabIndex = 4;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(31, 219);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(190, 20);
            this.phoneTxt.TabIndex = 6;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Téléphone";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(31, 380);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(190, 21);
            this.statusDD.TabIndex = 13;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // accountTypeDD
            // 
            this.accountTypeDD.FormattingEnabled = true;
            this.accountTypeDD.Location = new System.Drawing.Point(31, 328);
            this.accountTypeDD.Name = "accountTypeDD";
            this.accountTypeDD.Size = new System.Drawing.Size(190, 21);
            this.accountTypeDD.TabIndex = 15;
            this.accountTypeDD.SelectedIndexChanged += new System.EventHandler(this.accountTypeDD_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type de compte";
            // 
            // AccountsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 569);
            this.Name = "AccountsWindow";
            this.Text = "Type de compte";
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
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox accountTypeDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountPhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountAddressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIDGV;
    }
}