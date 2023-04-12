using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD;
using System.Collections;

namespace MedicalInventory
{
    public partial class RolesWindow : Sample2
    {
        public RolesWindow()
        {
            InitializeComponent();
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory","error");
            }
            else
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("@role", roleTxt.Text);
                int x = crud.insert_update_delete("st_insertRoles", hashtable);

                if(x > 0) {

                    mainClass.ShowMSG(roleTxt.Text + " added successfully into the system", "success");
                }
                else
                {
                    mainClass.ShowMSG("Unable to add " + roleTxt.Text + " in the system", "success");
                }
                mainClass.reset_disable(leftPanel);
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
       
        }

        private void rolesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
