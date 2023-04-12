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
using System.Data.SqlClient;


namespace MedicalInventory
{
    public partial class RolesWindow : Sample2
    {
        public RolesWindow()
        {
            InitializeComponent();
        }

        public void showData()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getRoles", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIdGV.DataPropertyName = dt.Columns[0].ToString();
                roleNameGV.DataPropertyName = dt.Columns[1].ToString();
                rolesGV.DataSource = dt;

            }

            catch (Exception ex) {
                mainClass.ShowMSG(ex.Message, "error") ;
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory","error");
            }
            else
            {
                if (edit == 0)
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@role", roleTxt.Text);
                    int x = crud.insert_update_delete("st_insertRoles", hashtable);

                    if (x > 0)
                    {

                        mainClass.ShowMSG(roleTxt.Text + " added successfully into the system", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + roleTxt.Text + " in the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);

                }
                else if (edit == 1)
                {
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@role", roleTxt.Text);
                    hashtable.Add("@roleID", roleID);
                    int x = crud.insert_update_delete("st_updateRoles", hashtable);

                    if (x > 0)
                    {

                        mainClass.ShowMSG(roleTxt.Text + " updated successfully into the system", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to update " + roleTxt.Text + " in the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }

        }


        private void RolesWindow_Load(object sender, EventArgs e)
        {
            showData();

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
       
        }
        int roleID = 0;
        private void rolesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!= -1)
            {
                edit = 1; 
                DataGridViewRow row = rolesGV.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIdGV"].Value.ToString());
                roleTxt.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
