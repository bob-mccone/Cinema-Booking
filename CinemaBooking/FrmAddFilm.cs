using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace CinemaBooking
{
    public partial class FrmAddFilm : Form
    {
        // Creating a connection string so we can connect to the database
        readonly string ConnString = ConfigurationManager.ConnectionStrings["CinemaBooking.Properties.Settings.movietheatreConnectionString"].ConnectionString;
        // SQL query string, use @parameters to stop sql injection
        readonly string Query = "INSERT into movietheatre.film (Title, RunTime, Genre, ReleaseDate, Rating, Director, Cast, Description) values(@Title, @RunTime, @Genre, @ReleaseDate, @Rating, @Director, @Cast, @Description);";
        // Assigning a variable as a MySqlConnection object
        MySqlConnection Con;
        // Assigning a variable as a MySqlCommand object
        MySqlCommand Cmd;
        public FrmAddFilm()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            AddFilmToDatabase();
        }

        private void AddFilmToDatabase()
        {
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
                        // Assigning the parameters with the text boxes
                        Cmd.Parameters.AddWithValue("@Title", TxtTitle.Text);
                        Cmd.Parameters.AddWithValue("@RunTime", TxtRunTime.Text);
                        Cmd.Parameters.AddWithValue("@Genre", TxtGenre.Text);
                        Cmd.Parameters.AddWithValue("@ReleaseDate", DtpReleaseDate.Value.Date);
                        Cmd.Parameters.AddWithValue("@Rating", TxtRating.Text);
                        Cmd.Parameters.AddWithValue("@Director", TxtDirector.Text);
                        Cmd.Parameters.AddWithValue("@Cast", TxtCast.Text);
                        Cmd.Parameters.AddWithValue("@Description", TxtDescription.Text);
                        // Execute the SQL command
                        Cmd.ExecuteNonQuery();
                        // Messagebox to say successful added to database
                        MessageBox.Show("Saved");
                        DialogResult = DialogResult.OK;
                    }
                    //If there is a problem, catch it
                    catch (Exception ex)
                    {
                        // And display error message
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
