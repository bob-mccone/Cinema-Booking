
namespace CinemaBooking
{
    partial class FrmAddFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblRunTime = new System.Windows.Forms.Label();
            this.LblGenre = new System.Windows.Forms.Label();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.LblRating = new System.Windows.Forms.Label();
            this.LblDirector = new System.Windows.Forms.Label();
            this.LblCast = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtRunTime = new System.Windows.Forms.TextBox();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtRating = new System.Windows.Forms.TextBox();
            this.TxtDirector = new System.Windows.Forms.TextBox();
            this.TxtCast = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(360, 9);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(360, 38);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(57, 15);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Title";
            // 
            // LblRunTime
            // 
            this.LblRunTime.AutoSize = true;
            this.LblRunTime.Location = new System.Drawing.Point(31, 41);
            this.LblRunTime.Name = "LblRunTime";
            this.LblRunTime.Size = new System.Drawing.Size(53, 13);
            this.LblRunTime.TabIndex = 3;
            this.LblRunTime.Text = "Run Time";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Location = new System.Drawing.Point(48, 67);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(36, 13);
            this.LblGenre.TabIndex = 4;
            this.LblGenre.Text = "Genre";
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Location = new System.Drawing.Point(12, 96);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.LblReleaseDate.TabIndex = 5;
            this.LblReleaseDate.Text = "Release Date";
            // 
            // LblRating
            // 
            this.LblRating.AutoSize = true;
            this.LblRating.Location = new System.Drawing.Point(46, 119);
            this.LblRating.Name = "LblRating";
            this.LblRating.Size = new System.Drawing.Size(38, 13);
            this.LblRating.TabIndex = 6;
            this.LblRating.Text = "Rating";
            // 
            // LblDirector
            // 
            this.LblDirector.AutoSize = true;
            this.LblDirector.Location = new System.Drawing.Point(40, 145);
            this.LblDirector.Name = "LblDirector";
            this.LblDirector.Size = new System.Drawing.Size(44, 13);
            this.LblDirector.TabIndex = 7;
            this.LblDirector.Text = "Director";
            // 
            // LblCast
            // 
            this.LblCast.AutoSize = true;
            this.LblCast.Location = new System.Drawing.Point(56, 171);
            this.LblCast.Name = "LblCast";
            this.LblCast.Size = new System.Drawing.Size(28, 13);
            this.LblCast.TabIndex = 8;
            this.LblCast.Text = "Cast";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(24, 197);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 9;
            this.LblDescription.Text = "Description";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(90, 12);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(264, 20);
            this.TxtTitle.TabIndex = 10;
            // 
            // TxtRunTime
            // 
            this.TxtRunTime.Location = new System.Drawing.Point(90, 38);
            this.TxtRunTime.Name = "TxtRunTime";
            this.TxtRunTime.Size = new System.Drawing.Size(264, 20);
            this.TxtRunTime.TabIndex = 11;
            // 
            // TxtGenre
            // 
            this.TxtGenre.Location = new System.Drawing.Point(90, 64);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(264, 20);
            this.TxtGenre.TabIndex = 12;
            // 
            // TxtRating
            // 
            this.TxtRating.Location = new System.Drawing.Point(90, 116);
            this.TxtRating.Name = "TxtRating";
            this.TxtRating.Size = new System.Drawing.Size(264, 20);
            this.TxtRating.TabIndex = 13;
            // 
            // TxtDirector
            // 
            this.TxtDirector.Location = new System.Drawing.Point(90, 142);
            this.TxtDirector.Name = "TxtDirector";
            this.TxtDirector.Size = new System.Drawing.Size(264, 20);
            this.TxtDirector.TabIndex = 14;
            // 
            // TxtCast
            // 
            this.TxtCast.Location = new System.Drawing.Point(90, 168);
            this.TxtCast.Name = "TxtCast";
            this.TxtCast.Size = new System.Drawing.Size(264, 20);
            this.TxtCast.TabIndex = 15;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(90, 194);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(264, 20);
            this.TxtDescription.TabIndex = 16;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(90, 90);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(264, 20);
            this.DtpReleaseDate.TabIndex = 17;
            // 
            // FrmAddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 230);
            this.Controls.Add(this.DtpReleaseDate);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtCast);
            this.Controls.Add(this.TxtDirector);
            this.Controls.Add(this.TxtRating);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.TxtRunTime);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblCast);
            this.Controls.Add(this.LblDirector);
            this.Controls.Add(this.LblRating);
            this.Controls.Add(this.LblReleaseDate);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.LblRunTime);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAddFilm";
            this.Text = "Add Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblRunTime;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.Label LblRating;
        private System.Windows.Forms.Label LblDirector;
        private System.Windows.Forms.Label LblCast;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtRunTime;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox TxtRating;
        private System.Windows.Forms.TextBox TxtDirector;
        private System.Windows.Forms.TextBox TxtCast;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
    }
}