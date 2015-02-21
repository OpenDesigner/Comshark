using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Comshark
{
    class DataRepository
    {
        SQLiteConnection m_dbConnection;

        public DataRepository()
        {
            InitialiseDatabase();
        }

        public void InitialiseDatabase()
        {
            SQLiteConnection.CreateFile("comshark_capture.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=comshark_capture.sqlite;Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command;
            string sql;

            sql = "create table rawdata (data VARCHAR(2048))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "create table processed (Id INT, Time VARCHAR(64), Source VARCHAR(64), Destination VARCHAR(64), Protocol VARCHAR(32), Length INT, Info VARCHAR(256), Valid INT)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }


        public DataTable GetProcessedDataTable()
        {
            SQLiteCommand command;
            string sql;
            DataTable dt;

            sql = "select Protocol, Time, Source, Destination, Length, Info, Valid from processed";
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                return null;
            }

            return dt;
        }


        public void TestInsert()
        {
            SQLiteCommand command;
            string sql;
            sql = "insert into processed (Id, Time, Source, Destination, Protocol, Length, Info, Valid) values (0, '2015-02-19 21:02:39,360', '0x50', 'Master','Modbus/ASCII', 13, 'Register Read: 58, 48, 49, 48, 51, 48, 48, 35, 32, 32, 48, 53, 57, 68, 13, 10', 0)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

    }
}
