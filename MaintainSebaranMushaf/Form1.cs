using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;
using SQLite;

namespace MaintainSebaranMushaf
{
    [Table("master_dotpinpoint")]
    public class Master
    {
        [PrimaryKey]
        [Column("idpin")]
        public int Idpin { get; set; }

        [Column("judulpin")]
        public string Judulpin { get; set; }

        [Column("jumlahkoleksi")]
        public string Jumlahkoleksi { get; set; }
    }

    [Table("detail_dotpinpoint")]
    public class Detail
    {
        [PrimaryKey]
        [Column("itemcode")]
        public int Itemcode { get; set; }

        [Column("judulitem")]
        public string Judulitem { get; set; }

        [Column("deskripsiitem")]
        public string Deskripsiitem { get; set; }

        [Column("filegambar")]
        public string Filegambar{ get; set; }

        [Column("idpin")]
        public string Idpin { get; set; }
    }



    public class DBHandler
    {
        private SQLiteConnection _db;

        public DBHandler()
        {
            _db = new SQLiteConnection("sebaranmushaf.dat");
            
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
