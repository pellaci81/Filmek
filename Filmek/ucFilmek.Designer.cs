namespace Filmek
    {
    partial class ucFilmek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.lbCim = new System.Windows.Forms.Label();
            this.lbMegjelenes = new System.Windows.Forms.Label();
            this.lbRendezo = new System.Windows.Forms.Label();
            this.lbIro = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbMegjelenes = new System.Windows.Forms.TextBox();
            this.tbRendezo = new System.Windows.Forms.TextBox();
            this.tbIro = new System.Windows.Forms.TextBox();
            this.btnUjFilm = new System.Windows.Forms.Button();
            this.lbSzereplo = new System.Windows.Forms.Label();
            this.dgvUjFilm = new System.Windows.Forms.DataGridView();
            this.lbMufaj = new System.Windows.Forms.Label();
            this.lbNyelv = new System.Windows.Forms.Label();
            this.cbFoszereplo = new System.Windows.Forms.ComboBox();
            this.cbMufaj = new System.Windows.Forms.ComboBox();
            this.cbNyelv = new System.Windows.Forms.ComboBox();
            this.libSzereplo = new System.Windows.Forms.ListBox();
            this.libMufaj = new System.Windows.Forms.ListBox();
            this.libNyelv = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCim
            // 
            this.lbCim.AutoSize = true;
            this.lbCim.Location = new System.Drawing.Point(158, 47);
            this.lbCim.Name = "lbCim";
            this.lbCim.Size = new System.Drawing.Size(117, 32);
            this.lbCim.TabIndex = 0;
            this.lbCim.Text = "Film címe";
            this.lbCim.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMegjelenes
            // 
            this.lbMegjelenes.AutoSize = true;
            this.lbMegjelenes.Location = new System.Drawing.Point(78, 99);
            this.lbMegjelenes.Name = "lbMegjelenes";
            this.lbMegjelenes.Size = new System.Drawing.Size(197, 32);
            this.lbMegjelenes.TabIndex = 1;
            this.lbMegjelenes.Text = "Megjelenés ideje";
            this.lbMegjelenes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRendezo
            // 
            this.lbRendezo.AutoSize = true;
            this.lbRendezo.Location = new System.Drawing.Point(169, 154);
            this.lbRendezo.Name = "lbRendezo";
            this.lbRendezo.Size = new System.Drawing.Size(106, 32);
            this.lbRendezo.TabIndex = 2;
            this.lbRendezo.Text = "Rendező";
            this.lbRendezo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbIro
            // 
            this.lbIro.AutoSize = true;
            this.lbIro.Location = new System.Drawing.Point(233, 210);
            this.lbIro.Name = "lbIro";
            this.lbIro.Size = new System.Drawing.Size(42, 32);
            this.lbIro.TabIndex = 3;
            this.lbIro.Text = "Író";
            this.lbIro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(281, 44);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(566, 39);
            this.tbCim.TabIndex = 4;
            // 
            // tbMegjelenes
            // 
            this.tbMegjelenes.Location = new System.Drawing.Point(281, 96);
            this.tbMegjelenes.Name = "tbMegjelenes";
            this.tbMegjelenes.Size = new System.Drawing.Size(566, 39);
            this.tbMegjelenes.TabIndex = 5;
            // 
            // tbRendezo
            // 
            this.tbRendezo.Location = new System.Drawing.Point(281, 151);
            this.tbRendezo.Name = "tbRendezo";
            this.tbRendezo.Size = new System.Drawing.Size(566, 39);
            this.tbRendezo.TabIndex = 6;
            // 
            // tbIro
            // 
            this.tbIro.Location = new System.Drawing.Point(281, 207);
            this.tbIro.Name = "tbIro";
            this.tbIro.Size = new System.Drawing.Size(566, 39);
            this.tbIro.TabIndex = 7;
            // 
            // btnUjFilm
            // 
            this.btnUjFilm.Location = new System.Drawing.Point(697, 446);
            this.btnUjFilm.Name = "btnUjFilm";
            this.btnUjFilm.Size = new System.Drawing.Size(150, 46);
            this.btnUjFilm.TabIndex = 8;
            this.btnUjFilm.Text = "Mentés";
            this.btnUjFilm.UseVisualStyleBackColor = true;
            this.btnUjFilm.Click += new System.EventHandler(this.btnUjFilm_Click);
            // 
            // lbSzereplo
            // 
            this.lbSzereplo.AutoSize = true;
            this.lbSzereplo.Location = new System.Drawing.Point(146, 268);
            this.lbSzereplo.Name = "lbSzereplo";
            this.lbSzereplo.Size = new System.Drawing.Size(129, 32);
            this.lbSzereplo.TabIndex = 9;
            this.lbSzereplo.Text = "Főszereplő";
            // 
            // dgvUjFilm
            // 
            this.dgvUjFilm.AllowUserToAddRows = false;
            this.dgvUjFilm.AllowUserToDeleteRows = false;
            this.dgvUjFilm.AllowUserToOrderColumns = true;
            this.dgvUjFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUjFilm.Location = new System.Drawing.Point(3, 559);
            this.dgvUjFilm.Name = "dgvUjFilm";
            this.dgvUjFilm.ReadOnly = true;
            this.dgvUjFilm.RowHeadersWidth = 82;
            this.dgvUjFilm.RowTemplate.Height = 41;
            this.dgvUjFilm.Size = new System.Drawing.Size(1922, 591);
            this.dgvUjFilm.TabIndex = 13;
            this.dgvUjFilm.Visible = false;
            // 
            // lbMufaj
            // 
            this.lbMufaj.AutoSize = true;
            this.lbMufaj.Location = new System.Drawing.Point(199, 326);
            this.lbMufaj.Name = "lbMufaj";
            this.lbMufaj.Size = new System.Drawing.Size(76, 32);
            this.lbMufaj.TabIndex = 14;
            this.lbMufaj.Text = "Műfaj";
            // 
            // lbNyelv
            // 
            this.lbNyelv.AutoSize = true;
            this.lbNyelv.Location = new System.Drawing.Point(199, 386);
            this.lbNyelv.Name = "lbNyelv";
            this.lbNyelv.Size = new System.Drawing.Size(75, 32);
            this.lbNyelv.TabIndex = 15;
            this.lbNyelv.Text = "Nyelv";
            // 
            // cbFoszereplo
            // 
            this.cbFoszereplo.FormattingEnabled = true;
            this.cbFoszereplo.Location = new System.Drawing.Point(281, 265);
            this.cbFoszereplo.Name = "cbFoszereplo";
            this.cbFoszereplo.Size = new System.Drawing.Size(566, 40);
            this.cbFoszereplo.TabIndex = 16;
            // 
            // cbMufaj
            // 
            this.cbMufaj.FormattingEnabled = true;
            this.cbMufaj.Location = new System.Drawing.Point(281, 323);
            this.cbMufaj.Name = "cbMufaj";
            this.cbMufaj.Size = new System.Drawing.Size(566, 40);
            this.cbMufaj.TabIndex = 17;
            // 
            // cbNyelv
            // 
            this.cbNyelv.FormattingEnabled = true;
            this.cbNyelv.Location = new System.Drawing.Point(281, 383);
            this.cbNyelv.Name = "cbNyelv";
            this.cbNyelv.Size = new System.Drawing.Size(566, 40);
            this.cbNyelv.TabIndex = 18;
            // 
            // libSzereplo
            // 
            this.libSzereplo.FormattingEnabled = true;
            this.libSzereplo.ItemHeight = 32;
            this.libSzereplo.Location = new System.Drawing.Point(1619, 652);
            this.libSzereplo.Name = "libSzereplo";
            this.libSzereplo.Size = new System.Drawing.Size(96, 196);
            this.libSzereplo.TabIndex = 19;
            this.libSzereplo.Visible = false;
            // 
            // libMufaj
            // 
            this.libMufaj.FormattingEnabled = true;
            this.libMufaj.ItemHeight = 32;
            this.libMufaj.Location = new System.Drawing.Point(1429, 652);
            this.libMufaj.Name = "libMufaj";
            this.libMufaj.Size = new System.Drawing.Size(96, 196);
            this.libMufaj.TabIndex = 20;
            this.libMufaj.Visible = false;
            // 
            // libNyelv
            // 
            this.libNyelv.FormattingEnabled = true;
            this.libNyelv.ItemHeight = 32;
            this.libNyelv.Location = new System.Drawing.Point(1252, 652);
            this.libNyelv.Name = "libNyelv";
            this.libNyelv.Size = new System.Drawing.Size(96, 196);
            this.libNyelv.TabIndex = 21;
            this.libNyelv.Visible = false;
            // 
            // ucFilmek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libNyelv);
            this.Controls.Add(this.libMufaj);
            this.Controls.Add(this.libSzereplo);
            this.Controls.Add(this.cbNyelv);
            this.Controls.Add(this.cbMufaj);
            this.Controls.Add(this.cbFoszereplo);
            this.Controls.Add(this.lbNyelv);
            this.Controls.Add(this.lbMufaj);
            this.Controls.Add(this.dgvUjFilm);
            this.Controls.Add(this.lbSzereplo);
            this.Controls.Add(this.btnUjFilm);
            this.Controls.Add(this.tbIro);
            this.Controls.Add(this.tbRendezo);
            this.Controls.Add(this.tbMegjelenes);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.lbIro);
            this.Controls.Add(this.lbRendezo);
            this.Controls.Add(this.lbMegjelenes);
            this.Controls.Add(this.lbCim);
            this.Name = "ucFilmek";
            this.Size = new System.Drawing.Size(1928, 1153);
            this.VisibleChanged += new System.EventHandler(this.ucFilmek_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label lbCim;
        private Label lbMegjelenes;
        private Label lbRendezo;
        private Label lbIro;
        private TextBox tbCim;
        private TextBox tbMegjelenes;
        private TextBox tbRendezo;
        private TextBox tbIro;
        private Button btnUjFilm;
        private Label lbSzereplo;
        private DataGridView dgvUjFilm;
        private Label lbMufaj;
        private Label lbNyelv;
        private ComboBox cbFoszereplo;
        private ComboBox cbMufaj;
        private ComboBox cbNyelv;
        private ListBox libSzereplo;
        private ListBox libMufaj;
        private ListBox libNyelv;
        }
    }
