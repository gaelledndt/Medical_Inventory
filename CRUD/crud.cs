using System;
using System.Collections;
using System.Data.SqlClient;
using MainClass;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public class crud
    {
        public static int insert_update_delete(string proc, Hashtable hashtable)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(DictionaryEntry item in hashtable) {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
             
                mainClass.con.Open();
                result = cmd.ExecuteNonQuery();
                mainClass.con.Close();

            }
            catch (Exception ex) {
                if (mainClass.con.State == ConnectionState.Open) {
                mainClass.con.Close();
                }
                mainClass.ShowMSG(ex.Message,"error");
                throw;
            }
            return result;
        }

        // For Roles
        public static void loadData (string proc, Hashtable hashtable, ListBox listBox, DataGridView dataGridView)
        {
            try
            {
                SqlCommand cmd = new SqlCommand (proc, mainClass.con);  
                cmd.CommandType= CommandType.StoredProcedure;
                foreach(DictionaryEntry item in hashtable)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(),item.Value);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    string colname = ((DataGridViewColumn)listBox.Items[i]).Name;
                    dataGridView.Columns[colname].DataPropertyName = dataTable.Columns[i].ToString();
                }
                dataGridView.DataSource = dataTable;

            }
            catch (Exception ex) 
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }

        // For Users
        public static void loadList(string proc, Hashtable hashtable, ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in hashtable)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboBox.ValueMember = dataTable.Columns[0].ToString();
                comboBox.DisplayMember = dataTable.Columns[1].ToString();
                comboBox.DataSource = dataTable;
                comboBox.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }
    }
}

