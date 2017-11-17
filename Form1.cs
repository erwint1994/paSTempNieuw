using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Properties;


namespace WindowsFormsApp1
{
    public partial class Temperatuur : Form
    {
        Timer timer = new Timer();
        Label label = new Label();
        int timeLeft = 60;
        string MyConnectionString2 = ("user id=AH\\erwin;" +
                               "password=password;server=PC-PETEROKKER\\SQLEXPRESS;" +
                               "Trusted_Connection=yes;" +
                               "database=dbTemp; " +
                               "connection timeout=30");
        public Temperatuur()
        {
            InitializeComponent();
        }

        private void DoTemperatuur()
        {
            string locatie = TbLocatie.Text;
            var ping = new System.Net.NetworkInformation.Ping();
            var result = ping.Send("192.168.17.103");
            if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
            {
                MessageBox.Show("Controleer u verbinding!");
            }
            string html = string.Empty;
            string url = @"http://tcw122b-cm/status.xml?a=admin:admin&r1=1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                html = WebUtility.HtmlDecode(html);
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(html);
            XmlNodeList xmlList = xmlDoc.DocumentElement.GetElementsByTagName("Temperature1");

            DateTime myDateTime = DateTime.Now;
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            SqlCommand cmd;
            connection.Open();
            try
            {
                int i = 0;
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO dbo.tbl_Temperatuur(Temperature,DateTime,Location)VALUES(@Temperature,@DateTime,@Location)";
                cmd.Parameters.AddWithValue("@Temperature", xmlList[i].InnerXml);
                cmd.Parameters.AddWithValue("@DateTime", myDateTime);
                cmd.Parameters.AddWithValue("@Location", locatie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    LoadData2();
                }
            }         
        }

        // gegevens worden opgehaald en verzonden naar datagrid: 'overzicht'
        private void LoadData2()
        {
            SqlConnection connection = new SqlConnection(MyConnectionString2);
            connection.Open();
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM temperatuur ORDER BY id DESC";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                DgvOverzicht.DataSource = ds.Tables[0].DefaultView;               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }     
  
        // laatste ingevoerde locatie wordt opgeslagen als applicatie wordt geopent
        private void Temperatuur_Load(object sender, EventArgs e)
        {
            TbLocatie.Text = Properties.Settings.Default.TbLocatie;
        }
        private void Temperatuur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.TbLocatie = TbLocatie.Text;
            Properties.Settings.Default.Save();
        }

        // button locatie
        private void BtnLocatieSensorOpslaan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Locatie opgeslagen");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }
    } 
}