using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;

namespace MaintainSebaranMushaf
{
    public partial class fMaster : Form
    {
        private ClassDbHandler db = new ClassDbHandler();

        private Master master = new Master();
        private Detail detail = new Detail();
        private fDetail fdetail = new fDetail();


        public fMaster()
        {
            InitializeComponent();
        }

        private void fMaster_Load(object sender, EventArgs e)
        {
            panelMaintain.Show();
            labelJudulPanel.Text = "Maintain Sebaran";
            labelJudulPanel.Show();
            panelExport.Hide();
            panelMaster.Show();
            panelDetail.Show();
            btnAddNew.Enabled = false;
            btnAddNew.ForeColor = System.Drawing.Color.FromArgb(66,66,66);
            //btnAddNew.Text = db.LastIdPin().ToString();
            DataTable datane = db.ExecuteNoParam("select idpin as ID,judulpin as Judul ,jumlahkoleksi as JumlahKoleksi from master_dotpinpoint");
            dataGridViewMaster.DataSource = datane;
            DataGridViewButtonColumn btndetail = new DataGridViewButtonColumn();
            btndetail.Name = "btndetail";
            btndetail.Text = "Detail";
            btndetail.HeaderText = "";
            btndetail.UseColumnTextForButtonValue = true;
            //int indexbtndetail = 4;
            dataGridViewMaster.ReadOnly = true;
            dataGridViewMaster.Columns.Add(btndetail);
            //dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridViewMaster.AutoResizeColumns();
            dataGridViewMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaster.Columns[0].Visible = false;
            dataGridViewMaster.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewMaster.Columns[2].MinimumWidth = 150;
            dataGridViewMaster.Columns[2].Width = 150;
            dataGridViewMaster.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewMaster.Columns[3].MinimumWidth = 80;
            dataGridViewMaster.Columns[3].Width = 80;
        }

        private void dataGridViewMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                master.Idpin = int.Parse(dataGridViewMaster.Rows[e.RowIndex].Cells[0].Value.ToString());
                master.Judulpin = dataGridViewMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                master.Jumlahkoleksi = dataGridViewMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
               
                // MessageBox.Show(dataGridViewMaster.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataTable detaile = db.GetDetail(dataGridViewMaster.Rows[e.RowIndex].Cells[0].Value.ToString());
                dataGridViewDetail.RowTemplate.Height = 100;
                dataGridViewDetail.DataSource = null;
                dataGridViewDetail.Rows.Clear();
                dataGridViewDetail.Columns.Clear();
                dataGridViewDetail.DataSource = detaile;
                labelIDPilihan.Text = "- " + dataGridViewMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIDPilihan.Text = dataGridViewMaster.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = null;
                //img.Image = image;
                img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewDetail.Columns.Add(img);

                DataGridViewImageCell imgcell = new DataGridViewImageCell();
                foreach (DataGridViewRow baris in dataGridViewDetail.Rows)
                {
                    image = Image.FromFile(Application.StartupPath.ToString() + baris.Cells[4].Value.ToString().Replace('/','\\') + ".png");
                    baris.Cells[5].Value = (System.Drawing.Image)image;
                }


