using MainClass;
using Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;


namespace authentification

{
    public class Auth
    {
        public static string employeeName { get; set; }
        public static string employeeRole { get; set; }
        public static int employeeID { get; set; }
        public static int roleID { get; set; }

        public static SqlConnection con = new SqlConnection(settings.connection);
        public static bool getLoginDetails( string username, string password)
        {
            settings.connection = File.ReadAllText(settings.path);
            bool flag=false;

            try
            {
                SqlCommand cmd = new SqlCommand("st_getLoginDetails", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                mainClass.con.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        flag = true;
                        employeeID =  Convert.ToInt32(dataReader[0].ToString());
                        employeeName = dataReader[1].ToString();
                        employeeRole = dataReader[3].ToString();
                        roleID = Convert.ToInt32(dataReader[2].ToString());


                    }
                }
                else
                {
                    flag = false;
                    mainClass.ShowMSG("L'identifiant ou le mot de passe est erroné", "error");
                }

                mainClass.con.Close();
            
            } 
            catch (Exception ex) {
                mainClass.ShowMSG(ex.Message, "error");
            }
            return flag;
        }

    }
}
