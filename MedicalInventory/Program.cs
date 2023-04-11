using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInventory
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
        }
    }
}
//Data Source=LAPTOP-GAELLEDN;Initial Catalog=inventoryDB;Integrated Security=true;MultipleActiveResultSets=true;
//Data Source=LAPTOP-GAELLEDN;Initial Catalog=inventoryDB;User ID=sa;Password=12345;MultipleActiveResultSets=true; 
//Data Source=LAPTOP-GAELLEDN;Initial Catalog=inventoryDB;Integrated Security=True;MultipleActiveResultSets=true;