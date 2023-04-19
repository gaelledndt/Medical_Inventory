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
    public partial class Fournisseurs : Sample2
    {
        public Fournisseurs()
        {
            InitializeComponent();
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

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fileds with Red are mandatory", "error");
            }
            else
            {
                if(edit == 0) // SAVE
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@name", nameTxt.Text);
                    hashtable.Add("@phone",phoneTxt.Text);
                    hashtable.Add("@address",addressTxt.Text);
                    hashtable.Add("@email",emailTxt.Text);
                    //Status
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        hashtable.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        hashtable.Add("@status", 0);
                    }
                }
                else if (edit == 1)// UPDATE
                {

                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
