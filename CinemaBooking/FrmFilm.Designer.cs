
namespace CinemaBooking
{
    partial class FrmFilm
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
            this.components = new System.ComponentModel.Container();
            this.DGVFilm = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movietheatreDataSet = new CinemaBooking.movietheatreDataSet();
            this.filmTableAdapter = new CinemaBooking.movietheatreDataSetTableAdapters.filmTableAdapter();
            this.BtnAddFilm = new System.Windows.Forms.Button();
            this.BtnEditFilm = new System.Windows.Forms.Button();
            this.BtnDeleteFilm = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movietheatreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFilm
            // 
            this.DGVFilm.AllowUserToAddRows = false;
            this.DGVFilm.AllowUserToDeleteRows = false;
            this.DGVFilm.AutoGenerateColumns = false;
            this.DGVFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.runTimeDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.castDataGridViewTextBoxColumn,
            this.descrptionDataGridViewTextBoxColumn});
            this.DGVFilm.DataSource = this.filmBindingSource;
            this.DGVFilm.Location = new System.Drawing.Point(0, 0);
            this.DGVFilm.MultiSelect = false;
            this.DGVFilm.Name = "DGVFilm";
            this.DGVFilm.ReadOnly = true;
            this.DGVFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFilm.Size = new System.Drawing.Size(1290, 409);
            this.DGVFilm.TabIndex = 0;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "Film_id";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "Film_id";
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runTimeDataGridViewTextBoxColumn
            // 
            this.runTimeDataGridViewTextBoxColumn.DataPropertyName = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.HeaderText = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.Name = "runTimeDataGridViewTextBoxColumn";
            this.runTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castDataGridViewTextBoxColumn
            // 
            this.castDataGridViewTextBoxColumn.DataPropertyName = "Cast";
            this.castDataGridViewTextBoxColumn.HeaderText = "Cast";
            this.castDataGridViewTextBoxColumn.Name = "castDataGridViewTextBoxColumn";
            this.castDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrptionDataGridViewTextBoxColumn
            // 
            this.descrptionDataGridViewTextBoxColumn.DataPropertyName = "Descrption";
            this.descrptionDataGridViewTextBoxColumn.HeaderText = "Descrption";
            this.descrptionDataGridViewTextBoxColumn.Name = "descrptionDataGridViewTextBoxColumn";
            this.descrptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.movietheatreDataSet;
            // 
            // movietheatreDataSet
            // 
            this.movietheatreDataSet.DataSetName = "movietheatreDataSet";
            this.movietheatreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAddFilm
            // 
            this.BtnAddFilm.Location = new System.Drawing.Point(0, 415);
            this.BtnAddFilm.Name = "BtnAddFilm";
            this.BtnAddFilm.Size = new System.Drawing.Size(75, 23);
            this.BtnAddFilm.TabIndex = 1;
            this.BtnAddFilm.Text = "Add";
            this.BtnAddFilm.UseVisualStyleBackColor = true;
            this.BtnAddFilm.Click += new System.EventHandler(this.BtnAddFilm_Click);
            // 
            // BtnEditFilm
            // 
            this.BtnEditFilm.Location = new System.Drawing.Point(81, 415);
            this.BtnEditFilm.Name = "BtnEditFilm";
            this.BtnEditFilm.Size = new System.Drawing.Size(75, 23);
            this.BtnEditFilm.TabIndex = 2;
            this.BtnEditFilm.Text = "Edit";
            this.BtnEditFilm.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteFilm
            // 
            this.BtnDeleteFilm.Location = new System.Drawing.Point(162, 415);
            this.BtnDeleteFilm.Name = "BtnDeleteFilm";
            this.BtnDeleteFilm.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteFilm.TabIndex = 3;
            this.BtnDeleteFilm.Text = "Delete";
            this.BtnDeleteFilm.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(243, 415);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDeleteFilm);
            this.Controls.Add(this.BtnEditFilm);
            this.Controls.Add(this.BtnAddFilm);
            this.Controls.Add(this.DGVFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFilm";
            this.Text = "Films";
            this.Activated += new System.EventHandler(this.FrmFilm_Load);
            this.Load += new System.EventHandler(this.FrmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movietheatreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFilm;
        private movietheatreDataSet movietheatreDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private movietheatreDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnAddFilm;
        private System.Windows.Forms.Button BtnEditFilm;
        private System.Windows.Forms.Button BtnDeleteFilm;
        private System.Windows.Forms.Button BtnClose;
    }
}