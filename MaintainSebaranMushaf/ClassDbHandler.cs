using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace MaintainSebaranMushaf
{

    //[Table("master_dotpinpoint")]
    public class Master
    {
        //[PrimaryKey]
        //[Column("idpin")]
        public int Idpin { get; set; }

        //[Column("judulpin")]
        public string Judulpin { get; set; }

        //[Column("jumlahkoleksi")]
        public string Jumlahkoleksi { get; set; }
    }

    //[Table("detail_dotpinpoint")]
    public class Detail
    {
        //[PrimaryKey]
        //[Column("itemcode")]
        public int Itemcode { get; set; }

        //[Column("judulitem")]
        public string Judulitem { get; set; }

        //[Column("deskripsiitem")]
        public string Deskripsiitem { get; set; }

        //[Column("filegambar")]
        public string Filegambar { get; set; }

        //[Column("idpin")]
        public int Idpin { get; set; }
    }

    class ClassDbHandler
    {
        //private SQLiteConnection _db;
        private string connectionString = "Data Source=sebaranmushaf.dat;Version=3;";


        public void DBHandler()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

            }

        }

        public int ExecuteWrite(string query, Dictionary<string, object> args)
        {
            int numberOfRowsAffected;

            //setup the connection to the database
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                //open a new command
                using (var cmd = new SQLiteCommand(query, con))
                {
                    //set the arguments given in the query
                    foreach (var pair in args)
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }

                    //execute the query and get the number of row affected
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                //con.AutoCommit = true;
                con.Close();

                return numberOfRowsAffected;
            }
        }

        public DataTable Execute(string query, Dictionary<string, object> args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                {
                    foreach (KeyValuePair<string, object> entry in args)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                    var da = new SQLiteDataAdapter(cmd);

                    var dt = new DataTable();
                    da.Fill(dt);

                    da.Dispose();
                    return dt;
                }
                con.Close();
            }
        }


        public DataTable ExecuteNoParam(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand("begin transaction ;"+query+"; commit transaction;", con))
                {
                    var da = new SQLiteDataAdapter(cmd);

                    var dt = new DataTable();
                    da.Fill(dt);

                    da.Dispose();
                    return dt;
                }
                con.Close();
            }
        }

        public DataTable GetDetail(string prmID)
        {
            //string query = "select idpin, itemcode, cast(judulitem as TEXT) as 'Judul Mushaf', replace( replace( deskripsiitem, CHAR(10), ' '), CHAR(13), ' ') as Deskripsi, filegambar from detail_dotpinpoint where idpin = @idpin"; // belum ada deskripsiitem, 
            string query = "select idpin, itemcode, cast(judulitem as TEXT) as 'Judul Mushaf', cast(deskripsiitem as TEXT) as Deskripsi, filegambar from detail_dotpinpoint where idpin = @idpin";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpin", prmID }
            };

            DataTable result = Execute(query, parameters);

            return result;
        }

        public object LastIdPin()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                const string query = "select max(idpin)+1 from master_dotpinpoint";
                con.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
 //                       Console.WriteLine($"The selected value is: {result}");
                        return result;
                    }
                    else
                    {
 //                       Console.WriteLine("No result found.");
                        return null;
                    }
                }
            }
        }

        public object LastItemcode()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                const string query = "select max(itemcode)+1 from detail_dotpinpoint";
                con.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
//                        Console.WriteLine($"The selected value is: {result}");
                        return result;
                    }
                    else
                    {
//                        Console.WriteLine("No result found.");
                        return null;
                    }
                }
            }
        }

        private int AddMaster(Master master)
        {
            const string query = "begin transaction ;INSERT INTO master_dotpinpoint(idpin, judulpin, jumlahkoleksi) VALUES(@idpin, @judulpin, @jumlahkoleksi);commit transaction;";

            //here we are setting the parameter values that will be actually 
            //replaced in the query in Execute method
            var args = new Dictionary<string, object>
            {
                {"@idpin", master.Idpin},
                {"@judulpin", master.Judulpin},
                {"@jumlahkoleksi", master.Jumlahkoleksi}
            };

            return ExecuteWrite(query, args);
        }

        //private int EditUser(User user)
        //{
        //    const string query = "UPDATE User SET FirstName = @firstName, LastName = @lastName WHERE Id = @id";

        //    //here we are setting the parameter values that will be actually 
        //    //replaced in the query in Execute method
        //    var args = new Dictionary<string, object>
        //    {
        //        {"@id", user.Id},
        //        {"@firstName", user.FirstName},
        //        {"@lastName", user.Lastname}
        //    };

        //    return ExecuteWrite(query, args);
        //}

        //private int DeleteUser(User user)
        //{
        //    const string query = "Delete from User WHERE Id = @id";

        //    //here we are setting the parameter values that will be actually 
        //    //replaced in the query in Execute method
        //    var args = new Dictionary<string, object>
        //    {
        //        {"@id", user.Id}
        //    };

        //    return ExecuteWrite(query, args);
        //}



        //-----------
    }
}
