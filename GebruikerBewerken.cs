using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GebruikerBewerken : Form
    {
        int id = Rights.id;
        string MyConnectionString2 = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public GebruikerBewerken()
        {
            InitializeComponent();
        }
        private void BtnVerzenden_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(MyConnectionString2))
            {
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("UPDATE tbl_EmailAdress SET Email=@email, Voornaam=@voornaam, Achternaam=@achternaam, Tussenvoegsel=@tussenvoegsel WHERE id=@id");
                    cmd.Parameters.AddWithValue("@email", TxbEmail.Text);
                    cmd.Parameters.AddWithValue("@voornaam", txbVoornaam.Text);
                    cmd.Parameters.AddWithValue("@achternaam", TxbAchternaam.Text);
                    cmd.Parameters.AddWithValue("@tussenvoegsel", TxbTussenvoegsel.Text);
                    cmd.Parameters.AddWithValue("@id", TxbId.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    throw;
                }
                connection.Close();
                this.Close();
            }             
        }
        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gebruiker form2 = new Gebruiker();
            form2.Show();
        }
        private void GebruikerBewerken_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                SqlCommand command;
                connection2.Open();
                try
                {
                    command = connection2.CreateCommand();
                    command.CommandText = "SELECT * FROM tbl_EmailAdress WHERE Id=@Id";
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adap = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
                        string Email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                        string voornaam = Convert.ToString(ds.Tables[0].Rows[0]["voornaam"]);
                        string Achternaam = Convert.ToString(ds.Tables[0].Rows[0]["Achternaam"]);
                        string Tussenvoegsel = Convert.ToString(ds.Tables[0].Rows[0]["Tussenvoegsel"]);
                        TxbEmail.Text = Email;
                        txbVoornaam.Text = voornaam;
                        TxbAchternaam.Text = Achternaam;
                        TxbTussenvoegsel.Text = Tussenvoegsel;
                        TxbId.Text = Convert.ToString(id);
                    }
                }
                catch (Exception /*E*/)
                {
                    MessageBox.Show("Error gebruiker(s) opvragen.");
                    //MessageBox.Show(E.Message);
                }
            }              
        }
    }
}
