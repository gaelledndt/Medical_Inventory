namespace MedicalInventory
{
    partial class RolesWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.rolesGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rolesGV);
            this.panel6.Size = new System.Drawing.Size(824, 460);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.roleTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(255, 615);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.roleTxt, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(824, 100);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(824, 515);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(824, 615);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role";
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(58, 182);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(100, 20);
            this.roleTxt.TabIndex = 2;
            // 
            // rolesGV
            // 
            this.rolesGV.AllowUserToAddRows = false;
            this.rolesGV.AllowUserToDeleteRows = false;
            this.rolesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rolesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.roleIdGV,
            this.roleNameGV});
            this.rolesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesGV.Location = new System.Drawing.Point(0, 0);
            this.rolesGV.MultiSelect = false;
            this.rolesGV.Name = "rolesGV";
            this.rolesGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rolesGV.RowHeadersVisible = false;
            this.rolesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesGV.Size = new System.Drawing.Size(824, 460);
            this.rolesGV.TabIndex = 0;
            this.rolesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesGV_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // roleIdGV
            // 
            this.roleIdGV.HeaderText = "Role ID";
            this.roleIdGV.Name = "roleIdGV";
            this.roleIdGV.ReadOnly = true;
            this.roleIdGV.Visible = false;
            // 
            // roleNameGV
            // 
            this.roleNameGV.HeaderText = "Role";
            this.roleNameGV.Name = "roleNameGV";
            this.roleNameGV.ReadOnly = true;
            // 
            // RolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 615);
            this.Name = "RolesWindow";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesWindow_Load);
            this.panel6.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView rolesGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameGV;
    }
}