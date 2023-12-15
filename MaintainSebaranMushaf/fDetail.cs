using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MaintainSebaranMushaf
{
    public partial class fDetail : Form
    {
        private bool ThereAreUnsavedChanges = false;
        private ClassDbHandler db = new ClassDbHandler();

        public Detail datadetail = new Detail();
        private bool loaded;

        public int idpin;
        public int itemcode;
        public int FormMode = 0;  // 0 initial, 1 add new, 2 edit mode

        public fDetail()
        {
            this.ThereAreUnsavedChanges  = false;
            InitializeComponent();
        }

        private void explodeData()
        {
            int sbLen = datadetail.Deskripsiitem.Length
                + (datadetail.Deskripsiitem.Length << 1);
            StringBuilder sb = new StringBuilder(sbLen);
            foreach (String line in txtKeterangan.Lines)
            {
                sb.AppendLine(line);
            }
            txtKeterangan.Text = sb.ToString();
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

        public void DoClear(Master mst)
        {
            loaded = false;
            idpin = mst.Idpin;
            txtPinPoint.Text = mst.Judulpin;
            txtPinPoint.Tag = mst.Judulpin;
            itemcode = 0;
            txtNamaMushaf.Text = "";
            txtNamaMushaf.Tag = "";
            txtKeterangan.Text = "";
            txtKeterangan.Tag = "";
            txtGambar.Image = null;
            txtGambar.Tag = "";
            loaded = true;
        }

        public void DoLoad(Master mst, Detail dtl)
        {
            loaded = false;
            idpin = dtl.Idpin;
            itemcode = dtl.Itemcode;
            txtPinPoint.Text = mst.Judulpin;
            txtPinPoint.Tag = mst.Judulpin;
            txtNamaMushaf.Text = dtl.Judulitem;
            txtNamaMushaf.Tag = dtl.Judulitem;
            txtKeterangan.Text = dtl.Deskripsiitem;
            txtKeterangan.Tag = dtl.Deskripsiitem;
            //int sbLen = txtKeterangan.Text.Length + (txtKeterangan.Lines.Length << 1);
            //StringBuilder sb = new StringBuilder(sbLen);
            //foreach (String line in txtKeterangan.Lines)
           // {
            //    sb.AppendLine(line);
           // }
            //txtKeterangan.Text = sb.ToString();
            txtGambar.Image = Image.FromFile(Application.StartupPath.ToString() + dtl.Filegambar.ToString().Replace('/', '\\') + ".png");
            txtGambar.Tag = Application.StartupPath.ToString() + dtl.Filegambar.ToString().Replace('/', '\\') + ".png";
            openBrowseGambar.FileName = Application.StartupPath.ToString() + dtl.Filegambar.ToString().Replace('/', '\\') + ".png";
            openBrowseGambar.Tag = openBrowseGambar.FileName;
            loaded = true;
        }

        private bool DoSave()
        {
            if (FormMode == 1) 
            { 
                if (txtKeterangan.Text.Equals("") || txtNamaMushaf.Text.Equals("") || openBrowseGambar.FileName.Equals(""))
                {
                    if (ThereAreUnsavedChanges)
                    {
                        MessageBox.Show("Nama Mushaf, Keterangan dan gambar tidak boleh kosong", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }
                else
                {
                    try
                    {
                        File.Copy(openBrowseGambar.FileName, Application.StartupPath.ToString().Replace('/', '\\') +"//mushaf//"+ Path.GetFileNameWithoutExtension(openBrowseGambar.FileName) + ".png");
                        Detail savedetail = new Detail()
                        {
                            Idpin = this.idpin,
                            Filegambar = ("/mushaf/" + Path.GetFileNameWithoutExtension(openBrowseGambar.FileName)),
                            Deskripsiitem = txtKeterangan.Text,
                            Judulitem = txtNamaMushaf.Text
                        };
                        byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(txtKeterangan.Text);
                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@keterangan", textBytes },
                            { "@idpin", savedetail.Idpin },
                            { "@filegambar", savedetail.Filegambar},
                            { "@judul", savedetail.Judulitem},
                            { "@itemcode", db.LastItemcode()}
                        };
                        string insertstatement = "insert into detail_dotpinpoint (idpin, itemcode, judulitem, deskripsiitem,filegambar) values (@idpin,@itemcode,@judul,@keterangan, @filegambar )";
                        if (db.ExecuteWrite(insertstatement, parameters) != 0)
                        {
                            MessageBox.Show("Data has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                        throw;
                    }

                }
                return true;
            } else if (FormMode == 2)
            {
                if (!(txtKeterangan.Text.Equals(txtKeterangan.Tag) && txtNamaMushaf.Text.Equals(txtNamaMushaf.Tag) && openBrowseGambar.FileName.Equals(openBrowseGambar.Tag)))
                {
                    //belum di review
                    try
                    {
                        if (!openBrowseGambar.FileName.Equals(openBrowseGambar.Tag))
                        {
                            File.Copy(openBrowseGambar.FileName, Application.StartupPath.ToString().Replace('/', '\\') + "//mushaf//" + Path.GetFileNameWithoutExtension(openBrowseGambar.FileName) + ".png");
                        }
                        Detail savedetail = new Detail()
                        {
                            Idpin = this.idpin,
                            Filegambar = ("/mushaf/" + Path.GetFileNameWithoutExtension(openBrowseGambar.FileName)),
                            Deskripsiitem = txtKeterangan.Text,
                            Judulitem = txtNamaMushaf.Text
                        };
                        byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(txtKeterangan.Text);
                        Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@keterangan", textBytes },
                            { "@idpin", idpin },
                            { "@filegambar", savedetail.Filegambar},
                            { "@judul", savedetail.Judulitem},
                            { "@itemcode", itemcode}
                        };
                        string updatestatement = "update detail_dotpinpoint set judulitem = @judul, filegambar = @filegambar, deskripsiitem = @keterangan where idpin = @idpin and itemcode = @itemcode";
                        if (db.ExecuteWrite(updatestatement, parameters) != 0)
                        {
                            MessageBox.Show("Data has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                        throw;
                    }
                    //batas belum di review


                }

            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoSave()) this.Close();
        }

        private void txtNamaMushaf_TextChanged(object sender, EventArgs e)
        {
            if (loaded) 
            { 
                try
                {
                    if (!txtNamaMushaf.Text.Equals(txtNamaMushaf.Tag.ToString()) || txtNamaMushaf.Text.Equals(null))
                    {
                        this.ThereAreUnsavedChanges = true;
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void txtKeterangan_TextChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                try
                {
                    if (!txtKeterangan.Text.Equals(txtKeterangan.Tag.ToString()) || txtKeterangan.Text.Equals(null))
                    {
                        this.ThereAreUnsavedChanges = true;
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openBrowseGambar.ShowDialog() == DialogResult.OK)
            {
                txtGambar.Image = Image.FromFile(openBrowseGambar.FileName);
                this.ThereAreUnsavedChanges = true;
            }
        }

        private void fDetail_Shown(object sender, EventArgs e)
        {
            //loaded = false;
        }

        private void fDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ThereAreUnsavedChanges && !DoSave()) e.Cancel = true;
        }
    }
}
