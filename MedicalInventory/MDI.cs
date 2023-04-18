using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInventory
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

       // string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\connect.txt";
        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\inventory_connect";
            if (File.Exists(path))
            {
                Login lo = new Login();
                mainClass.openWin(lo, MDI.ActiveForm);
            }
            else
            {
                SettingsWindow se = new SettingsWindow();
                mainClass.openWin(se, MDI.ActiveForm);

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow se = new SettingsWindow();
            mainClass.openWin(se, MDI.ActiveForm);

        }

        private void déconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            mainClass.openWin(login, MDI.ActiveForm);
        }

        private void changementDeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            mainClass.openWin(login, MDI.ActiveForm);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
