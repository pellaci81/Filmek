namespace Filmek
    {
    partial class ucUjSzinesz
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
            this.lbUjSzinesz = new System.Windows.Forms.Label();
            this.tbUjSzinNev = new System.Windows.Forms.TextBox();
            this.btnUjSzinesz = new System.Windows.Forms.Button();
            this.tbUjSzinKor = new System.Windows.Forms.TextBox();
            this.lbUjSzinKor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTorol = new System.Windows.Forms.ComboBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.dgvUjSzin = new System.Windows.Forms.DataGridView();
            this.tbNevMod = new System.Windows.Forms.TextBox();
            this.tbKorMod = new System.Windows.Forms.TextBox();
            this.btnModosit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjSzin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUjSzinesz
            // 
            this.lbUjSzinesz.AutoSize = true;
            this.lbUjSzinesz.Location = new System.Drawing.Point(69, 708);
            this.lbUjSzinesz.Name = "lbUjSzinesz";
            this.lbUjSzinesz.Size = new System.Drawing.Size(57, 32);
            this.lbUjSzinesz.TabIndex = 1;
            this.lbUjSzinesz.Text = "Név";
            // 
            // tbUjSzinNev
            // 
            this.tbUjSzinNev.Location = new System.Drawing.Point(132, 705);
            this.tbUjSzinNev.Name = "tbUjSzinNev";
            this.tbUjSzinNev.Size = new System.Drawing.Size(348, 39);
            this.tbUjSzinNev.TabIndex = 2;
            // 
            // btnUjSzinesz
            // 
            this.btnUjSzinesz.Location = new System.Drawing.Point(132, 912);
            this.btnUjSzinesz.Name = "btnUjSzinesz";
            this.btnUjSzinesz.Size = new System.Drawing.Size(150, 46);
            this.btnUjSzinesz.TabIndex = 3;
            this.btnUjSzinesz.Text = "Ment";
            this.btnUjSzinesz.UseVisualStyleBackColor = true;
            this.btnUjSzinesz.Click += new System.EventHandler(this.btnUjSzinesz_Click);
            // 
            // tbUjSzinKor
            // 
            this.tbUjSzinKor.Location = new System.Drawing.Point(132, 781);
            this.tbUjSzinKor.Name = "tbUjSzinKor";
            this.tbUjSzinKor.Size = new System.Drawing.Size(348, 39);
            this.tbUjSzinKor.TabIndex = 5;
            // 
            // lbUjSzinKor
            // 
            this.lbUjSzinKor.AutoSize = true;
            this.lbUjSzinKor.Location = new System.Drawing.Point(77, 784);
            this.lbUjSzinKor.Name = "lbUjSzinKor";
            this.lbUjSzinKor.Size = new System.Drawing.Size(49, 32);
            this.lbUjSzinKor.TabIndex = 4;
            this.lbUjSzinKor.Text = "Kor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Új színész";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(980, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Színész törlése, módosítása";
            // 
            // cbTorol
            // 
            this.cbTorol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTorol.FormattingEnabled = true;
            this.cbTorol.Location = new System.Drawing.Point(980, 639);
            this.cbTorol.Name = "cbTorol";
            this.cbTorol.Size = new System.Drawing.Size(356, 40);
            this.cbTorol.TabIndex = 9;
            this.cbTorol.SelectedIndexChanged += new System.EventHandler(this.cbTorol_SelectedIndexChanged);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(1186, 922);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(150, 46);
            this.btnTorol.TabIndex = 10;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // dgvUjSzin
            // 
            this.dgvUjSzin.AllowUserToAddRows = false;
            this.dgvUjSzin.AllowUserToDeleteRows = false;
            this.dgvUjSzin.AllowUserToOrderColumns = true;
            this.dgvUjSzin.ColumnHeadersHeight = 46;
            this.dgvUjSzin.Location = new System.Drawing.Point(3, 3);
            this.dgvUjSzin.Name = "dgvUjSzin";
            this.dgvUjSzin.ReadOnly = true;
            this.dgvUjSzin.RowHeadersWidth = 82;
            this.dgvUjSzin.RowTemplate.Height = 41;
            this.dgvUjSzin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUjSzin.Size = new System.Drawing.Size(1528, 474);
            this.dgvUjSzin.TabIndex = 11;
            // 
            // tbNevMod
            // 
            this.tbNevMod.Location = new System.Drawing.Point(980, 708);
            this.tbNevMod.Name = "tbNevMod";
            this.tbNevMod.Size = new System.Drawing.Size(356, 39);
            this.tbNevMod.TabIndex = 12;
            // 
            // tbKorMod
            // 
            this.tbKorMod.Location = new System.Drawing.Point(980, 781);
            this.tbKorMod.Name = "tbKorMod";
            this.tbKorMod.Size = new System.Drawing.Size(356, 39);
            this.tbKorMod.TabIndex = 13;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(980, 922);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(150, 46);
            this.btnModosit.TabIndex = 14;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 788);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(917, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Név";
            // 
            // ucUjSzinesz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.tbKorMod);
            this.Controls.Add(this.tbNevMod);
            this.Controls.Add(this.dgvUjSzin);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.cbTorol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUjSzinKor);
            this.Controls.Add(this.lbUjSzinKor);
            this.Controls.Add(this.btnUjSzinesz);
            this.Controls.Add(this.tbUjSzinNev);
            this.Controls.Add(this.lbUjSzinesz);
            this.Name = "ucUjSzinesz";
            this.Size = new System.Drawing.Size(1534, 1000);
            this.VisibleChanged += new System.EventHandler(this.ucUjSzinesz_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUjSzin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label lbUjSzinesz;
        private TextBox tbUjSzinNev;
        private Button btnUjSzinesz;
        private TextBox tbUjSzinKor;
        private Label lbUjSzinKor;
        private Label label1;
        private Label label2;
        private ComboBox cbTorol;
        private Button btnTorol;
        private DataGridView dgvUjSzin;
        private TextBox tbNevMod;
        private TextBox tbKorMod;
        private Button btnModosit;
        private Label label3;
        private Label label4;
        }
    }
