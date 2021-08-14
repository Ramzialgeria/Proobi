using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Proobi_1._0
{
    class DataBaseClass
    {
        private SQLiteConnection conn;

        public DataBaseClass()
        {
            if (!File.Exists("DataOS.dat")) // the database name is DataOS.dat
            {
                try
                {
                    SQLiteConnection.CreateFile("DataOS.dat");
                    SQLiteConnection m_dbConnection;

                    m_dbConnection = new SQLiteConnection("Data Source=DataOS.dat;Version=3;");
                    m_dbConnection.Open();

                    string sql = " CREATE TABLE User("
                    + " IDUser INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,"
                    + " UserName nvarchar(100) NULL,"
                    + " Password nvarchar(10) null,"
                    + " Name nvarchar(10) null,"
                    + " Email nvarchar(10) null,"
                    + " Adress nvarchar(10) null) ";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    sql = "CREATE TABLE Function("
                    + " IDFunction INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,"
                    + " FunctionName nvarchar(100) NULL,"
                    + " FunctionCode text NULL)";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    sql = "CREATE TABLE History("
                    + " IDHistory int NULL,"
                    + " IDUser int NULL,"
                    + " FileName nvarchar(100) NULL) ";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();


                    m_dbConnection.Clone();
                }
                catch (Exception ex)
                { }
            }

            conn = new SQLiteConnection("Data Source=DataOS.dat;Version=3;");
        }

        public void Open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
               
            }
        }

        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
