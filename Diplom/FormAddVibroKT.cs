using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom
{
    public partial class FormAddVibroKT : Form
    {
        public FormAddVibroKT()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void FormAddVibroKT_Load(object sender, EventArgs e)
        {
            //DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        public string KTName
        {
            get
            {
                return tbName.Text;
            }
        }
    }
}
