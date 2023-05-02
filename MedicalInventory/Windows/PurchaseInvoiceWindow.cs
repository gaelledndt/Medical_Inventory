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
            purchaseInvoiceDetailsGV.VirtualMode = false;

        }




        private void PurchaseInvoiceWindow_Load(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@type", "Supplier");
            crud.loadList("st_getAccountByType", hashtable, supplierDD);
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
                // crud.loadData("", hashtable, listBox,);

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

        }

        public override void saveBtn_Click(object sender, EventArgs e)
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

        // Selection d'un fournisseur
        private void supplierDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierDD.SelectedIndex == -1)
            {
                supplierDD.BackColor = Color.Red;
            }
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {

            if (quantityTxt.Text == "")
            {
                quantityTxt.BackColor = Color.Red;

            }
        }

        private void invoiceTxt_TextChanged(object sender, EventArgs e)
        {
            if (invoiceTxt.Text == "")
            {
                invoiceTxt.BackColor = Color.Red;

            }

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void expiryPicker_ValueChanged(object sender, EventArgs e)
        {
            if (expiryPicker.Value < DateTime.Today)
            {
                mainClass.ShowMSG("La date que vous avez saisie n'est pas valide", "error");
            }
        }



        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTxt.Text == "")
            {
                barcodeTxt.BackColor = Color.Red;

            }
        }

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (productNameTxt.Text == "")
            {
                productNameTxt.BackColor = Color.Red;

            }
        }
        private void barcodeTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productNameTxt.Focus();
            }

        }

        double grandTotal = 0;

        private void addToCartBtn_Click_1(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(quantityTxt.Text) * Convert.ToDouble(priceTxt.Text);
            grandTotal += total;
            purchaseInvoiceDetailsGV.Rows.Add("", productNameTxt.Text, barcodeTxt.Text, quantityTxt.Text, priceTxt.Text, expiryPicker.Value.ToShortDateString(), String.Format("{0:N2}", total));
            grandLabel.Text = String.Format("{0:N2}", grandTotal);
        }


        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if (priceTxt.Text == "")
            {
                priceTxt.BackColor = Color.Red;

            }
        }

        private void purchaseInvoiceDetailsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 7)
                {
                    DataGridViewRow row = purchaseInvoiceDetailsGV.Rows[e.RowIndex];
                    double d = Convert.ToDouble(row.Cells[6].Value.ToString());
                    grandTotal -= d;
                    grandLabel.Text = String.Format("{0:N2}", grandTotal);
                    purchaseInvoiceDetailsGV.Rows.Remove(row);
                }
            }
        }

        /*      private void addToCartBtn_Click_1(object sender, EventArgs e)
              {
                  double total = Convert.ToDouble(quantityTxt.Text) * Convert.ToDouble(priceTxt.Text);
                  purchaseInvoiceDetailsGV.Rows.Add("", productNameTxt.Text, barcodeTxt.Text, quantityTxt.Text, priceTxt.Text, expiryPicker.Value.ToString(), String.Format("{0:N2}", total));
                  grandLabel.Text = String.Format("{0:N2}", grandTotal);

              }*/
    }
}
