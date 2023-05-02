namespace MedicalInventory.Windows
{
    partial class PurchaseInvoiceWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Date = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Fournisseur = new System.Windows.Forms.Label();
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.invoiceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.totalAmountText = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.accountTypeGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.accountTypeGV);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Size = new System.Drawing.Size(1016, 464);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(159, 20);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1016, 519);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1016, 55);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox3);
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.totalAmountTxt);
            this.leftPanel.Size = new System.Drawing.Size(255, 619);
            this.leftPanel.Controls.SetChildIndex(this.totalAmountTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox3, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1016, 100);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1016, 519);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1016, 619);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(6, -26);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd-MMM-yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(9, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Fournisseur
            // 
            this.Fournisseur.AutoSize = true;
            this.Fournisseur.Location = new System.Drawing.Point(6, 56);
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.Size = new System.Drawing.Size(61, 13);
            this.Fournisseur.TabIndex = 3;
            this.Fournisseur.Text = "Fournisseur";
            this.Fournisseur.Click += new System.EventHandler(this.Fournisseur_Click);
            // 
            // supplierDD
            // 
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(9, 72);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(197, 21);
            this.supplierDD.TabIndex = 4;
            this.supplierDD.SelectedIndexChanged += new System.EventHandler(this.supplierDD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Facture #";
            // 
            // totalAmountTxt
            // 
            this.totalAmountTxt.Location = new System.Drawing.Point(0, 0);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTxt.TabIndex = 19;
            // 
            // invoiceTxt
            // 
            this.invoiceTxt.Location = new System.Drawing.Point(9, 117);
            this.invoiceTxt.Name = "invoiceTxt";
            this.invoiceTxt.Size = new System.Drawing.Size(197, 20);
            this.invoiceTxt.TabIndex = 8;
            this.invoiceTxt.TextChanged += new System.EventHandler(this.invoiceTxt_TextChanged);
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(3, 93);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(197, 20);
            this.productNameTxt.TabIndex = 10;
            this.productNameTxt.TextChanged += new System.EventHandler(this.productNameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom du produit";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(3, 144);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(197, 20);
            this.quantityTxt.TabIndex = 12;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantité";
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(3, 196);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(200, 20);
            this.expiryPicker.TabIndex = 16;
            this.expiryPicker.ValueChanged += new System.EventHandler(this.expiryPicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date d\'expiration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code barre";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(0, 42);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(197, 20);
            this.barcodeTxt.TabIndex = 14;
            this.barcodeTxt.TextChanged += new System.EventHandler(this.barcodeTxt_TextChanged);
            this.barcodeTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.barcodeTxt_PreviewKeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.supplierDD);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.invoiceTxt);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Fournisseur);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(9, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 152);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Facture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addToCartBtn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.totalAmountText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.barcodeTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.expiryPicker);
            this.groupBox3.Controls.Add(this.productNameTxt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.quantityTxt);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(9, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 325);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details Produits";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addToCartBtn.Location = new System.Drawing.Point(17, 286);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(186, 23);
            this.addToCartBtn.TabIndex = 19;
            this.addToCartBtn.Text = "Ajouter au panier";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Montant Total";
            // 
            // totalAmountText
            // 
            this.totalAmountText.Location = new System.Drawing.Point(6, 247);
            this.totalAmountText.Name = "totalAmountText";
            this.totalAmountText.Size = new System.Drawing.Size(197, 20);
            this.totalAmountText.TabIndex = 18;
            this.totalAmountText.TextChanged += new System.EventHandler(this.totalAmountText_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.tableLayoutPanel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 364);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1016, 100);
            this.panel7.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.32016F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.67984F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 96);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(736, 96);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(745, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 96);
            this.label11.TabIndex = 1;
            this.label11.Text = "0.00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountTypeGV
            // 
            this.accountTypeGV.AllowUserToAddRows = false;
            this.accountTypeGV.AllowUserToDeleteRows = false;
            this.accountTypeGV.AllowUserToOrderColumns = true;
            this.accountTypeGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTypeGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.accountTypeGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.accountTypeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTypeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.removeGV,
            this.productNameGV,
            this.barcodeGV,
            this.quantityGV,
            this.expiryGV,
            this.totalAmountGV});
            this.accountTypeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTypeGV.Location = new System.Drawing.Point(0, 0);
            this.accountTypeGV.Name = "accountTypeGV";
            this.accountTypeGV.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.accountTypeGV.RowHeadersVisible = false;
            this.accountTypeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountTypeGV.Size = new System.Drawing.Size(1016, 364);
            this.accountTypeGV.TabIndex = 4;
            this.accountTypeGV.VirtualMode = true;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // removeGV
            // 
            this.removeGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeGV.HeaderText = "Action";
            this.removeGV.Name = "removeGV";
            this.removeGV.ReadOnly = true;
            this.removeGV.Text = "Suppression";
            this.removeGV.UseColumnTextForButtonValue = true;
            // 
            // productNameGV
            // 
            this.productNameGV.HeaderText = "Nom produit";
            this.productNameGV.Name = "productNameGV";
            this.productNameGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Code barre";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantité";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Date d\'expiration";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.totalAmountGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalAmountGV.HeaderText = "Montant Total";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // PurchaseInvoiceWindow
            // 
            this.AcceptButton = this.addToCartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 619);
            this.Name = "PurchaseInvoiceWindow";
            this.Text = "Facture d\'achat";
            this.Load += new System.EventHandler(this.PurchaseInvoiceWindow_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox invoiceTxt;
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.Label Fournisseur;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalAmountText;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView accountTypeGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewButtonColumn removeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
    }
}