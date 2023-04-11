using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public class settings
    {
        // Connection string property
        public static string connection = "";

        // Path to save the connection string file
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\inventory_connect";

        // Method to save connection string to a file
        public static void saveFile(string server, string database, string username=null, string password=null)
        {
            // If username is null, create a connection string with integrated security
            if (username == null)
            {
                connection = "Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=True;";
            }
            else
            {
                // If username is provided, create a connection string with the provided username and password
                //connection = "Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + username + ";Password=" + password + ";MultipleActiveResultSets=true;";
                connection = "Data Source=LAPTOP-GAELLEDN;Initial Catalog=inventoryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true;";
            }

            // Write the connection string to the file at the specified path
            File.WriteAllText(path, connection);
        }
    }
}
