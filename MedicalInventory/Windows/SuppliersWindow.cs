using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInventory
{
    public partial class Fournisseurs : Sample2
    {
        public Fournisseurs()
        {
            InitializeComponent();
        }

        /*Initialisation de l'id*/
        int supplierID = 0;

        /* Show Data */
        private void showData()
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                ListBox listBox = new ListBox();
                listBox.Items.Add(supplierIdGV);
                listBox.Items.Add(nameGV);
                listBox.Items.Add(phoneGV);
                listBox.Items.Add(addressGV);
                listBox.Items.Add(emailGV);
                listBox.Items.Add(statusGV);
                crud.loadData("st_getSuppliers", hashtable, listBox, supplierGV);
            }
            catch(Exception ex) {
                mainClass.ShowMSG(ex.Message, "error");
            }

        }
        /* Show Data pour la barre de recherche*/
        private void showData(string data)
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("@data",data);
                ListBox listBox = new ListBox();
                listBox.Items.Add(supplierIdGV);
                listBox.Items.Add(nameGV);
                listBox.Items.Add(phoneGV);
                listBox.Items.Add(addressGV);
                listBox.Items.Add(emailGV);
                listBox.Items.Add(statusGV);
                crud.loadData("st_searchSupplier", hashtable, listBox, supplierGV);
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }

        }
        /* BOUTON - Ajouter */
        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (edit == 0) // SAVE
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@name", nameTxt.Text);
                        hashtable.Add("@phone", phoneTxt.Text);
                        hashtable.Add("@address", addressTxt.Text);
                        hashtable.Add("@email", emailTxt.Text);
                        //Status
                        if (statusDD.SelectedItem.ToString() == "Active")
                        {
                            hashtable.Add("@status", 1);
                        }
                        else if (statusDD.SelectedItem.ToString() == "Inactive")
                        {
                            hashtable.Add("@status", 0);
                        }
                        int x = crud.insert_update_delete("st_insertSuppliers", hashtable);
                        if (x > 0)
                        {
                            mainClass.ShowMSG(nameTxt.Text + " a été ajouté avec succès au système", "success");
                        }
                        else
                        {
                            mainClass.ShowMSG("Impossible d'ajouter " + nameTxt.Text + " au système", "error");
                        }
                        showData();
                        mainClass.reset_disable(leftPanel);
                    }
            edit = 0;
        
        }

        /* BOUTON - Sauvegarder */
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Informations obligatoires manquantes", "error");
            }
            else
            {
                try
                {
                    // SAVE
                    if (edit == 0)
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@name", nameTxt.Text);
                        hashtable.Add("@phone", phoneTxt.Text);
                        hashtable.Add("@address", addressTxt.Text);
                        hashtable.Add("@email", emailTxt.Text);

                        //Status
                        if (statusDD.SelectedItem.ToString() == "Active")
                        {
                            hashtable.Add("@status", 1);
                        }

                        else if (statusDD.SelectedItem.ToString() == "Inactive")
                        {
                            hashtable.Add("@status", 0);
                        }

                        // CRUD - INSERT SUPPLIERS
                       
                        int x = crud.insert_update_delete("st_insertSuppliers", hashtable);

                        if (x > 0)
                        {
                            mainClass.ShowMSG(nameTxt.Text + " a été ajouté avec succès au système", "success");
                        }
                        else
                        {
                            mainClass.ShowMSG("Impossible d'ajouter " + nameTxt.Text + " au système", "error");
                        }
                        showData();
                        mainClass.reset_disable(leftPanel);
                    }

                    // UPDATE
                    else if (edit == 1)
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@name", nameTxt.Text);
                        hashtable.Add("@phone", phoneTxt.Text);
                        hashtable.Add("@address", addressTxt.Text);
                        hashtable.Add("@email", emailTxt.Text);
                        //Status
                        if (statusDD.SelectedItem.ToString() == "Active")
                        {
                            hashtable.Add("@status", 1);
                        }
                        else if (statusDD.SelectedItem.ToString() == "Inactive")
                        {
                            hashtable.Add("@status", 0);
                        }



                        hashtable.Add("@id", supplierID);

                        // CRUD - UPDATE SUPPLIERS
                        int x = crud.insert_update_delete("st_updateSuppliers", hashtable);
                        if (x > 0)
                        {
                            mainClass.ShowMSG(nameTxt.Text + " a été mis à jour avec succès au système", "success");
                        }
                        else
                        {
                            mainClass.ShowMSG("Impossible de mettre à jour " + nameTxt.Text + " au système", "error");
                        }
                        showData();
                        mainClass.reset_disable(leftPanel);
                        edit = 0;
                    }
                
               }
                catch (Exception ex)
                {
                    mainClass.ShowMSG(ex.Message, "error");
                }

            }
        }

        /* BOUTON - Supprimer */
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if( edit == 1)
            {
                DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimé " + nameTxt.Text + " ?" , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@id", supplierID);
                    int x = crud.insert_update_delete("st_deleteSuppliers", hashtable);

                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " a été supprimé avec succès au système", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible de supprimé " + nameTxt.Text + " au système", "error");
                    }
                    showData();
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


        /* Panneau d'affichage du crud */
        private void supplierGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex != -1  && e.ColumnIndex != -1 )
            {
                edit = 1;
                DataGridViewRow row = supplierGV.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["supplierIdGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["emailGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                mainClass.disable(leftPanel);
            }
        }

        /* Fenêtre */
        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            showData();
        }


        /* Barre de recherche */
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                showData(searchTxt.Text);
            }
            else
            {
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
                nameTxt.BackColor = Color.Red;

            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text == "")
            {
                nameTxt.BackColor = Color.Red;

            }

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "")
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
