//Jacob Barnes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishToPigLatin
{
    public partial class frmEngToPigLatin : Form
    {
        Convert newConversion;

        public frmEngToPigLatin()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Convert Text
            string strEng = txtEng.Text;
            newConversion = new Convert(strEng);
            txtPigL.Text = newConversion.Piglatin;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear text fields
            txtEng.Text = "";
            txtPigL.Text = "";
            txtEng.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
