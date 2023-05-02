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
                mainClass.ShowMSG("Informations obligatoires manquantes", "error");
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

                        mainClass.ShowMSG(roleTxt.Text + " a été ajouté avec succès au système", "success");
                        Hashtable hashtable1 = new Hashtable();
                        ListBox lb = new ListBox();
                        lb.Items.Add(roleIdGV);
                        lb.Items.Add(roleNameGV);
                        crud.loadData("st_getRoles", hashtable1, lb, rolesGV);

                    }
                    else
                    {
                        mainClass.ShowMSG("Impossibilité d'ajouter " + roleTxt.Text + " au system", "error");
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

                        mainClass.ShowMSG(roleTxt.Text + "a été mit à jour avec succès", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Impossible de mettre à jour " + roleTxt.Text + " au système", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }

        }


        private void RolesWindow_Load(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            ListBox lb = new ListBox();
            lb.Items.Add(roleIdGV);
            lb.Items.Add(roleNameGV);
            crud.loadData("st_getRoles", hashtable, lb, rolesGV);

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
       
            if (edit == 1)
            {
                Hashtable hashtable = new Hashtable();              
                hashtable.Add("@roleID", roleID);
                int x = crud.insert_update_delete("st_deleteRoles", hashtable);

                if (x > 0)
                {

                    mainClass.ShowMSG(roleTxt.Text + " a été supprimé avec succès du système", "success");
                    showData();
                }
                else
                {
                    mainClass.ShowMSG("Impossibilité de mettre à jour " + roleTxt.Text + " dans le système", "success");
                }
                mainClass.reset_disable(leftPanel);
            }
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

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
