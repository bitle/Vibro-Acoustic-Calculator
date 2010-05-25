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
    public partial class FormAddMicrophone : Form
    {
        public FormAddMicrophone()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип микрофона");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        public string MicrophoneName
        {
            get
            {
                return tbName.Text;
            }
        }
        public int MicrophoneType
        {
            get
            {
                return cbType.SelectedIndex;
            }
        }
    }
}
