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

namespace MedicalInventory
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            RolesWindow roleWindow = new RolesWindow();
            mainClass.openWin(roleWindow, MDI.ActiveForm, this);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Utilisateurs userWindow = new Utilisateurs();
            mainClass.openWin(userWindow, MDI.ActiveForm, this);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Fournisseurs suppliersWindow = new Fournisseurs();
            mainClass.openWin(suppliersWindow, MDI.ActiveForm, this);
        }
    }
}
