using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;
using System.Data;

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
                mainClass.ShowMSG(ex.Message,"error");
                throw;
            }
            return result;
        }
    }
}

