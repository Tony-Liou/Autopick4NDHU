using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Autopick4NDHU
{
    class RecordManipulation
    {
        public readonly string[] colName = new string[7] { "Id", "Date", "StartHour", "EndHour","SportField", "StudentID", "Password" };
        public Record rec;
        private SQLiteConnection cn;

        public RecordManipulation() // create table
        {
            if (File.Exists(Global.DB_FILE)) return;
            CreateTable();
        }

        private void CreateTable()
        {
            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE records (
                            Id INTEGER PRIMARY KEY,
                            Date DATE NOT NULL,
                            StartHour INTEGER NOT NULL,
                            EndHour INTEGER NOT NULL,
                            SportField VARCHAR(8) NOT NULL,
                            StudentID VARCHAR(10) NOT NULL,
                            Password VARCHAR(32) NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }

        public bool isTableExisted()
        {
            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='" +
                        Global.DB_TABLE_NAME + "'";

                    SQLiteDataReader r = cmd.ExecuteReader();

                    if (r.Read())
                    {
                        if (r.GetInt32(0) == 0)
                            return false;
                        else
                            return true;
                    }
                }
            }
            return false;
        }

        public bool Insert()
        {
            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id FROM " + Global.DB_TABLE_NAME + " WHERE Date = '" + rec.Date +
                        "' AND StartHour = " + rec.StartHour +
                        " AND EndHour = " + rec.EndHour +
                        " AND SportField = '" + rec.SF +
                        "' AND StudentID = '" + rec.StudentID +
                        "' AND Password = '" + rec.Pwd + "'";

                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read()) // Check if the record is duplicate
                        {
                            return false;
                        }
                    }

                    cmd.CommandText = @"SELECT COALESCE(MAX(Id), 0) FROM " + Global.DB_TABLE_NAME;
                    int count = 0;
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            count = r.GetInt32(0);
                        }
                    }
                    ++count;

                    cmd.CommandText = @"INSERT INTO " + Global.DB_TABLE_NAME + " VALUES (" + count + ",'" +
                        rec.Date + "'," +
                        rec.StartHour + "," +
                        rec.EndHour + ",'" +
                        rec.SF + "','" +
                        rec.StudentID + "','" +
                        rec.Pwd + "')";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
        }

        public bool Delete(int id)
        {
            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM " + Global.DB_TABLE_NAME + " WHERE Id = " + id;
                    /*cmd.CommandText = @"DELETE FROM " + Global.DB_TABLE_NAME + " WHERE Dt = " + rec.DT +
                        " AND SportField = " + rec.SF +
                        " AND StudentID = " + rec.StudentID +
                        " AND Password = " + rec.Pwd;*/

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            return false;
        }

        public List<List<string>> ShowAll()
        {
            List<List<string>> tmp = new List<List<string>>();

            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM " + Global.DB_TABLE_NAME;
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        List<string> col = new List<string>(7)
                        {
                            r[colName[0]].ToString(),
                            Convert.ToDateTime(r[colName[1]]).ToString("yyyy/MM/dd"),
                            Convert.ToString(r[colName[2]]),
                            Convert.ToString(r[colName[3]]),
                            Convert.ToString(r[colName[4]]),
                            Convert.ToString(r[colName[5]]),
                            Convert.ToString(r[colName[6]])
                        };
                        /*col.Add(r[colName[0]].ToString());
                        string temp = r[colName[1]].ToString();
                        col.Add(Convert.ToDateTime(temp).ToString("yyyy/MM/dd"));
                        col.Add(Convert.ToString(r[colName[2]]));
                        col.Add(Convert.ToString(r[colName[3]]));
                        col.Add(Convert.ToString(r[colName[4]]));
                        col.Add(Convert.ToString(r[colName[5]]));
                        col.Add(Convert.ToString(r[colName[6]]));*/

                        tmp.Add(col);
                    }
                }
                cn.Close();
            }
            return tmp;
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable("Records");

            for (int i = 0; i < 7; ++i)
            {
                dt.Columns.Add(colName[i], typeof(String));
            }

            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM " + Global.DB_TABLE_NAME;
                    SQLiteDataReader r = cmd.ExecuteReader();

                    DataRow row;
                    while (r.Read())
                    {
                        row = dt.NewRow();
                        
                        dt.Rows.Add(new object[] {
                            r[colName[0]].ToString(),
                            Convert.ToDateTime(r[colName[1]]).ToString("yyyy/MM/dd"),
                            Convert.ToString(r[colName[2]]),
                            Convert.ToString(r[colName[3]]),
                            Convert.ToString(r[colName[4]]),
                            Convert.ToString(r[colName[5]]),
                            Convert.ToString(r[colName[6]])});
                    }
                }
                cn.Close();
            }
            return dt;
        }

        public void Query(string command) // Not finished
        {
            using (cn = new SQLiteConnection("Data Source=" + Global.DB_FILE + ";"))
            {
                cn.Open();

                using (SQLiteCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = command;
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                    }
                }
                cn.Close();
            }
        }
    }
}
