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

            String DBLogin = passwords.GetInstanceUserName();
            String DBPassword = passwords.GetInstancePassword();
            String DBInstance = passwords.GetInstanceName();
            String DBName = passwords.GetDataBaseName();

            DBConnection = new SqlConnection(@"user id=" + DBLogin + "; password=" + DBPassword + "; Data Source=" + DBInstance + "; Initial Catalog=" + DBName + ";");
            DBConnection.Open();
            connectionResult = true;

            return connectionResult;
        }

        public DataTable Query(string queryString)
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

        public DataTable QueryThread(string queryString)
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

        public void ErrorReport(string modul, string message)
        {
            try
            {
                DateTime teraz = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                String nazwaKompOper = Environment.MachineName + "\\" + Environment.UserName;
                String zapytanie = "insert into GAL.GAL_Bledy values('" + modul + " - " + message + "', " + MainForm.idOperatora + ", '" + teraz.ToString() + "')";

                Query(zapytanie);
            }
            catch(Exception) { }
        }

        public bool LoginForm_GetAppVersion(ref string result)
        {
            String queryString = "SELECT TOP 1 UST_Wartosc FROM GAL.GAL_Ustawienia WHERE UST_Parametr = 'WersjaAplikacji'";

            try
            {
                DataTable tempDT = Query(queryString);

                if(tempDT.Rows.Count>0)
                {
                    result = tempDT.Rows[0][0].ToString();
                    return true;
                }
                else
                {
                    result = "Brak wpisu w tabeli.";
                    return false;
                }
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("LicencjonowanieForm_LoadLicenceRaportDGV()", result);
                return false;
            }
        }

        public bool LicencjonowanieForm_LoadLicenceRaportDGV(ref DataTable tempDT, ref string result)
        {
            String queryString = "select SES_XlLogin [Login], SES_WindowsUser [User], convert(smalldatetime, SES_DataOd) [Start], datediff(s, ses_dataAkt, getdate()) [Czas przeterminowania (s)] from gal.Sesje_new where SES_DataDO is null and datediff(s, ses_dataAkt, getdate())>300";

            try
            {
                tempDT = Query(queryString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("LicencjonowanieForm_LoadLicenceRaportDGV()", result);
                return false;
            }
        }

        public bool LicencjonowanieForm_CutInactiveSessions(ref string result)
        {
            String queryString = "update gal.Sesje_new set SES_DataDO=getdate(), SES_Aktywna=3 where SES_DataDO is null and datediff(s, ses_dataAkt, getdate())>300";

            try
            {
                Query(queryString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("LicencjonowanieForm_CutInactiveSessions()", result);
                return false;
            }
        }

        public bool LoginForm_LoadOperatorCB(ref DataTable operatrzyDT, ref string result)
        {
            String queryString = "select * from GAL.GAL_Operatorzy where OPR_Archiwalny <> 1";

            try
            {
                operatrzyDT = Query(queryString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("LoginForm_LoadOperatorCB()", result);
                return false;
            }
        }
    }
}
