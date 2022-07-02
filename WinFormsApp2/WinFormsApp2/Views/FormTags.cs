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
    public partial class FormTags : Form
    {
        public static Data.ApplicationDbContext db;
        public FormTags()
        {
            db = FormLinq.db;
            InitializeComponent();
            LoadTags();
            
        }

        private void LoadTags()
        {
            listBoxTags.Items.Clear();
            if (db.Tags != null)
                listBoxTags.Items.AddRange(db.Tags.ToArray());

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxTag.Text.Length == 0)
            {
                MessageBox.Show("Введите имя метки");
                return;
            }
            try
            {
                Models.Tag t = new Models.Tag { Title = textBoxTag.Text };
                db.Add(t);
                db.SaveChanges();
                LoadTags();
                textBoxTag.Text = "";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
