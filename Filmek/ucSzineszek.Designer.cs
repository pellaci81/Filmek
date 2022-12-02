namespace Filmek
    {
    partial class ucSzineszek
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.lbSzineszNeve = new System.Windows.Forms.Label();
            this.lbSzineszSzuletes = new System.Windows.Forms.Label();
            this.tbSzulinap = new System.Windows.Forms.TextBox();
            this.btnUjSzinesz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(199, 61);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(325, 39);
            this.tbNev.TabIndex = 0;
            // 
            // lbSzineszNeve
            // 
            this.lbSzineszNeve.AutoSize = true;
            this.lbSzineszNeve.Location = new System.Drawing.Point(136, 64);
            this.lbSzineszNeve.Name = "lbSzineszNeve";
            this.lbSzineszNeve.Size = new System.Drawing.Size(57, 32);
            this.lbSzineszNeve.TabIndex = 1;
            this.lbSzineszNeve.Text = "Név";
            // 
            // lbSzineszSzuletes
            // 
            this.lbSzineszSzuletes.AutoSize = true;
            this.lbSzineszSzuletes.Location = new System.Drawing.Point(52, 132);
            this.lbSzineszSzuletes.Name = "lbSzineszSzuletes";
            this.lbSzineszSzuletes.Size = new System.Drawing.Size(141, 32);
            this.lbSzineszSzuletes.TabIndex = 2;
            this.lbSzineszSzuletes.Text = "Születésnap";
            // 
            // tbSzulinap
            // 
            this.tbSzulinap.Location = new System.Drawing.Point(199, 129);
            this.tbSzulinap.Name = "tbSzulinap";
            this.tbSzulinap.Size = new System.Drawing.Size(325, 39);
            this.tbSzulinap.TabIndex = 3;
            // 
            // btnUjSzinesz
            // 
            this.btnUjSzinesz.Location = new System.Drawing.Point(374, 245);
            this.btnUjSzinesz.Name = "btnUjSzinesz";
            this.btnUjSzinesz.Size = new System.Drawing.Size(150, 46);
            this.btnUjSzinesz.TabIndex = 4;
            this.btnUjSzinesz.Text = "Mentés";
            this.btnUjSzinesz.UseVisualStyleBackColor = true;
            this.btnUjSzinesz.Click += new System.EventHandler(this.btnUjSzinesz_Click);
            // 
            // ucSzineszek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUjSzinesz);
            this.Controls.Add(this.tbSzulinap);
            this.Controls.Add(this.lbSzineszSzuletes);
            this.Controls.Add(this.lbSzineszNeve);
            this.Controls.Add(this.tbNev);
            this.Name = "ucSzineszek";
            this.Size = new System.Drawing.Size(605, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private TextBox tbNev;
        private Label lbSzineszNeve;
        private Label lbSzineszSzuletes;
        private TextBox tbSzulinap;
        private Button btnUjSzinesz;
        }
    }
