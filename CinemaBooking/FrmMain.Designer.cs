
namespace CinemaBooking
{
    partial class FrmMain
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
            this.BtnFilm = new System.Windows.Forms.Button();
            this.BtnBooking = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilm
            // 
            this.BtnFilm.Location = new System.Drawing.Point(119, 182);
            this.BtnFilm.Name = "BtnFilm";
            this.BtnFilm.Size = new System.Drawing.Size(75, 23);
            this.BtnFilm.TabIndex = 0;
            this.BtnFilm.Text = "Films";
            this.BtnFilm.UseVisualStyleBackColor = true;
            this.BtnFilm.Click += new System.EventHandler(this.BtnFilm_Click);
            // 
            // BtnBooking
            // 
            this.BtnBooking.Location = new System.Drawing.Point(456, 246);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Size = new System.Drawing.Size(75, 23);
            this.BtnBooking.TabIndex = 1;
            this.BtnBooking.Text = "Bookings";
            this.BtnBooking.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(584, 341);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnBooking);
            this.Controls.Add(this.BtnFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilm;
        private System.Windows.Forms.Button BtnBooking;
        private System.Windows.Forms.Button BtnClose;
    }
}

