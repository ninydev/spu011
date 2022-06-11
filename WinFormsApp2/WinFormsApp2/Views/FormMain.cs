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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            Form f = new Form();

            Button btn = new Button();
            btn.Text = "Я создал кнопку в другой форме";
            btn.Click += (object sender, EventArgs e) =>
                {
                    f.Close();
                };

            f.Controls.Add(btn);
            f.ShowDialog();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.ShowDialog();
        }
    }
}
