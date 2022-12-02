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
            dsFilmek.dtFilm.AdddtFilmRow(1, "V�rap�", "2022.12.01", "Tommy Wirkola", "Pat Casey, Josh Miller");
            dsFilmek.dtFilm.AdddtFilmRow(2, "Fekete �zvegy", "2021.07.09", "Cate Shortland", "Eric Pearson");
            dsFilmek.dtSzinesz.AdddtSzineszRow(1, "David Harbour", "1975.04.10");
            dsFilmek.dtSzinesz.AdddtSzineszRow(2, "Beverly D'Angelo", "1951.11.15");
            dsFilmek.dtSzinesz.AdddtSzineszRow(3, "John Leguizamo", "1960.06.22");
            dsFilmek.dtSzinesz.AdddtSzineszRow(4, "Scarlett Johansson", "1984.11.22");
            dsFilmek.dtSzinesz.AdddtSzineszRow(5, "Florence Pugh", "1996.01.03");
            dsFilmek.dtMufaj.AdddtMufajRow(1, "Horror");
            dsFilmek.dtMufaj.AdddtMufajRow(2, "V�gj�t�k");
            dsFilmek.dtMufaj.AdddtMufajRow(3, "Akci�");
            dsFilmek.dtMufaj.AdddtMufajRow(4, "Thriller");
            dsFilmek.dtMufaj.AdddtMufajRow(5, "Romantikus");
            dsFilmek.dtMufaj.AdddtMufajRow(6, "Dokumentum");
            dsFilmek.dtNyelv.AdddtNyelvRow(1, "Magyar");
            dsFilmek.dtNyelv.AdddtNyelvRow(2, "Angol");
            dsFilmek.dtNyelv.AdddtNyelvRow(3, "N�met");
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
                            x.C�m,
                            x.Megjelen�s,
                            x.Rendez�,
                            x.�r�,
                            M�faj = (from y in dsFilmek.dtFSz
                                     where y.IdFilm == x.Id
                                     join z in dsFilmek.dtMufaj
                                         on y.IdM�faj equals z.Id
                                     select z.M�faj).Aggregate("",
                                            (s, val) => val),

                            Nyelv = (from y in dsFilmek.dtFSz
                                     where y.IdFilm == x.Id
                                     join z in dsFilmek.dtNyelv
                                         on y.IdNyelv equals z.Id
                                     select z.Nyelv).Aggregate("",
                                            (s, val) => val),

                            Szerepl�k = (from y in dsFilmek.dtFSz
                                         where y.IdFilm == x.Id
                                         join z in dsFilmek.dtSzinesz
                                             on y.IdSz�n�sz equals z.Id
                                         select z.N�v).Aggregate("",
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
                            x.N�v,
                            x.Sz�let�s
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
                            x.N�v,
                            x.Sz�let�s
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