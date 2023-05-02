using CRUD;
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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MedicalInventory.Windows
{
    public partial class PurchaseInvoiceWindow : Sample2
    {
        public PurchaseInvoiceWindow()
        {
            InitializeComponent();
        }




        private void PurchaseInvoiceWindow_Load(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@type", "Supplier");
            crud.loadList("st_getAccountByType",hashtable, supplierDD);
        }

        int accountTypeID = 0;

        private void AccountsTypeWindow_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                ListBox listBox = new ListBox();
                crud.loadData("", hashtable, listBox,);

            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (edit == 0) // SAVE
            {
                Hashtable hashtable = new Hashtable();
            }
            else if (edit == 1)
            {
                Hashtable hashtable = new Hashtable();
            }
        }
           

        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (edit == 0) // SAVE
            {
                Hashtable hashtable = new Hashtable();
            }
            else if (edit == 1)
            {
                Hashtable hashtable = new Hashtable();
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void invoiceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void expiryPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalAmountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fournisseur_Click(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productNameTxt.Focus();
            }
          
        }
    }
}
