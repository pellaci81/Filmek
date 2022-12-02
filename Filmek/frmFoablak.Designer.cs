namespace Filmek
    {
    partial class frmFoablak
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFilmekMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilmek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUjFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzereplokMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzineszek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUjSzineszek = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újMűfajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFilmek = new System.Windows.Forms.DataGridView();
            this.dgvSzineszek = new System.Windows.Forms.DataGridView();
            this.ucFilmek = new Filmek.ucFilmek();
            this.dsFilmek = new Filmek.dsFilmek();
            this.ucUjSzinesz = new Filmek.ucUjSzinesz();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzineszek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilmek)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilmekMenu,
            this.tsmiSzereplokMenu,
            this.beállításokToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.tsmiKilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1794, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFilmekMenu
            // 
            this.tsmiFilmekMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilmek,
            this.tsmiUjFilm});
            this.tsmiFilmekMenu.Name = "tsmiFilmekMenu";
            this.tsmiFilmekMenu.Size = new System.Drawing.Size(104, 36);
            this.tsmiFilmekMenu.Text = "Filmek";
            // 
            // tsmiFilmek
            // 
            this.tsmiFilmek.Name = "tsmiFilmek";
            this.tsmiFilmek.Size = new System.Drawing.Size(346, 44);
            this.tsmiFilmek.Text = "Filmek";
            this.tsmiFilmek.Click += new System.EventHandler(this.tsmiFilmek_Click);
            // 
            // tsmiUjFilm
            // 
            this.tsmiUjFilm.Name = "tsmiUjFilm";
            this.tsmiUjFilm.Size = new System.Drawing.Size(346, 44);
            this.tsmiUjFilm.Text = "Új film hozzáadása";
            this.tsmiUjFilm.Click += new System.EventHandler(this.tsmiUjFilm_Click);
            // 
            // tsmiSzereplokMenu
            // 
            this.tsmiSzereplokMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzineszek,
            this.tsmiUjSzineszek});
            this.tsmiSzereplokMenu.Name = "tsmiSzereplokMenu";
            this.tsmiSzereplokMenu.Size = new System.Drawing.Size(136, 36);
            this.tsmiSzereplokMenu.Text = "Színészek";
            // 
            // tsmiSzineszek
            // 
            this.tsmiSzineszek.Name = "tsmiSzineszek";
            this.tsmiSzineszek.Size = new System.Drawing.Size(380, 44);
            this.tsmiSzineszek.Text = "Színészek";
            this.tsmiSzineszek.Click += new System.EventHandler(this.tsmiSzineszek_Click);
            // 
            // tsmiUjSzineszek
            // 
            this.tsmiUjSzineszek.Name = "tsmiUjSzineszek";
            this.tsmiUjSzineszek.Size = new System.Drawing.Size(380, 44);
            this.tsmiUjSzineszek.Text = "Új színész hozzáadása";
            this.tsmiUjSzineszek.Click += new System.EventHandler(this.tsmiNewActor_Click);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újMűfajToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // újMűfajToolStripMenuItem
            // 
            this.újMűfajToolStripMenuItem.Name = "újMűfajToolStripMenuItem";
            this.újMűfajToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            this.újMűfajToolStripMenuItem.Text = "Adatok szerkesztése";
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // tsmiKilepes
            // 
            this.tsmiKilepes.Name = "tsmiKilepes";
            this.tsmiKilepes.Size = new System.Drawing.Size(110, 36);
            this.tsmiKilepes.Text = "Kilépés";
            this.tsmiKilepes.Click += new System.EventHandler(this.tsmiKilepes_Click);
            // 
            // dgvFilmek
            // 
            this.dgvFilmek.AllowUserToAddRows = false;
            this.dgvFilmek.AllowUserToDeleteRows = false;
            this.dgvFilmek.AllowUserToOrderColumns = true;
            this.dgvFilmek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmek.Location = new System.Drawing.Point(42, 828);
            this.dgvFilmek.Name = "dgvFilmek";
            this.dgvFilmek.ReadOnly = true;
            this.dgvFilmek.RowHeadersWidth = 82;
            this.dgvFilmek.RowTemplate.Height = 41;
            this.dgvFilmek.Size = new System.Drawing.Size(151, 142);
            this.dgvFilmek.TabIndex = 1;
            this.dgvFilmek.Visible = false;
            // 
            // dgvSzineszek
            // 
            this.dgvSzineszek.AllowUserToAddRows = false;
            this.dgvSzineszek.AllowUserToDeleteRows = false;
            this.dgvSzineszek.AllowUserToOrderColumns = true;
            this.dgvSzineszek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzineszek.Location = new System.Drawing.Point(273, 831);
            this.dgvSzineszek.Name = "dgvSzineszek";
            this.dgvSzineszek.ReadOnly = true;
            this.dgvSzineszek.RowHeadersWidth = 82;
            this.dgvSzineszek.RowTemplate.Height = 41;
            this.dgvSzineszek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSzineszek.Size = new System.Drawing.Size(145, 139);
            this.dgvSzineszek.TabIndex = 2;
            this.dgvSzineszek.Visible = false;
            // 
            // ucFilmek
            // 
            this.ucFilmek.dsFilmek = null;
            this.ucFilmek.Location = new System.Drawing.Point(1268, 650);
            this.ucFilmek.Name = "ucFilmek";
            this.ucFilmek.Size = new System.Drawing.Size(910, 575);
            this.ucFilmek.TabIndex = 3;
            this.ucFilmek.Visible = false;
            // 
            // dsFilmek
            // 
            this.dsFilmek.DataSetName = "dsFilmek";
            this.dsFilmek.Namespace = "http://tempuri.org/dsFilmek.xsd";
            this.dsFilmek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucUjSzinesz
            // 
            this.ucUjSzinesz.dsFilmek = null;
            this.ucUjSzinesz.Location = new System.Drawing.Point(463, 83);
            this.ucUjSzinesz.Name = "ucUjSzinesz";
            this.ucUjSzinesz.Size = new System.Drawing.Size(1028, 728);
            this.ucUjSzinesz.TabIndex = 5;
            this.ucUjSzinesz.Visible = false;
            // 
            // frmFoablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 1007);
            this.Controls.Add(this.ucUjSzinesz);
            this.Controls.Add(this.ucFilmek);
            this.Controls.Add(this.dgvSzineszek);
            this.Controls.Add(this.dgvFilmek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFoablak";
            this.Text = "Filmek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzineszek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilmek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private ucFilmek ucFilmek;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFilmekMenu;
        private ToolStripMenuItem tsmiFilmek;
        private ToolStripMenuItem tsmiUjFilm;
        private ToolStripMenuItem tsmiSzereplokMenu;
        private ToolStripMenuItem tsmiSzineszek;
        private ToolStripMenuItem tsmiUjSzineszek;
        private ToolStripMenuItem tsmiKilepes;
        private DataGridView dgvFilmek;
        private DataGridView dgvSzineszek;
        private dsFilmek dsFilmek;
        private ToolStripMenuItem beállításokToolStripMenuItem;
        private ToolStripMenuItem újMűfajToolStripMenuItem;
        private ToolStripMenuItem mentésToolStripMenuItem;
        private ucUjSzinesz ucUjSzinesz;
        }
    }