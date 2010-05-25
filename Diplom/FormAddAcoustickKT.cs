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
    public partial class FormAddAcoustickKT : Form
    {
        public FormAddAcoustickKT()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                tbName.BackColor = Color.Red;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            tbName.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
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

        public KTType Type
        {
            get
            {
                if (rbOutside.Checked)
                {
                    return KTType.Outside;
                }
                else if (rbNeighor.Checked)
                {
                    return KTType.Neighbor;
                }
                else if (rbVent.Checked)
                {
                    return KTType.Vent;
                }
                else
                {
                    return KTType.Vibro;
                }

            }
        }
    }
}
