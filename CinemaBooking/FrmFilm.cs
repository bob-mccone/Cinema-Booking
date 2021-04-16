using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace CinemaBooking
{
    public partial class FrmFilm : Form
    {
        private FrmAddFilm _AddFilmForm = new FrmAddFilm();
        // Creating a connection string so we can connect to the database
        readonly string ConnString = ConfigurationManager.ConnectionStrings["CinemaBooking.Properties.Settings.movietheatreConnectionString"].ConnectionString;
        // SQL query string
        readonly string Query = "SELECT * FROM film";
        // Assigning a variable as a MySqlConnection object
        MySqlConnection Con;
        // Assigning a variable as a MySqlCommand object
        MySqlCommand Cmd;

        public FrmFilm()
        {
            InitializeComponent();
        }

        // When form loads
        private void FrmFilm_Load(object sender, EventArgs e)
        {
            // Call GetFilmList method
            DGVFilm.DataSource = GetFilmList();
        }

        // Creating a data table method called GetFilmList
        private DataTable GetFilmList()
        {
            // Instantiates a new data table called DTFilm
            DataTable DTFilm = new DataTable();
            
            // Creating a connection object
            using (Con = new MySqlConnection(ConnString))
            {
                // Creating an object that has a query and connection
                using (Cmd = new MySqlCommand(Query, Con))
                {
                    // Try the following
                    try
                    {
                        // Open the connection
                        Con.Open();
                        // Execute the SQL command
                        MySqlDataReader Reader = Cmd.ExecuteReader();
                        // Load the data into the data grid view
                        DTFilm.Load(Reader);  
                    }
                    // If there is a problem, catch it
                    catch (Exception ex)
                    {
                        // And display error message
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            // Display the data grid view
            return DTFilm;
        }

        private void BtnAddFilm_Click(object sender, EventArgs e)
        {
            _AddFilmForm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
