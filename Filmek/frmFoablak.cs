using System.Data;

namespace Filmek
    {
    public partial class frmFoablak : Form
        {

        public frmFoablak()
            {
            InitializeComponent();
            Betolt();
            }

        private void Letrehoz()
            {
            dsFilmek.dtFilm.AdddtFilmRow(1, "Vérapó", "2022.12.01", "Tommy Wirkola", "Pat Casey, Josh Miller");
            dsFilmek.dtFilm.AdddtFilmRow(2, "Fekete Özvegy", "2021.07.09", "Cate Shortland", "Eric Pearson");
            dsFilmek.dtSzinesz.AdddtSzineszRow(1, "David Harbour", "1975.04.10");
            dsFilmek.dtSzinesz.AdddtSzineszRow(2, "Beverly D'Angelo", "1951.11.15");
            dsFilmek.dtSzinesz.AdddtSzineszRow(3, "John Leguizamo", "1960.06.22");
            dsFilmek.dtSzinesz.AdddtSzineszRow(4, "Scarlett Johansson", "1984.11.22");
            dsFilmek.dtSzinesz.AdddtSzineszRow(5, "Florence Pugh", "1996.01.03");
            dsFilmek.dtMufaj.AdddtMufajRow(1, "Horror");
            dsFilmek.dtMufaj.AdddtMufajRow(2, "Vígjáték");
            dsFilmek.dtMufaj.AdddtMufajRow(3, "Akció");
            dsFilmek.dtMufaj.AdddtMufajRow(4, "Thriller");
            dsFilmek.dtMufaj.AdddtMufajRow(5, "Romantikus");
            dsFilmek.dtMufaj.AdddtMufajRow(6, "Dokumentum");
            dsFilmek.dtNyelv.AdddtNyelvRow(1, "Magyar");
            dsFilmek.dtNyelv.AdddtNyelvRow(2, "Angol");
            dsFilmek.dtNyelv.AdddtNyelvRow(3, "Német");
            dsFilmek.dtNyelv.AdddtNyelvRow(4, "Francia");
            dsFilmek.dtNyelv.AdddtNyelvRow(5, "Orosz");
            dsFilmek.dtFSz.AdddtFSzRow(1, 1, 3, 1);
            dsFilmek.dtFSz.AdddtFSzRow(1, 2, 3, 1);
            dsFilmek.dtFSz.AdddtFSzRow(1, 3, 3, 1);
            dsFilmek.dtFSz.AdddtFSzRow(2, 4, 4, 2);
            dsFilmek.dtFSz.AdddtFSzRow(2, 5, 4, 2);
            dsFilmek.dtFSz.AdddtFSzRow(2, 1, 4, 2);
            }

        private void Lement()
            {
            dsFilmek.WriteXml("filmek.xml", XmlWriteMode.IgnoreSchema);
            }

        private void Betolt()
            {
            try
                {
                dsFilmek.ReadXml("filmek.xml", XmlReadMode.InferSchema);

                }
            catch (Exception)
                {
                Letrehoz();
                Lement();
                }
            }

        private void tsmiKilepes_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void tsmiFilmek_Click(object sender, EventArgs e)
            {
            //dgvUjSzinesz.Visible = false;
            dgvFilmek.Visible = true;
            ucUjSzinesz.Visible = false;
            dgvSzineszek.Visible = false;
            ucFilmek.Visible = false;
            dgvFilmek.Dock = DockStyle.Fill;


            var lista = from x in dsFilmek.dtFilm
                        select new
                            {
                            x.Cím,
                            x.Megjelenés,
                            x.Rendezõ,
                            x.Író,
                            Mûfaj = (from y in dsFilmek.dtFSz
                                     where y.IdFilm == x.Id
                                     join z in dsFilmek.dtMufaj
                                         on y.IdMûfaj equals z.Id
                                     select z.Mûfaj).Aggregate("",
                                            (s, val) => val),

                            Nyelv = (from y in dsFilmek.dtFSz
                                     where y.IdFilm == x.Id
                                     join z in dsFilmek.dtNyelv
                                         on y.IdNyelv equals z.Id
                                     select z.Nyelv).Aggregate("",
                                            (s, val) => val),

                            Szereplõk = (from y in dsFilmek.dtFSz
                                         where y.IdFilm == x.Id
                                         join z in dsFilmek.dtSzinesz
                                             on y.IdSzínész equals z.Id
                                         select z.Név).Aggregate("",
                                            (s, val) => s + (s.Length == 0 ? "" : ", ") + val)
                            };


            dgvFilmek.DataSource = lista.ToList();


            }

        private void tsmiSzineszek_Click(object sender, EventArgs e)
            {
            dgvFilmek.Visible = false;
            dgvSzineszek.Visible = true;
           // dgvUjSzinesz.Visible = false;
            ucUjSzinesz.Visible = false;
            ucFilmek.Visible = false;
            dgvSzineszek.Dock = DockStyle.Fill;

            var lista = from x in dsFilmek.dtSzinesz
                        select new
                            {
                            x.Id,
                            x.Név,
                            x.Születés
                            };
            dgvSzineszek.DataSource = lista.ToList();
            }

        private void tsmiNewActor_Click(object sender, EventArgs e)
            {

            dgvFilmek.Visible = false;
            dgvSzineszek.Visible = false;
            ucUjSzinesz.dsFilmek = dsFilmek;
           // dgvUjSzinesz.Visible = true;
            ucUjSzinesz.Visible = true;
            ucFilmek.Visible = false;
            ucUjSzinesz.Dock= DockStyle.Fill;

            var lista = from x in dsFilmek.dtSzinesz
                        select new
                            {
                            x.Id,
                            x.Név,
                            x.Születés
                            };
            dgvSzineszek.DataSource = lista.ToList();
            }



        

        private void tsmiUjFilm_Click(object sender, EventArgs e)
            {
            dgvFilmek.Visible = false;
            dgvSzineszek.Visible = false;
            ucUjSzinesz.Visible = false;
            ucFilmek.dsFilmek = dsFilmek;
            ucFilmek.Visible = true;
            ucFilmek.Dock= DockStyle.Fill;

            

            }

 


        }
    }