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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public static int edit = 0;

        private void Sample2_Load(object sender, EventArgs e)
        {

        }

        public virtual void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            mainClass.openWin(homeScreen, MDI.ActiveForm, this);
        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            mainClass.reset_disable(leftPanel);
        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            mainClass.enable(leftPanel);
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
