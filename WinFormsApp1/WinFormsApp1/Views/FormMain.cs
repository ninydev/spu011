using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DB;

namespace WinFormsApp1.Views
{
    public partial class FormMain : Form
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public FormMain()
        {

            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Label label = new Label();
            //label.Text = "New Label";
            //label.Location = new System.Drawing.Point(120, 102);

            //this.Controls.Add(label);

            //if (sender is Button)
            //{
            //    MessageBox.Show("Button");
            //}
            //else
            //{
            //    MessageBox.Show("Label");
            //}
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Auth();
        }
        private Models.User curentUser; // = new Models.User();

        private void Auth()
        {
            bool isLogin = false;


            do
            {
                Auth.FormLogin formLogin = new Auth.FormLogin();

                switch (formLogin.ShowDialog())
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        //curentUser = new Models.User();
                        //curentUser.Email = formLogin.txtEmail.Text;
                        //curentUser.Password = formLogin.txtPassword.Text;
                        curentUser = formLogin.GetUser();
                        this.toolStripStatusLabelUser.Text = curentUser.Email;
                        isLogin = true;
                        break;
                    case DialogResult.Cancel:
                        isLogin = true;
                        this.Close();
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        Auth.FormPasswordRecoveryRequest formPasswordRecoveryRequest = new Auth.FormPasswordRecoveryRequest();
                        formPasswordRecoveryRequest.ShowDialog();
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.TryAgain:
                        break;
                    case DialogResult.Continue:
                        Auth.FormRegister formRegister = new Auth.FormRegister();
                        formRegister.ShowDialog();
                        break;
                    default:
                        break;
                }

                //DialogResult res = formLogin.ShowDialog();

                //if(res == DialogResult.OK)
                //{
                //    isLogin = true;
                //}
                //if(res == DialogResult.Cancel)
                //{
                //    isLogin = true;
                //    this.Close();
                //}

            } while (!isLogin);





        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth.FormChangePassword f = new Auth.FormChangePassword(ref curentUser);
            f.ShowDialog();
        }
    }
}
