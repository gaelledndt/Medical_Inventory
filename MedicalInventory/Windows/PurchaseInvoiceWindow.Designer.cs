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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalAmountTxt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.grandLabel = new System.Windows.Forms.Label();
            this.purchaseInvoiceDetailsGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Fournisseur = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceDetailsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.purchaseInvoiceDetailsGV);
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
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.supplierDD);
            this.leftPanel.Controls.Add(this.datePicker);
            this.leftPanel.Controls.Add(this.invoiceTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.Fournisseur);
            this.leftPanel.Controls.Add(this.addToCartBtn);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.totalAmountTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.expiryPicker);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.productNameTxt);
            this.leftPanel.Size = new System.Drawing.Size(255, 619);
            this.leftPanel.Controls.SetChildIndex(this.productNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalAmountTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.addToCartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.Fournisseur, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.invoiceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.datePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
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
            // totalAmountTxt
            // 
            this.totalAmountTxt.Location = new System.Drawing.Point(0, 0);
            this.totalAmountTxt.Name = "totalAmountTxt";
            this.totalAmountTxt.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTxt.TabIndex = 19;
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
            this.tableLayoutPanel2.Controls.Add(this.grandLabel, 1, 0);
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
            // grandLabel
            // 
            this.grandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandLabel.Location = new System.Drawing.Point(745, 0);
            this.grandLabel.Name = "grandLabel";
            this.grandLabel.Size = new System.Drawing.Size(264, 96);
            this.grandLabel.TabIndex = 1;
            this.grandLabel.Text = "0.00";
            this.grandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // purchaseInvoiceDetailsGV
            // 
            this.purchaseInvoiceDetailsGV.AllowUserToAddRows = false;
            this.purchaseInvoiceDetailsGV.AllowUserToDeleteRows = false;
            this.purchaseInvoiceDetailsGV.AllowUserToOrderColumns = true;
            this.purchaseInvoiceDetailsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseInvoiceDetailsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.purchaseInvoiceDetailsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseInvoiceDetailsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseInvoiceDetailsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseInvoiceDetailsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.productNameGV,
            this.barcodeGV,
            this.quantityGV,
            this.priceGV,
            this.expiryGV,
            this.totalAmountGV,
            this.removeGV});
            this.purchaseInvoiceDetailsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvoiceDetailsGV.Location = new System.Drawing.Point(0, 0);
            this.purchaseInvoiceDetailsGV.Name = "purchaseInvoiceDetailsGV";
            this.purchaseInvoiceDetailsGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseInvoiceDetailsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.purchaseInvoiceDetailsGV.RowHeadersVisible = false;
            this.purchaseInvoiceDetailsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseInvoiceDetailsGV.Size = new System.Drawing.Size(1016, 364);
            this.purchaseInvoiceDetailsGV.TabIndex = 4;
            this.purchaseInvoiceDetailsGV.VirtualMode = true;
            this.purchaseInvoiceDetailsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseInvoiceDetailsGV_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
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
            // priceGV
            // 
            this.priceGV.HeaderText = "Prix";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            dataGridViewCellStyle2.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.expiryGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.expiryGV.HeaderText = "Date d\'expiration";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.totalAmountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalAmountGV.HeaderText = "Montant Total";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
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
            // addToCartBtn
            // 
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addToCartBtn.Location = new System.Drawing.Point(32, 540);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(186, 23);
            this.addToCartBtn.TabIndex = 30;
            this.addToCartBtn.Text = "Ajouter au panier";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Prix";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(21, 501);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(197, 20);
            this.priceTxt.TabIndex = 29;
            this.priceTxt.Text = "40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Code barre";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(15, 296);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(197, 20);
            this.barcodeTxt.TabIndex = 25;
            this.barcodeTxt.Text = "758604850";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nom du produit";
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(18, 450);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(200, 20);
            this.expiryPicker.TabIndex = 27;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(18, 347);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(197, 20);
            this.productNameTxt.TabIndex = 21;
            this.productNameTxt.Text = "KitKat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date d\'expiration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantité";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(18, 398);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(197, 20);
            this.quantityTxt.TabIndex = 23;
            this.quantityTxt.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Date";
            // 
            // supplierDD
            // 
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(15, 195);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(197, 21);
            this.supplierDD.TabIndex = 33;
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.CustomFormat = "dd-MMM-yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(15, 155);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 31;
            // 
            // invoiceTxt
            // 
            this.invoiceTxt.Location = new System.Drawing.Point(15, 240);
            this.invoiceTxt.Name = "invoiceTxt";
            this.invoiceTxt.Size = new System.Drawing.Size(197, 20);
            this.invoiceTxt.TabIndex = 35;
            this.invoiceTxt.Text = "12345";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Facture #";
            // 
            // Fournisseur
            // 
            this.Fournisseur.AutoSize = true;
            this.Fournisseur.Location = new System.Drawing.Point(12, 179);
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.Size = new System.Drawing.Size(61, 13);
            this.Fournisseur.TabIndex = 32;
            this.Fournisseur.Text = "Fournisseur";
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
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceDetailsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox totalAmountTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView purchaseInvoiceDetailsGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label grandLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox invoiceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Fournisseur;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn removeGV;
    }
}