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
    public partial class FormAuthors : Form
    {
        public static Data.ApplicationDbContext db;

        public FormAuthors()
        {
            InitializeComponent();
            db = FormLinq.db;
            LoadAuthors();
            listBoxTags.Items.AddRange(db.Tags.ToArray());
        }


        private void LoadAuthors()
        {
            db = FormLinq.db;
            listBoxAuthors.Items.Clear();
            if(db.Authors != null)  
            listBoxAuthors.Items.AddRange(db.Authors.ToArray());

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text.Length == 0)
            {
                MessageBox.Show("Введите имя автора");
                return;
            }
            try
            {
                var tagsEl = listBoxTags.SelectedItems;
                var tags = new List<Models.Tag>();
                foreach (var tag in tagsEl)
                {
                    tags.Add((Models.Tag)tag);
                }

                Models.Author a = new Models.Author { 
                    Title = textBoxAuthor.Text,
                    Level = Convert.ToInt32(numericUpDownLevel.Value),
                    Tags = tags,
                };
                db.Add(a);
                db.SaveChanges();
                LoadAuthors();
                textBoxAuthor.Text = "";
                listBoxTags.SelectedItems.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
