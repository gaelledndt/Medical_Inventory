﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using authentification;

namespace MedicalInventory
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void Sample_Load(object sender, EventArgs e)
        {
            if (Auth.employeeName != null)
            {
                label2.Text = Auth.employeeName;
            }
            else
            {
                label2.Text = "Votre compte utilisateur";
            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
