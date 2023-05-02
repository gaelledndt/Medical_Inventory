using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;


namespace MedicalInventory.Windows.Accounts
{
    public partial class AccountsTypeWindow : Sample2
    {
        public AccountsTypeWindow()
        {
            InitializeComponent();
            showData();
            accountTypeGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountTypeGV.MultiSelect = false;
            accountTypeGV.CellClick += accountTypeGV_CellClick;

        }

        int accountTypeID = 0;

        private void AccountsTypeWindow_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                ListBox listBox = new ListBox();
                listBox.Items.Add(accountTypeIDGV);
                listBox.Items.Add(accountNameGV);
                listBox.Items.Add(statusGV);
                crud.loadData("st_getAccountType", hashtable, listBox, accountTypeGV);

            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (edit == 0) // SAVE
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("@name", nameTxt.Text);

                if (statusDD.SelectedItem.ToString() == "Active")
                {
                    hashtable.Add("@status", 1);
                }
                else if (statusDD.SelectedItem.ToString() == "Inactif")
                {
                    hashtable.Add("@status", 0);
                }


                hashtable.Add("@id", 0);
                hashtable.Add("@flag", 1);
                int x = crud.insert_update_delete("crud_accountType", hashtable);
                if (x > 0)
                {
                    mainClass.ShowMSG(nameTxt.Text + " ajouter avec succès au système", "success");
                }
                else
                {
                    mainClass.ShowMSG("Impossible d'ajouter au système" + nameTxt.Text, "error");
                }
                mainClass.reset_disable(leftPanel);
                showData();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {

            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Informations obligatoires manquantes", "error");
            }
            else
            {
                if (edit == 0) // SAVE
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@name", nameTxt.Text);

                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        hashtable.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactif")
                    {
                        hashtable.Add("@status", 0);
                    }


                    hashtable.Add("@id", 0);
                    hashtable.Add("@flag", 1);
                    int x = crud.insert_update_delete("crud_accountType", hashtable);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " ajouter avec succès au système", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible d'ajouter au système" + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                    showData();
                }
                else if (edit == 1) //UPDATE
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@name", nameTxt.Text);

                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        hashtable.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactif")
                    {
                        hashtable.Add("@status", 0);
                    }


                    hashtable.Add("@id", accountTypeID);
                    hashtable.Add("@flag", 2);
                    int x = crud.insert_update_delete("crud_accountType", hashtable);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " mise à jour avec succès au système", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible de mettre à jour au système" + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                    showData();
                }
            }
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (accountTypeGV.SelectedRows.Count > 0)
            {
                edit = 1;
                DataGridViewRow row = accountTypeGV.SelectedRows[0];
                accountTypeID = Convert.ToInt32(row.Cells["accountTypeIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["accountNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
            }
            else
            {
                mainClass.ShowMSG("Veuillez sélectionner une ligne à modifier", "error");
            }
        }


        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer " + nameTxt.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@name", nameTxt.Text);

                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        hashtable.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactif")
                    {
                        hashtable.Add("@status", 0);
                    }


                    hashtable.Add("@id", accountTypeID);
                    hashtable.Add("@flag", 3);
                    int x = crud.insert_update_delete("crud_accountType", hashtable);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " supprimé avec succès au système", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible de supprimer du système" + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                }

            }
            else
            {
                mainClass.ShowMSG("Merci de sélectionné une ligne pour pouvoir la supprimé", "error");
                showData();
                mainClass.reset_disable(leftPanel);
            }
        }

        private void accountTypeGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = accountTypeGV.Rows[e.RowIndex];
                accountTypeID = Convert.ToInt32(row.Cells["accountTypeIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["accountNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
            }
        }


        private void accountTypeGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                accountTypeGV.Rows[e.RowIndex].Selected = true;
                edit = 1;
                DataGridViewRow row = accountTypeGV.Rows[e.RowIndex];
                accountTypeID = Convert.ToInt32(row.Cells["accountTypeIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["accountNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
            }
        }



        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.BackColor = Color.Red;

            }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)
            {
                statusDD.BackColor = Color.Red;

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}