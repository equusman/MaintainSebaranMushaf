namespace MaintainSebaranMushaf
{
    partial class fMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMaster));
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridViewMaster = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAktif = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMaintain = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txtIDPilihan = new System.Windows.Forms.Label();
            this.labelIDPilihan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelJudulPanel = new System.Windows.Forms.Label();
            this.panelExport = new System.Windows.Forms.Panel();
            this.ExportFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textExport = new System.Windows.Forms.TextBox();
            this.btnSelectExportFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartExport = new System.Windows.Forms.Button();
            this.labelJudulExport = new System.Windows.Forms.Label();
            this.richTexExportLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMaintain.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.panelMaster.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(844, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(129, 30);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridViewMaster
            // 
            this.dataGridViewMaster.AllowUserToAddRows = false;
            this.dataGridViewMaster.AllowUserToDeleteRows = false;
            this.dataGridViewMaster.AllowUserToOrderColumns = true;
            this.dataGridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaster.Location = new System.Drawing.Point(7, 25);
            this.dataGridViewMaster.Name = "dataGridViewMaster";
            this.dataGridViewMaster.Size = new System.Drawing.Size(965, 237);
            this.dataGridViewMaster.TabIndex = 1;
            this.dataGridViewMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaster_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panelAktif);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnMaintain);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 628);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 133);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelAktif
            // 
            this.panelAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.panelAktif.Location = new System.Drawing.Point(188, 199);
            this.panelAktif.Name = "panelAktif";
            this.panelAktif.Size = new System.Drawing.Size(10, 135);
            this.panelAktif.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(2, 471);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(183, 133);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(2, 336);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(183, 133);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMaintain.FlatAppearance.BorderSize = 0;
            this.btnMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintain.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintain.ForeColor = System.Drawing.Color.White;
            this.btnMaintain.Location = new System.Drawing.Point(2, 200);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(183, 133);
            this.btnMaintain.TabIndex = 1;
            this.btnMaintain.Text = "Maintain Sebaran";
            this.btnMaintain.UseVisualStyleBackColor = false;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 198);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 31);
            this.panel2.TabIndex = 3;
            // 
            // panelMaintain
            // 
            this.panelMaintain.Controls.Add(this.panelDetail);
            this.panelMaintain.Controls.Add(this.panelMaster);
            this.panelMaintain.Controls.Add(this.paneltop);
            this.panelMaintain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaintain.Location = new System.Drawing.Point(200, 0);
            this.panelMaintain.Name = "panelMaintain";
            this.panelMaintain.Size = new System.Drawing.Size(984, 730);
            this.panelMaintain.TabIndex = 4;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.txtIDPilihan);
            this.panelDetail.Controls.Add(this.labelIDPilihan);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.btnAddNew);
            this.panelDetail.Controls.Add(this.dataGridViewDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 338);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(984, 392);
            this.panelDetail.TabIndex = 5;
            // 
            // txtIDPilihan
            // 
            this.txtIDPilihan.AutoSize = true;
            this.txtIDPilihan.Location = new System.Drawing.Point(757, 17);
            this.txtIDPilihan.Name = "txtIDPilihan";
            this.txtIDPilihan.Size = new System.Drawing.Size(19, 21);
            this.txtIDPilihan.TabIndex = 4;
            this.txtIDPilihan.Text = "0";
            // 
            // labelIDPilihan
            // 
            this.labelIDPilihan.AutoSize = true;
            this.labelIDPilihan.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDPilihan.ForeColor = System.Drawing.Color.White;
            this.labelIDPilihan.Location = new System.Drawing.Point(224, 20);
            this.labelIDPilihan.Name = "labelIDPilihan";
            this.labelIDPilihan.Size = new System.Drawing.Size(0, 23);
            this.labelIDPilihan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detail Sebaran Mushaf";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToOrderColumns = true;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Location = new System.Drawing.Point(7, 45);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.Size = new System.Drawing.Size(965, 341);
            this.dataGridViewDetail.TabIndex = 0;
            this.dataGridViewDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellClick);
            this.dataGridViewDetail.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellMouseEnter);
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.dataGridViewMaster);
            this.panelMaster.Controls.Add(this.label2);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 65);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(984, 273);
            this.panelMaster.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titik Poin Sebaran";
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.labelJudulPanel);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(984, 65);
            this.paneltop.TabIndex = 2;
            // 
            // labelJudulPanel
            // 
            this.labelJudulPanel.AutoSize = true;
            this.labelJudulPanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulPanel.ForeColor = System.Drawing.Color.White;
            this.labelJudulPanel.Location = new System.Drawing.Point(25, 18);
            this.labelJudulPanel.Name = "labelJudulPanel";
            this.labelJudulPanel.Size = new System.Drawing.Size(217, 28);
            this.labelJudulPanel.TabIndex = 0;
            this.labelJudulPanel.Text = "Maintain Sebaran";
            this.labelJudulPanel.Visible = false;
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.richTexExportLog);
            this.panelExport.Controls.Add(this.labelJudulExport);
            this.panelExport.Controls.Add(this.btnStartExport);
            this.panelExport.Controls.Add(this.label1);
            this.panelExport.Controls.Add(this.btnSelectExportFolder);
            this.panelExport.Controls.Add(this.textExport);
            this.panelExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExport.Location = new System.Drawing.Point(200, 0);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(984, 730);
            this.panelExport.TabIndex = 5;
            // 
            // textExport
            // 
            this.textExport.Location = new System.Drawing.Point(46, 118);
            this.textExport.Name = "textExport";
            this.textExport.Size = new System.Drawing.Size(672, 27);
            this.textExport.TabIndex = 8;
            // 
            // btnSelectExportFolder
            // 
            this.btnSelectExportFolder.Location = new System.Drawing.Point(569, 151);
            this.btnSelectExportFolder.Name = "btnSelectExportFolder";
            this.btnSelectExportFolder.Size = new System.Drawing.Size(149, 27);
            this.btnSelectExportFolder.TabIndex = 9;
            this.btnSelectExportFolder.Text = "Browse";
            this.btnSelectExportFolder.UseVisualStyleBackColor = true;
            this.btnSelectExportFolder.Click += new System.EventHandler(this.btnSelectExportFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Export Folder";
            // 
            // btnStartExport
            // 
            this.btnStartExport.Enabled = false;
            this.btnStartExport.Location = new System.Drawing.Point(46, 216);
            this.btnStartExport.Name = "btnStartExport";
            this.btnStartExport.Size = new System.Drawing.Size(186, 58);
            this.btnStartExport.TabIndex = 11;
            this.btnStartExport.Text = "Start Export";
            this.btnStartExport.UseVisualStyleBackColor = true;
            this.btnStartExport.Click += new System.EventHandler(this.btnStartExport_Click);
            // 
            // labelJudulExport
            // 
            this.labelJudulExport.AutoSize = true;
            this.labelJudulExport.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulExport.ForeColor = System.Drawing.Color.White;
            this.labelJudulExport.Location = new System.Drawing.Point(25, 18);
            this.labelJudulExport.Name = "labelJudulExport";
            this.labelJudulExport.Size = new System.Drawing.Size(217, 28);
            this.labelJudulExport.TabIndex = 12;
            this.labelJudulExport.Text = "Maintain Sebaran";
            this.labelJudulExport.Visible = false;
            // 
            // richTexExportLog
            // 
            this.richTexExportLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTexExportLog.ForeColor = System.Drawing.SystemColors.Window;
            this.richTexExportLog.Location = new System.Drawing.Point(46, 280);
            this.richTexExportLog.Name = "richTexExportLog";
            this.richTexExportLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTexExportLog.Size = new System.Drawing.Size(672, 314);
            this.richTexExportLog.TabIndex = 13;
            this.richTexExportLog.Text = "";
            // 
            // fMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelExport);
            this.Controls.Add(this.panelMaintain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMaster";
            this.Text = "Maintain Sebaran Mushaf Kuno Nusantara";
            this.Load += new System.EventHandler(this.fMaster_Load);
            this.Resize += new System.EventHandler(this.fMaster_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelMaintain.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelExport.ResumeLayout(false);
            this.panelExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridViewMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panelAktif;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMaintain;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelJudulPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIDPilihan;
        private System.Windows.Forms.Label txtIDPilihan;
        private System.Windows.Forms.FolderBrowserDialog ExportFolderBrowserDialog;
        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.TextBox textExport;
        private System.Windows.Forms.RichTextBox richTexExportLog;
        private System.Windows.Forms.Label labelJudulExport;
        private System.Windows.Forms.Button btnStartExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectExportFolder;
    }
}