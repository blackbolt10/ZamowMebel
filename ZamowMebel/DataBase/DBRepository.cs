using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamowMebel
{
    public class DBRepository
    {
        public static SqlConnection DBConnection = null;
        public static SqlConnection DBConnectionThread;
        private int Timeout = 240;
        

        public DBRepository()
        {
            if(DBConnection == null)
            {
                ConnectDataBase();
            }
        }

        public DBRepository(Int32 StartThreadConnection)
        {
            if(DBConnectionThread == null)
            {
                ConnectDataBaseThread();
            }
        }
        public Boolean ConnectDataBase()
        {
            Boolean connectionResult = false;
            ZamowMebel.Passwords passwords = new ZamowMebel.Passwords();

            try
            {
                String DBLogin = passwords.GetInstanceUserName();
                String DBPassword = passwords.GetInstancePassword();
                String DBInstance = passwords.GetInstanceName();
                String DBName = passwords.GetDataBaseName();

                DBConnection = new SqlConnection(@"user id=" + DBLogin + "; password=" + DBPassword + "; Data Source=" + DBInstance + "; Initial Catalog=" + DBName + ";");
                DBConnection.Open();
                connectionResult = true;
            }
            catch(Exception) { }

            return connectionResult;
        }

        internal bool LicencjonowanieForm_LoadLicenceRaportDGV(ref DataTable tempDT, ref string result)
        {
            throw new NotImplementedException();
        }

        public DataTable query(string queryString)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tempDataTable = new DataTable();

            SqlCommand SQLCommnad = new SqlCommand(queryString);
            SQLCommnad.CommandTimeout = Timeout;
            SQLCommnad.Connection = DBConnection;
            da = new SqlDataAdapter(SQLCommnad);

            da.Fill(tempDataTable);

            return tempDataTable;
        }

        public Boolean ConnectDataBaseThread()
        {
            Boolean connectionResult = false;
            ZamowMebel.Passwords passwords = new ZamowMebel.Passwords();

            try
            {
                String DBLogin = passwords.GetInstanceUserName();
                String DBPassword = passwords.GetInstancePassword();
                String DBInstance = passwords.GetInstanceName();
                String DBName = passwords.GetDataBaseName();

                DBConnectionThread = new SqlConnection(@"user id=" + DBLogin + "; password=" + DBPassword + "; Data Source=" + DBInstance + "; Initial Catalog=" + DBName + ";");
                DBConnectionThread.Open();
                DBConnectionThread.Close();
                connectionResult = true;
            }
            catch(Exception) { }

            return connectionResult;
        }

        public DataTable queryThread(string queryString)
        {
            DBConnectionThread.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tempDataTable = new DataTable();

            SqlCommand polecenieSQL = new SqlCommand(queryString);
            polecenieSQL.CommandTimeout = Timeout;
            polecenieSQL.Connection = DBConnection;
            da = new SqlDataAdapter(polecenieSQL);
            da.Fill(tempDataTable);

            DBConnectionThread.Close();

            return tempDataTable;
        }
    }
}
