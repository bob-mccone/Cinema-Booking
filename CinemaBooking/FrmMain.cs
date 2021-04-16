using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBooking
{
    public partial class FrmMain : Form
    {
        private FrmFilm _FilmForm = new FrmFilm();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFilm_Click(object sender, EventArgs e)
        {
            _FilmForm.ShowDialog();
        }
    }
}