                DataGridViewButtonColumn btneditdetail = new DataGridViewButtonColumn();
                btneditdetail.Name = "btneditdetail";
                btneditdetail.Text = "Edit";
                btneditdetail.HeaderText = "";
                btneditdetail.UseColumnTextForButtonValue = true;
                //int indexbtndetail = 4;
                dataGridViewDetail.ReadOnly = true;
                dataGridViewDetail.Columns.Add(btneditdetail);
                //dataGridView1.CellClick += dataGridView1_CellClick;
                dataGridViewDetail.AutoResizeColumns();
                dataGridViewDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDetail.Columns[0].Visible = false;
                dataGridViewDetail.Columns[1].Visible = false;
                dataGridViewDetail.Columns[4].Visible = false;
                dataGridViewDetail.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewDetail.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //dataGridViewDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewDetail.Columns[2].MinimumWidth = 150;
                dataGridViewDetail.Columns[2].Width = 150;
                dataGridViewDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewDetail.Columns[6].MinimumWidth = 100;
                dataGridViewDetail.Columns[6].Width = 100;
                dataGridViewDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewDetail.Columns[5].MinimumWidth = 100;
                dataGridViewDetail.Columns[5].Width = 100;
                btnAddNew.Enabled = true;
                btnAddNew.ForeColor = System.Drawing.Color.FromArgb(60, 120, 140);
            }
        }
        
        public void refreshDetail()
        {
            DataTable detaile = db.GetDetail(master.Idpin.ToString());
            dataGridViewDetail.RowTemplate.Height = 100;
            dataGridViewDetail.DataSource = null;
            dataGridViewDetail.Rows.Clear();
            dataGridViewDetail.Columns.Clear();
            dataGridViewDetail.DataSource = detaile;
            labelIDPilihan.Text = "- " + master.Judulpin;
            txtIDPilihan.Text = master.Idpin.ToString();

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = null;
            //img.Image = image;
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewDetail.Columns.Add(img);

            DataGridViewImageCell imgcell = new DataGridViewImageCell();
            foreach (DataGridViewRow baris in dataGridViewDetail.Rows)
            {
                image = Image.FromFile(Application.StartupPath.ToString() + baris.Cells[4].Value.ToString().Replace('/', '\\') + ".png");
                baris.Cells[5].Value = (System.Drawing.Image)image;
            }


            DataGridViewButtonColumn btneditdetail = new DataGridViewButtonColumn();
            btneditdetail.Name = "btneditdetail";
            btneditdetail.Text = "Edit";
            btneditdetail.HeaderText = "";
            btneditdetail.UseColumnTextForButtonValue = true;
            //int indexbtndetail = 4;
            dataGridViewDetail.ReadOnly = true;
            dataGridViewDetail.Columns.Add(btneditdetail);
            //dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridViewDetail.AutoResizeColumns();
            dataGridViewDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetail.Columns[0].Visible = false;
            dataGridViewDetail.Columns[1].Visible = false;
            dataGridViewDetail.Columns[4].Visible = false;
            dataGridViewDetail.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDetail.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridViewDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewDetail.Columns[2].MinimumWidth = 150;
            dataGridViewDetail.Columns[2].Width = 150;
            dataGridViewDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewDetail.Columns[6].MinimumWidth = 100;
            dataGridViewDetail.Columns[6].Width = 100;
            dataGridViewDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewDetail.Columns[5].MinimumWidth = 100;
            dataGridViewDetail.Columns[5].Width = 100;
            btnAddNew.Enabled = true;
            btnAddNew.ForeColor = System.Drawing.Color.FromArgb(60, 120, 140);

        }


        private void btnMaintain_Click(object sender, EventArgs e)
        {
            panelAktif.Height = btnMaintain.Height;
            panelAktif.Top = btnMaintain.Top;
            panelMaintain.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            panelAktif.Height = btnLoad.Height;
            panelAktif.Top = btnLoad.Top;
            panelMaintain.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            panelMaintain.Hide();
            labelJudulPanel.Text = "Export Data";
            labelJudulPanel.Show();
            panelExport.Show();
            panelMaster.Hide();
            panelDetail.Hide();


            panelAktif.Height = btnExport.Height;
            panelAktif.Top = btnExport.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelAktif.Top = btnExit.Top;
            panelAktif.Height = btnExit.Height;
            Application.Exit();
        }

        private void fMaster_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            dataGridViewMaster.Width = panelMaster.Size.Width -20;
            dataGridViewDetail.Width = panelDetail.Size.Width -20;
            dataGridViewDetail.Height = panelDetail.Size.Height - 50;
            btnAddNew.Left = panelDetail.Width - btnAddNew.Width - 14;

        }

        private void dataGridViewDetail_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
                dataGridView.Cursor = Cursors.Hand;
            else
                dataGridView.Cursor = Cursors.Default;
        }

        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Master mst = new Master();
            Detail dtl = new Detail();

            //var senderGrid = (DataGridView)sender;

            //mst.Idpin = senderGrid.Rows[e.RowIndex].Cells[2].Value
            mst.Idpin = master.Idpin;
            mst.Judulpin = master.Judulpin;
            mst.Jumlahkoleksi = master.Jumlahkoleksi;
            dtl.Deskripsiitem = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtl.Filegambar = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtl.Idpin = Int16.Parse(txtIDPilihan.Text.ToString());
            dtl.Itemcode = Int16.Parse(senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            dtl.Judulitem = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //klik detail
                //MessageBox.Show(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                fdetail.FormMode = 2;
                fdetail.DoLoad(mst, dtl);
                fdetail.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                fPicture preview = new fPicture();
                preview.pictureBox.Image = Image.FromFile(Application.StartupPath.ToString() + senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString().Replace('/', '\\') + ".png");
                preview.Cursor = Cursors.Hand;
                preview.ShowDialog();
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            Master mst = new Master();
            Detail dtl = new Detail();

            //var senderGrid = (DataGridView)sender;

            //mst.Idpin = senderGrid.Rows[e.RowIndex].Cells[2].Value
            mst.Idpin = master.Idpin;
            mst.Judulpin = master.Judulpin;
            mst.Jumlahkoleksi = master.Jumlahkoleksi;
            dtl.Deskripsiitem = "";
            dtl.Filegambar = "";
            dtl.Idpin = Int16.Parse(txtIDPilihan.Text.ToString());
            dtl.Itemcode = 0;
            dtl.Judulitem = "";

            fdetail.datadetail = dtl;
            fdetail.FormMode = 1;
            fdetail.DoClear(mst);

            fdetail.ShowDialog();
            refreshDetail();
        }

        private void btnSelectExportFolder_Click(object sender, EventArgs e)
        {
            if (ExportFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                btnStartExport.Enabled = true;    
            }
        }

        private void btnStartExport_Click(object sender, EventArgs e)
        {
            string sourcedbpath = Application.StartupPath.ToString().Replace('/', '\\') + "\\sebaranmushaf.dat";
            string sourcemushaffolder = Application.StartupPath.ToString().Replace('/', '\\') + "\\mushaf\\";
            DirectoryInfo mushafdir = new DirectoryInfo(sourcemushaffolder);
            FileInfo[] listpng = mushafdir.GetFiles("*.png");
            int totalfile = listpng.Length + 1;
            richTexExportLog.AppendText("Exporting database.");
            File.Copy(sourcedbpath, Application.StartupPath.ToString().Replace('/', '\\') + "\\sebaranmushaf.sqlite", true);
            richTexExportLog.AppendText("Exporting database finished.");

            using (var zip = new ZipFile())
            {
                richTexExportLog.AppendText("Compressing database.");

                zip.AddFile(Application.StartupPath.ToString().Replace('/', '\\') + "\\sebaranmushaf.sqlite", "\\");
                richTexExportLog.AppendText("Database compresed.");
                richTexExportLog.AppendText("Start compressing image files.");

                foreach (FileInfo filepng in listpng)
                {
                    richTexExportLog.AppendText("Compressing "+ filepng.Name+".");
                    zip.AddFile(sourcemushaffolder + filepng.Name, "\\mushaf\\");
                }
                richTexExportLog.AppendText("Finish compressing image files.");
                DateTime now = DateTime.Now;
                string dt = now.ToString("yyyyMMdd-HHmmss");
                richTexExportLog.AppendText("Completing export file.");
                zip.Save(ExportFolderBrowserDialog.SelectedPath + "\\sebaranmushaf-" + dt + ".zip");
                richTexExportLog.AppendText("Export " + ExportFolderBrowserDialog.SelectedPath + "\\sebaranmushaf-" + dt + ".zip finished!");
                MessageBox.Show("Export " + ExportFolderBrowserDialog.SelectedPath + "\\sebaranmushaf-" + dt + ".zip finished!", "Information", MessageBoxButtons.OK);
            }
            File.Delete(Application.StartupPath.ToString().Replace('/', '\\') + "\\sebaranmushaf.sqlite");

        }
    }
}
