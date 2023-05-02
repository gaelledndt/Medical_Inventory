using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MedicalInventory
{
    public partial class AccountsWindow : Sample2
    {
        public AccountsWindow()
        {
            InitializeComponent();
            Hashtable hashtable = new Hashtable();
            crud.loadList("st_getAccountType", hashtable, accountTypeDD);
            showData();

        }

        private void AccountsWindow_Load(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            crud.loadList("st_getAccountType", hashtable, accountTypeDD);
            showData();
        }
        /* Show Data */
        private void showData()
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                ListBox listBox = new ListBox();
                listBox.Items.Add(accountIDGV);
                listBox.Items.Add(accountNameGV);
                listBox.Items.Add(accountPhoneGV);
                listBox.Items.Add(accountAddressGV);
                listBox.Items.Add(typeGV);
                listBox.Items.Add(statusGV);
                crud.loadData("st_getAccounts", hashtable, listBox, accountTypeGV);

            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }

        }

        int accountID = 0;
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
                    hashtable.Add("@phone", phoneTxt.Text);
                    hashtable.Add("@address", addressTxt.Text);
                    hashtable.Add("@type", Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
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
                    int x = crud.insert_update_delete("crud_accounts", hashtable);

                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " a été ajouté avec succès au système", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible d'ajouter au système" + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                    showData();
                }
                else if (edit == 1) /// UPDATE
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@name", nameTxt.Text);
                    hashtable.Add("@phone", phoneTxt.Text);
                    hashtable.Add("@address", addressTxt.Text);
                    hashtable.Add("@type", Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        hashtable.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        hashtable.Add("@status", 0);
                    }
                    hashtable.Add("@id", accountID);
                    hashtable.Add("@flag", 2);
                    int x = crud.insert_update_delete("crud_accounts", hashtable);

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

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimé " + nameTxt.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("@name", nameTxt.Text);
                hashtable.Add("@phone", phoneTxt.Text);
                hashtable.Add("@address", addressTxt.Text);
                // hashtable.Add("@type", Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
                if (accountTypeDD.SelectedItem != null)
                {
                    hashtable.Add("@type", Convert.ToInt32(((DataRowView)accountTypeDD.SelectedItem)["ID"].ToString()));
                }
                else
                {
                    mainClass.ShowMSG("Veuillez sélectionner un type de compte.", "error");
                    return;
                }
                if (statusDD.SelectedItem.ToString() == "Active")
                {
                    hashtable.Add("@status", 1);
                }
                else if (statusDD.SelectedItem.ToString() == "Inactive")
                {
                    hashtable.Add("@status", 0);
                }
                hashtable.Add("@id", accountID);
                hashtable.Add("@flag", 3);
                int x = crud.insert_update_delete("crud_accounts", hashtable);

                if (x > 0)
                {
                    mainClass.ShowMSG(nameTxt.Text + " supprimé avec succès au système", "success");
                }
                else
                {
                    mainClass.ShowMSG("Impossible de supprimer du système" + nameTxt.Text, "error");
                }
                mainClass.reset_disable(leftPanel);
                showData();
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.BackColor = Color.Red;

            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.BackColor = Color.Red;

            }

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "")
            {
                addressTxt.BackColor = Color.Red;

            }
        }

        private void accountTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountTypeDD.SelectedIndex == -1)
            {
                accountTypeDD.BackColor = Color.Red;

            }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)
            {
                statusDD.BackColor = Color.Red;

            }
        }

        private void accountGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accountTypeGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = accountTypeGV.Rows[e.RowIndex];
                accountID = Convert.ToInt32(row.Cells["accountIDGV"].Value?.ToString());
                nameTxt.Text = row.Cells["accountNameGV"].Value?.ToString();
                phoneTxt.Text = row.Cells["accountPhoneGV"].Value?.ToString();
                addressTxt.Text = row.Cells["accountAddressGV"].Value?.ToString();
                accountTypeDD.SelectedValue = Convert.ToInt32(row.Cells["accountTypeIDGV"].Value?.ToString());
                statusDD.SelectedItem = row.Cells["statusGV"].Value?.ToString();
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
