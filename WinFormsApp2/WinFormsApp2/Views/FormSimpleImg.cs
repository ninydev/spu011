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
    public partial class FormSimpleImg : Form
    {
        public FormSimpleImg()
        {
            InitializeComponent();
        }

        private void FormSimpleImg_Load(object sender, EventArgs e)
        {

        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            listViewCodes.View = View.LargeIcon;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            listViewCodes.View = View.SmallIcon;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.Filter = "Image Files|*.jpg;*.png| All files (*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                var fileAvatar = f.FileNames[0];
                // MessageBox.Show(fileAvatar);
                try
                {
                    // var img = Image.FromFile(fileAvatar);
                    var help = new Helpers.Media.Images(fileAvatar, "avatars");
                    var newFile = help.MoveToStorage();
                    pictureBoxAvatar.ImageLocation = newFile;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // pictureBoxAvatar.ImageLocation = fileAvatar;
            }
        }
    }
}
