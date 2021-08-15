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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="Name"></param>
        /// <param name="Email"></param>
        /// <param name="Adress"></param>
        /// 
        //Adding User
        public void AddUser(string UserName, string Password, string Name, string Email, string Adress)
        {
            string query = "INSERT INTO User (UserName, Password, Name, Email, Adress) VALUES ('" +
                UserName + "','" +
                Password + "','" +
                Name + "','" +
                Email + "','" +
                Adress + "')";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }

        //Updating  User
        public void UpdateUser(int IDUser, string UserName, string Password, string Name, string Email, string Adress)
        {
            string query = "UPDATE User SET UserName ='" + UserName
                + "',  Password='" + Password
                + "',  Name='" + Name
                + "',  Email='" + Email
                + "',  Adress='" + Adress
                + "' WHERE IDUser='" + IDUser.ToString() + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
        }

        //Deleting User
        public void DeleteUser(int IDUser)
        {
            string query = "DELETE FROM User WHERE IDUser='" + IDUser + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FunctionName"></param>
        /// <param name="FunctionCode"></param>
        /// 
        //Adding Function
        public void AddFunction(string FunctionName, string FunctionCode)
        {
            string query = "INSERT INTO Function (FunctionName, FunctionCode) VALUES ('" +
                FunctionName + "','" +
                FunctionCode + "')";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }

        //Updating  Function
        public void UpdateFunction(int IDFunction, string FunctionName, string FunctionCode)
        {
            string query = "UPDATE Function SET FunctionName ='" + FunctionName
                + "',  FunctionCode='" + FunctionCode
                + "' WHERE IDFunction='" + IDFunction.ToString() + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
        }

        //Deleting Function
        public void DeleteFunction(int IDFunction)
        {
            string query = "DELETE FROM Function WHERE IDUser='" + IDFunction + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDUser"></param>
        /// <param name="FileName"></param>
        /// 
        //Adding History
        public void AddHistory(int IDUser,int FileName)
        {
            string query = "INSERT INTO History (IDUser, FileName) VALUES ('" +
                IDUser.ToString() + "','" +
                FileName + "')";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }

        //Updating  History
        public void UpdateHistory(int IDHistory, int IDUser, int FileName)
        {
            string query = "UPDATE History SET IDUser ='" + IDUser.ToString()
                + "',  FileName='" + FileName
                + "' WHERE IDHistory='" + IDHistory.ToString() + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
        }

        //Deleting History
        public void DeleteHistory(int IDHistory)
        {
            string query = "DELETE FROM History WHERE IDHistory='" + IDHistory + "'";

            SQLiteCommand command = new SQLiteCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

        }
    }
}
