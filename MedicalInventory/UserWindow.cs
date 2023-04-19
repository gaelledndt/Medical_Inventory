using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInventory
{
    public partial class Utilisateurs : Sample2
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }

        int userID = 0;

        private void showData()
        {
            Hashtable hashtable2 = new Hashtable();
            ListBox listBox = new ListBox();
            listBox.Items.Add(userIDGV);
            listBox.Items.Add(nameGV);
            listBox.Items.Add(usernameGV);
            listBox.Items.Add(passwordGV);
            listBox.Items.Add(phoneGV);
            listBox.Items.Add(emailGV);
            listBox.Items.Add(statusGV);
            listBox.Items.Add(roleIDGV);
            listBox.Items.Add(roleGV);

            crud.loadData("st_getUsers", hashtable2, listBox, usersGV);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@name", nameTxt.Text);
            ht.Add("@username", usernameTxt.Text);
            ht.Add("@password", passwordTxt.Text);
            ht.Add("@phone", phoneTxt.Text);
            ht.Add("@email", emailTxt.Text);

            if (statusDD.SelectedIndex == 0)
            {
                ht.Add("@status", 1);
            }
            else if (statusDD.SelectedIndex == 1)
            {
                ht.Add("@status", 0);
            }

            ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));

            int x = crud.insert_update_delete("st_insertUser", ht);

            if (x > 0)
            {
                mainClass.ShowMSG(nameTxt.Text + " added successfully", "success");
            }
            else
            {
                mainClass.ShowMSG("Unable to add " + nameTxt.Text, "error");
            }

        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {

            if(mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with Red are mandatory", "error");
            }
            else
            {
                if (edit == 0) //  Save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@username", usernameTxt.Text);
                    ht.Add("@password", passwordTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@email", emailTxt.Text);

                    if (statusDD.SelectedIndex == 0)
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        ht.Add("@status", 0);
                    }

                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));

                    int x = crud.insert_update_delete("st_insertUser", ht);

                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " added successfully", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + nameTxt.Text, "error");
                    }
                }

                else if (edit == 1) {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@username", usernameTxt.Text);
                    ht.Add("@password", passwordTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@email", emailTxt.Text);

                    if (statusDD.SelectedIndex == 0)
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        ht.Add("@status", 0);
                    }

                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));
                    ht.Add("@ID", userID);

                    int x = crud.insert_update_delete("st_updateUser", ht);

                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " updated successfully", "success");
                        showData();
                        
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to updated " + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

            if (edit == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous réellement supprimer ?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@ID", userID);
                    int x = crud.insert_update_delete("st_deleteUser", hashtable);

                    if (x > 0)
                    {

                        mainClass.ShowMSG(nameTxt.Text + " delete successfully into the system", "success");
                        showData();

                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to delete " + nameTxt.Text + " in the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.BackColor = Color.Red;

            }
            else
            {
                //nameTxt.BackColor = Color.Black;
            }
            
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameTxt.BackColor = Color.Red;

            }
            else
            {
               // usernameTxt.BackColor = Color.Black;
            }

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passwordTxt.BackColor = Color.Red;

            }
            else
            {
                //passwordTxt.BackColor = Color.Black;
            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.BackColor = Color.Red;

            }
            else
            {
                //phoneTxt.Font = Color.Black;
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt .Text == "")
            {
                phoneTxt.BackColor = Color.Red;

            }
            else
            {
               // phoneTxt.BackColor = Color.Black;
            }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1)
            {
                roleDD.BackColor = Color.Red;

            }
            else
            {
                //roleDD.BackColor = Color.Black;
            }

        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)
            {
                statusDD.BackColor = Color.Red;

            }
            else
            {
                //statusDD .BackColor = Color.Black;
            }
        }

        private void rolesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = usersGV.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["passwordGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["emailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                roleDD.SelectedValue = Convert.ToUInt32(row.Cells["roleIDGV"].Value.ToString());

            }
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            crud.loadList("st_getRoles",hashtable, roleDD);
            showData();

        }
    }
}