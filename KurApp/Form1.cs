using System.Xml;

namespace KurApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime today = DateTime.Now;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime yesterday = today.AddDays(-1);
            string formattedDate = yesterday.ToString("dd-MM-yyyy");
            string exchangeRate = $"https://evds2.tcmb.gov.tr/service/evds/series=TP.DK.USD.A-TP.DK.EUR.A-TP.DK.CHF.A-TP.DK.GBP.A-TP.DK.JPY.A&startDate={formattedDate}&endDate={formattedDate}&type=xml&key=N5ZetAfwcG";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            lbl_usd.Text = xmlDoc.SelectSingleNode("/document/items/TP_DK_USD_A").InnerText;
            lbl_eur.Text = xmlDoc.SelectSingleNode("/document/items/TP_DK_EUR_A").InnerText;
            lbl_gbp.Text = xmlDoc.SelectSingleNode("/document/items/TP_DK_GBP_A").InnerText;
            lbl_chf.Text = xmlDoc.SelectSingleNode("/document/items/TP_DK_CHF_A").InnerText;
            lbl_jpy.Text = xmlDoc.SelectSingleNode("/document/items/TP_DK_JPY_A").InnerText;
        }

    }
}
