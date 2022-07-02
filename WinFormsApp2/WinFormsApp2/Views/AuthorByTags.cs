using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Views
{
    public partial class AuthorByTags : Form
    {
        public static Data.ApplicationDbContext db;

        public AuthorByTags()
        {
            InitializeComponent();
            db = FormLinq.db;
            listBoxTags.Items.AddRange(db.Tags.ToArray());
            listBoxAuthors.Items.AddRange(db.Authors.ToArray());
        }

        //private void LoadAuthors()
        //{
        //    db = FormLinq.db;
        //    listBoxAuthors.Items.Clear();
        //    if (db.Authors != null)
        //        listBoxAuthors.Items.AddRange(db.Authors.ToArray());

        //}

        private void btnSearchOne_Click(object sender, EventArgs e)
        {
            var Tag = (Models.Tag)listBoxTags.SelectedItem;

            //var resA = db.Tags
            //    .Include(tag => tag.Authors)
            //    .Where(t => t.Id == Tag.Id)
            //    .First();
            //listBoxAuthors.Items.Clear();
            //listBoxAuthors.Items.AddRange(resA.Authors.ToArray());

            //var resC = (from tag in db.Tags.Include(t=>t.Authors) 
            //           where tag.Id == Tag.Id 
            //           select tag.Authors).ToArray();
            //listBoxAuthors.Items.Clear();
            //if (resC.Length > 0)
            //{
            //    foreach (var a in resC[0])
            //    {
            //        listBoxAuthors.Items.Add(a);
            //    }
            //}

            //foreach (var item in resC)
            //{
            //    listBoxAuthors.Items.Add(item);
            //}

            // listBoxAuthors.Items.AddRange(resC);



            //var resB = db.Authors
            //    .Include(au => au.Tags)
            //    .Where(a => a.Tags.Where(t => t.Id == Tag.Id).Any());
            //listBoxAuthors.Items.Clear();
            //listBoxAuthors.Items.AddRange(resB.ToArray());

            var resD = from a in db.Authors.Include(a => a.Tags)
                       where a.Tags.Contains(Tag)
                       orderby a.Title descending
                       select a;
            listBoxAuthors.Items.Clear();
            listBoxAuthors.Items.AddRange(resD.ToArray());






        }

        private void btnNoTags_Click(object sender, EventArgs e)
        {
            var resD = from a in db.Authors.Include(a => a.Tags)
                       where a.Tags.Count() == 0
                       orderby a.Title descending
                       select a;
            listBoxAuthors.Items.Clear();
            listBoxAuthors.Items.AddRange(resD.ToArray());
        }

        private void btnAnonim_Click(object sender, EventArgs e)
        {
            //var res = (from a in db.Authors.Include(a => a.Tags)
            //          where a.Tags.Count() > 0
            //          orderby a.Title descending
            //          select new { a.Title, a.Tags.Count, a.Tags}).ToList();
            //foreach (var item in res)
            //{
            //    string s  = item.Title + "(" + item.Count + ")";
            //    foreach( var t in item.Tags.ToArray())
            //    {
            //        s += " | " + t.Title;
            //    }
            //    listBoxAuthors.Items.Add(s);
            //}

            var res = (from a in db.Authors
                           .Include(a => a.Tags)
                           .Include(a=>a.Posts)
                       where a.Tags.Count() > 0
                       orderby a.Title descending
                       select new { a.Title, cp = a.Posts.Count, tc = a.Tags.Count}).ToList();
            foreach (var item in res)
            {
                string s = item.Title + "(" + item.cp + " => " +  item.tc +  ")";
                //foreach (var t in item.Tags.ToArray())
                //{
                //    s += " | " + t.Title;
                //}
                listBoxAuthors.Items.Add(s);
            }
        }
    }
}
