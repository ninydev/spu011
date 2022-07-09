using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Views
{
    public partial class FormLinq : Form
    {
        public static Data.ApplicationDbContext db = new Data.ApplicationDbContext();

        public FormLinq()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formTags = new FormTags();
            formTags.ShowDialog();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAuthors = new FormAuthors();
            formAuthors.ShowDialog();
        }

        private void auhtorByTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new AuthorByTags();
            f.ShowDialog();
        }

        private void ByCountryName()
        {
            string CountryName = "Ukraine";

            var C = db.Сountries.Where(c => c.Name == CountryName).First();
            var Cities = db.Cities.Include(c => c.Area)
                .Where(c => c.Area.CountryId == C.Id);

            var Cv2 = db.Cities.Include(c => c.Area)
                .Where(c => c.Area.CountryId == 
                    db.Сountries.Where(c => c.Name == CountryName).First().Id);

            var Cv3 = from c in db.Cities.Include(c=> c.Area)
                      where c.Area.CountryId == (
                        from co in db.Сountries
                        where co.Name == CountryName
                        select co.Id
                      ).First()
                      select c;
            /*
            SELECT Cities.Id, Cities.Name FROM Cities
                JOIN Areas ON Cities.AreaId = Areas.Id
                JOIN Counties ON Coutries.Id = Areas.CoutryId
                WHERE Coutries.Name = CountryName
            */

            //var Cities = db.Cities
            //    .Include(c=>c.Area)
            //    .ThenInclude(a=>a.Country)
            //    .Where(a => a.)
            //db.
            //Сountries.Where(c=> c.Name == CountryName).First()
            //.Areas.Include(a => a.Cities)

        }
    }
}
