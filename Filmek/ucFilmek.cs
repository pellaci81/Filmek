using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmek
    {
    public partial class ucFilmek : UserControl
        {


        public dsFilmek? dsFilmek { get; set; }
        public ucFilmek()
            {
            InitializeComponent();
            }


        private void lekerdez()
            {
            if (!Visible || dsFilmek == null) return;
            dgvUjFilm.Visible = true;
            var filmek = from x in dsFilmek.dtFilm
                         select new
                             {
                             x.Cím,
                             x.Megjelenés,
                             x.Rendező,
                             x.Író,
                             Műfaj = (from y in dsFilmek.dtFSz
                                      where y.IdFilm == x.Id
                                      join z in dsFilmek.dtMufaj
                                          on y.IdMűfaj equals z.Id
                                      select z.Műfaj).Aggregate("", (s, val) => val),

                             Nyelv = (from y in dsFilmek.dtFSz
                                      where y.IdFilm == x.Id
                                      join z in dsFilmek.dtNyelv
                                          on y.IdNyelv equals z.Id
                                      select z.Nyelv).Aggregate("", (s, val) => val),

                             Szereplők = (from y in dsFilmek.dtFSz
                                          where y.IdFilm == x.Id
                                          join z in dsFilmek.dtSzinesz
                                              on y.IdSzínész equals z.Id
                                          select z.Név).Aggregate("",
                                          (s, val) => s + (s.Length == 0 ? "" : ", ") + val)
                             };

            dgvUjFilm.DataSource = filmek.ToList();

            tbCim.Text = "Vérapó 2";
            tbMegjelenes.Text = "2022";
            tbRendezo.Text = "rendező";
            tbIro.Text = "író";
            cbFoszereplo.Text = "szereplő";
            cbMufaj.Text = "műfaj";
            cbNyelv.Text = "nyelv";

            

            cbFoszereplo.DataSource = dsFilmek.dtSzinesz;
            cbFoszereplo.DisplayMember = "Név";
            cbFoszereplo.ValueMember = "Id";
            cbFoszereplo.SelectedIndex = 0;
            libSzereplo.DataSource = dsFilmek.dtSzinesz;
            libSzereplo.DisplayMember = "Id";
            

            cbMufaj.DataSource = dsFilmek.dtMufaj;
            cbMufaj.DisplayMember = "Műfaj";
            cbMufaj.ValueMember = "Id";
            cbMufaj.SelectedIndex = 0;
            libMufaj.DataSource = dsFilmek.dtMufaj;
            libMufaj.DisplayMember= "Id";

            cbNyelv.DataSource = dsFilmek.dtNyelv;
            cbNyelv.DisplayMember = "Nyelv";
            cbNyelv.SelectedIndex = 0;
            libNyelv.DataSource= dsFilmek.dtNyelv;
            libNyelv.DisplayMember = "Id";
            }


        private void ucFilmek_VisibleChanged(object sender, EventArgs e)
            {

            lekerdez();

            


            }

        private void btnUjFilm_Click(object sender, EventArgs e)
            {
            if (tbCim.Text.Length == 0) return;
            if (!Visible || dsFilmek == null) return;

            var indSzinesz = Int32.Parse(libSzereplo.Text);
            var indMufaj = Int32.Parse(libMufaj.Text);
            var indNyelv = Int32.Parse(libNyelv.Text);


            dgvUjFilm.Visible= false;
            var filmekMaxSor = from Id in dsFilmek.dtFilm
                               select new { Id };
            dgvUjFilm.DataSource = filmekMaxSor.ToList();
            var FilmekMaxRowCount = dgvUjFilm.Rows.GetRowCount(DataGridViewElementStates.Visible);

            if (FilmekMaxRowCount == 0) return;

            var Film = tbCim.Text;

            var res = from sor in dsFilmek.dtFilm
                      where sor.Cím == Film
                      select sor;


            if (res.Count() > 0)
                {
                MessageBox.Show("Már van ilyen című film");
                lekerdez();
                return;
                }
            else
                {
                var Szinesz1 = cbFoszereplo.Text;

                FilmekMaxRowCount += 1;

                dsFilmek.dtFilm.AdddtFilmRow(FilmekMaxRowCount, tbCim.Text, tbMegjelenes.Text, tbRendezo.Text, tbIro.Text);
                dsFilmek.dtFSz.AdddtFSzRow(FilmekMaxRowCount, indSzinesz ,indMufaj ,indNyelv);

                lekerdez();

                MessageBox.Show("Hozzáadva a listához. Sor száma: " + FilmekMaxRowCount);

                }



            }
        }
    }
