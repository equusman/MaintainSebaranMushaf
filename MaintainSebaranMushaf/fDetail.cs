using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintainSebaranMushaf
{
    public partial class fDetail : Form
    {
        private bool ThereAreUnsavedChanges;
        public fDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ThereAreUnsavedChanges)
                switch (MessageBox.Show("There are unsaved data. Are you sure want to Cancel?",
                                         "Warning",
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        DoSave();
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        //e.Cancel = true;
                        break;
                }
            else
            {
                this.Close();
            }
        }

        private bool DoSave()
        {
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSave();
            this.Close();
        }

        private void txtNamaMushaf_TextChanged(object sender, EventArgs e)
        {
            ThereAreUnsavedChanges = true;
        }

        private void txtKeterangan_TextChanged(object sender, EventArgs e)
        {
            ThereAreUnsavedChanges = true;
        }
    }
}
