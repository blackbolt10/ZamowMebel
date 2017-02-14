using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamowMebel
{
    public partial class OptimaApi : Form
    {
        protected static CDNBase.ApplicationClass Application = null;
        protected static CDNBase.ILogin Login = null;

        public static String nazwaOperatora = "";
        public static Int32 idOperatora = -1;
        public bool czyZamknac = true;

        public OptimaApi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Operator = "ADMIN";
            string Haslo = "";
            string Firma = "Demo";

            object[] hPar = new object[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            System.Environment.CurrentDirectory = @"C:\Program Files (x86)\Comarch ERP Optima";

            Application = new CDNBase.ApplicationClass();
            Application.LockApp(513, 5000, null, null, null, null);
            Login = Application.Login(Operator, Haslo, Firma, hPar[0], hPar[1], hPar[2], hPar[3], hPar[4], hPar[5], hPar[6], hPar[7], hPar[8], hPar[9], hPar[10], hPar[11], hPar[12], hPar[13], hPar[14], hPar[15], hPar[16]);

            label1.Text = "Baza: " + Login.Firm.Name.ToString();
            label1.Text += "\nFirm.User: " + Login.Firm.User.ToString();
            label1.Text += "\nFirm.Password: " + Login.Firm.Password.ToString();
            label1.Text += "\nFirm.SQLBaza: " + Login.Firm.Database.ToString();
            label1.Text += "\nFirm.Server: " + Login.Firm.Server.ToString();
            label1.Text += "\nFirm.OrgDostep: " + Login.Firm.OrgDostep.ToString();
            label1.Text += "\nFirm.State: " + Login.Firm.State.ToString();
            label1.Text += "\nFirm.LastBackupName: " + Login.Firm.LastBackupName.ToString();
            label1.Text += "\nFirm.Trusted_Connection: " + Login.Firm.Trusted_Connection.ToString();
            label1.Text += "\nFirm.Version: " + Login.Firm.Version.ToString();
            label1.Text += "\nApplication.FirstRun: " + Login.Application.FirstRun.ToString();
            label1.Text += "\nApplication.HASPUserName: " + Login.Application.HASPUserName.ToString();
            label1.Text += "\nApplication.HASPKeyNumber: " + Login.Application.HASPKeyNumber.ToString();
            label1.Text += "\nOperatorID: " + Login.OperatorID.ToString();
            label1.Text += "\nOperatorParam.Akronim: " + Login.OperatorParam.Akronim.ToString();
            label1.Text += "\nOperatorParam.Bank: " + Login.OperatorParam.Bank.ToString();
            label1.Text += "\nOperatorParam.BazStartowa: " + Login.OperatorParam.BazStartowa.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login = null;
            Application.UnlockApp();
            Application = null;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CDNBase.AdoSession Sesja = Login.CreateSession();

            CDNHlmn.DokumentyHaMag Faktury = (CDNHlmn.DokumentyHaMag)Sesja.CreateObject("CDN.DokumentyHaMag", null);
            CDNHlmn.IDokumentHaMag Faktura = (CDNHlmn.IDokumentHaMag)Faktury.AddNew(null);

            CDNBase.ICollection Kontrahenci = (CDNBase.ICollection)(Sesja.CreateObject("CDN.Kontrahenci", null));
            CDNHeal.IKontrahent Kontrahent = (CDNHeal.IKontrahent)Kontrahenci["Knt_KntID='" + kntIdTB.Text + "'"];

            CDNHeal.IKontrahent Odbiorca = (CDNHeal.IKontrahent)Kontrahenci["Knt_KntID='" + kntIdTB.Text + "'"];

            CDNBase.ICollection FormyPlatnosci = (CDNBase.ICollection)(Sesja.CreateObject("CDN.FormyPlatnosci", null));
            OP_KASBOLib.FormaPlatnosci FPl = (OP_KASBOLib.FormaPlatnosci)FormyPlatnosci[1];

            Faktura.Rodzaj = 308000;
            Faktura.TypDokumentu = 308;
            Faktura.Bufor = 1;

            Faktura.FormaPlatnosci = FPl;
            Faktura.Podmiot = (CDNHeal.IPodmiot)Kontrahent;
            Faktura.Odbiorca = (CDNHeal.IPodmiot)Odbiorca;

            Faktura.MagazynZrodlowyID = 1;

            int year = 2017;
            int month = 01;
            int day = 30;
            Faktura.DataDok = new DateTime(year, month, day);

            CDNBase.ICollection Pozycje = Faktura.Elementy;
            CDNHlmn.IElementHaMag Pozycja = (CDNHlmn.IElementHaMag)Pozycje.AddNew(null);
            Pozycja.TowarKod = twrKodTB.Text;
            Pozycja.Ilosc = Convert.ToDouble(iloscTB.Text);

            Pozycja = (CDNHlmn.IElementHaMag)Pozycje.AddNew(null);
            Pozycja.TowarKod = "TEST";
            Pozycja.Ilosc = 1;
            Pozycja.TowarOpis = "Czy to jest opis?";

            Sesja.Save();
            MessageBox.Show("Zrobione!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CDNBase.AdoSession Sesja = Login.CreateSession();

            CDNHlmn.DokumentyHaMag Faktury = (CDNHlmn.DokumentyHaMag)Sesja.CreateObject("CDN.DokumentyHaMag", null);
            CDNHlmn.IDokumentHaMag Faktura = (CDNHlmn.IDokumentHaMag)Faktury.AddNew(null);

            CDNBase.ICollection Kontrahenci = (CDNBase.ICollection)(Sesja.CreateObject("CDN.Kontrahenci", null));
            CDNHeal.IKontrahent Kontrahent = (CDNHeal.IKontrahent)Kontrahenci["Knt_KntID='" + kntIdTB.Text + "'"];

            CDNHeal.IKontrahent Odbiorca = (CDNHeal.IKontrahent)Kontrahenci["Knt_KntID='" + kntIdTB.Text + "'"];

            CDNBase.ICollection FormyPlatnosci = (CDNBase.ICollection)(Sesja.CreateObject("CDN.FormyPlatnosci", null));
            OP_KASBOLib.FormaPlatnosci FPl = (OP_KASBOLib.FormaPlatnosci)FormyPlatnosci[1];

            Faktura.Rodzaj = 302000;
            Faktura.TypDokumentu = 302;
            Faktura.Bufor = 1;

            Faktura.FormaPlatnosci = FPl;
            Faktura.Podmiot = (CDNHeal.IPodmiot)Kontrahent;
            Faktura.Odbiorca = (CDNHeal.IPodmiot)Odbiorca;

            Faktura.MagazynZrodlowyID = 1;

            int year = monthCalendar1.SelectionStart.Year;
            int month = monthCalendar1.SelectionStart.Month;
            int day = monthCalendar1.SelectionStart.Day;
            Faktura.DataDok = new DateTime(year, month, day);

            CDNBase.ICollection Pozycje = Faktura.Elementy;
            CDNHlmn.IElementHaMag Pozycja = (CDNHlmn.IElementHaMag)Pozycje.AddNew(null);
            Pozycja.TowarKod = twrKodTB.Text;
            Pozycja.Ilosc = Convert.ToDouble(iloscTB.Text);

            Sesja.Save();
            MessageBox.Show("Zrobione!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
