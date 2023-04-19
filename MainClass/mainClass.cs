using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.SqlClient;
using Settings;
using System.IO;

namespace MainClass
{
    public class mainClass
    {
        public static SqlConnection con = new SqlConnection(File.ReadAllText(settings.path));
        public static void enable(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                // Texbox Reset
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                // ComboBox Reset
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                // RadioButton Reset
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                // CheckBox Reset
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                // DateTimePicker Reset
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                }
            }
        }

        public static void disable(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                // Texbox Reset
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                // ComboBox Reset
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                // RadioButton Reset
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                // CheckBox Reset
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                // DateTimePicker Reset
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Today;
                    dt.Enabled = false;
                }
            }
        }

        public static void ShowMSG(string  msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void reset_enable(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                // Texbox Reset
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }
                // ComboBox Reset
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                // RadioButton Reset
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                    rb.BackColor = Color.White;
                }
                // CheckBox Reset
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                // DateTimePicker Reset
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false;
                    dt.BackColor = Color.White;
                }
            }
        }

        public static void reset_disable(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                // Texbox Reset
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }
                // ComboBox Reset
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                // RadioButton Reset
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;

                }
                // CheckBox Reset
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                }
                // DateTimePicker Reset
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false;
                }
            }
        }

        public static void openWin(Form openWin, Form MDI, Form closeWin)
        {
            closeWin.Close();
            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static int validate(Panel p)
        {
            int count = 0;
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if(tb.Text == "")
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                if (c is CheckBox)
                {
                    CheckBox tb = (CheckBox)c;
                    if (!tb.Checked && tb.AllowDrop == false)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                }
                if (c is RadioButton)
                {
                    RadioButton tb = (RadioButton)c;
                    if (!tb.Checked)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox tb = (ComboBox)c;
                    if (tb.SelectedIndex == -1)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
             
            }
            return count;
        }

        public static void openWin(Form openWin, Form MDI)
        {
            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
    }
}
