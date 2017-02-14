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

        public bool DzialyForm_ZaladujDzialyDGV(ref DataTable pomDataTable, bool @checked, ref string result)
        {
            String zapytanie = "SELECT * FROM GAL.GAL_Dzialy";
            if(!@checked)
            {
                zapytanie += " where DZI_Archiwalny <> 1";
            }

            try
            {
                pomDataTable = Query(zapytanie);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("DzialyForm_ZaladujDzialyDGV()", result);
                return false;
            }
        }

        public bool DzialyChangeForm_AddDzial(string nazwa, string archiwalny, ref string result)
        {
            String zapytanieString = "INSERT INTO GAL.GAL_Dzialy VALUES ('" + nazwa + "', getdate(), " + archiwalny + ")";
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("DzialyChangeForm_AddDzial()", exc.Message);
                return false;
            }
        }

        public bool StatusyForm_ZaladujStatusyDGV(ref DataTable pomDataTable, bool @checked, ref string result)
        {
            String zapytanie = "SELECT * FROM GAL.GAL_Statusy";
            if(!@checked)
            {
                zapytanie += " where STT_Archiwalny <> 1";
            }

            try
            {
                pomDataTable = Query(zapytanie);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("StatusyForm_ZaladujStatusyDGV()", result);
                return false;
            }
        }

        public bool StatusyForm_UsunStatus(string STT_SttId, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Statusy SET STT_Archiwalny = 1 WHERE STT_SttId =" + STT_SttId;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("StatusyForm_UsunAkord()", exc.Message);
                return false;
            }
        }

        public bool DzialyForm_UsunDzial(string DZI_DziId, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Dzialy SET DZI_Archiwalny = 1 WHERE DZI_DziId =" + DZI_DziId;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("DzialyForm_UsunDzial()", exc.Message);
                return false;
            }
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

        public bool OperatorzyForm_ZaladujOperatorzyDGV(ref DataTable pomDataTable, bool @checked, ref string result)
        {
            String zapytanie = "SELECT * FROM GAL.GAL_Operatorzy where OPR_OprId <> 1";
            if(!@checked)
            {
                zapytanie += " and OPR_Archiwalny <> 1";
            }

            try
            {
                pomDataTable = Query(zapytanie);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyForm_ZaladujOperatorzyDGV()", result);
                return false;
            }
        }

        public bool OperatorzyChangeForm_ZaladujDzialyCB(ref DataTable dzialyDT, ref string result)
        {
            String zapytanie = "SELECT * FROM GAL.GAL_Dzialy where DZI_Archiwalny <> 1";

            try
            {
                dzialyDT = Query(zapytanie);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyChangeForm_ZaladujDzialyCB()", result);
                return false;
            }
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

        public bool OperatorzyChangeForm_AddNewOperator(string imie, string nazwisko, string dziId, int uprawnienia, string archiwalny, ref string result)
        {
            String zapytanieString = "INSERT INTO GAL.GAL_Operatorzy VALUES ('" + imie + "', '" + nazwisko + "', '', "+dziId+", " + uprawnienia + ", " + archiwalny + ")";
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyChangeForm_AddNewOperator()", exc.Message);
                return false;
            }
        }

        public bool StatusyChangeForm_AddAkord(string nazwa, string archiwalny, ref string result)
        {
            String zapytanieString = "INSERT INTO GAL.GAL_Statusy VALUES ('" + nazwa + "', getdate(), "+archiwalny+")";
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("StatusyChangeForm_AddAkord()", exc.Message);
                return false;
            }
        }

        public bool StatusyChangeForm_ChangeAkord(string sTT_SttId, string nazwa, string archiwalny, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Statusy SET STT_Nazwa = '" + nazwa + "', STT_Archiwalny = " + archiwalny + " WHERE STT_SttId = " + sTT_SttId;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("StatusyChangeForm_ChangeAkord()", exc.Message);
                return false;
            }
        }

        public bool DzialyChangeForm_ChangeDzial(string dZI_DziId, string nazwa, string archiwalny, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Dzialy SET DZI_Nazwa = '" + nazwa + "', DZI_Archiwalny = " + archiwalny + " WHERE DZI_DziId = " + dZI_DziId;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("DzialyChangeForm_ChangeDzial()", exc.Message);
                return false;
            }
        }

        public bool OperatorzyChangeForm_ChangeOperator(string oPR_OprId, string imie, string nazwisko, string dziId, int uprawnienia, string archiwalny, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Operatorzy SET OPR_Imie = '" + imie + "',OPR_Nazwisko = '" + nazwisko + "', OPR_Dzial= "+dziId+ ", OPR_Uprawnienia = " + uprawnienia + " ,OPR_Archiwalny = " + archiwalny + " WHERE OPR_OprId = " + oPR_OprId;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyChangeForm_ChangeOperator()", exc.Message);
                return false;
            }
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

        public bool OperatorzyForm_UsunOperatora(string IDOperatora, ref string result)
        {
            String zapytanieString = "UPDATE GAL.GAL_Operatorzy SET OPR_Archiwalny = 1 WHERE OPR_OprId =" + IDOperatora;
            try
            {
                Query(zapytanieString);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyForm_UsunOperatora()", exc.Message);
                return false;
            }
        }

        public void ErrorReport(string modul, string message)
        {
            try
            {
                DateTime teraz = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                String nazwaKompOper = Environment.MachineName + "\\" + Environment.UserName;
                String zapytanie = "insert into GAL.GAL_Bledy values('" + modul + " - " + message + "', " + OptimaApi.idOperatora + ", '" + teraz.ToString() + "')";

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

        public bool OperatorzyForm_UsunHasloOperatora(string opr_OprId, ref string result)
        {
            String zapytanie = "UPDATE GAL.GAL_Operatorzy SET OPR_Haslo = '' WHERE OPR_OprId = " + opr_OprId;
            try
            {
                Query(zapytanie);
                return true;
            }
            catch(Exception exc)
            {
                result = exc.Message;
                ErrorReport("OperatorzyForm_UsunHasloOperatora()", result);
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
