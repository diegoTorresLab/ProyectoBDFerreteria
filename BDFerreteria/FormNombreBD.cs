using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFerreteria
{
    public partial class FormNombreBD : Form
    {
        public string NombreBD {  get; set; }
        public FormNombreBD(string prompt)
        {
            InitializeComponent();
            lblNombreBD.Text = prompt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NombreBD = txtNombreBD.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblNombreBD_Click(object sender, EventArgs e)
        {

        }
    }
}
