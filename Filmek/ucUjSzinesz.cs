using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmek
    {
    public partial class ucUjSzinesz : UserControl
        {

        public dsFilmek? dsFilmek { get; set; }
        
        public ucUjSzinesz()
            {
            InitializeComponent();
            

            

            }




        private void btnUjSzinesz_Click(object sender, EventArgs e)
            {
            if (tbUjSzinNev.Text.Length == 0) return;
            if (dsFilmek == null) return;

            


            var Nev = tbUjSzinNev.Text;
            var Kor = tbUjSzinKor.Text;

            var maxSor = from Id in dsFilmek.dtSzinesz
                               select new { Id };
            dgvUjSzin.DataSource = maxSor.ToList();
            var maxRowCount = dgvUjSzin.Rows.GetRowCount(DataGridViewElementStates.Visible);

            if (maxRowCount == 0) return;

            var res = from sor in dsFilmek.dtSzinesz
                      where sor.Név == Nev
                      select sor;


            if (res.Count() > 0)
                {
                MessageBox.Show("Már van ilyen nevű színész");
                
                return;
                }
            else
                {

                maxRowCount += 1;

                dsFilmek.dtSzinesz.AdddtSzineszRow(maxRowCount, Nev, Kor);
            }
            var lista = from x in dsFilmek.dtSzinesz
                        select new
                            {
                            x.Id,
                            x.Név,
                            x.Születés
                            };

            dgvUjSzin.DataSource = lista.ToList();


            tbUjSzinNev.Text = "";
            tbUjSzinKor.Text = "";
            MessageBox.Show("Sikeres bevitel a " + maxRowCount + ". sorba.");

            

            }

        private void btnTorol_Click(object sender, EventArgs e)
            {

            }

        private void cbTorol_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (cbTorol.SelectedIndex != 0) 
                {

                tbNevMod.Text = cbTorol.Text;
                }

            }

        private void ucUjSzinesz_VisibleChanged(object sender, EventArgs e)
            {
            
            if (dsFilmek == null) return;

            var lista = from x in dsFilmek.dtSzinesz
                        select new
                            {
                            x.Id,
                            x.Név,
                            x.Születés
                            };

            dgvUjSzin.DataSource = lista.ToList();

            cbTorol.DataSource = dsFilmek.dtSzinesz;
            cbTorol.DisplayMember = "Név";






            }


        }

    }
