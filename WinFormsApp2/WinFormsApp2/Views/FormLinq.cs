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
    }
}
