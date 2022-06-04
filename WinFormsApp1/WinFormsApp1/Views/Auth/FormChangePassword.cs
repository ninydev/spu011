using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Views.Auth
{
    public partial class FormChangePassword : Form
    {
        private Models.User user;
        public FormChangePassword(ref Models.User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            ValidateInputs(null, null);
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isOld = this.user.Password == this.txtOld.Text;
            if (isOld)
            {
                labelOld.ForeColor = Color.Green;
            } 
            else
            {
                labelOld.ForeColor = Color.Red;
            }

            bool isLen = this.txtNew.Text.Length > 8 && this.txtNew.Text.Length < 40;
            if (isLen)
            {
                labelLen.ForeColor = Color.Green;
            }
            else
            {
                labelLen.ForeColor = Color.Red;
            }


            // Шаблон
            string patternCase = @"(?=.*[a-z])(?=.*[A-Z])";
            // Создаем экземпляр Regex   
            Regex rgCase = new Regex(patternCase);
            bool isCase = rgCase.IsMatch(this.txtNew.Text);
            if (isCase)
            {
                labelCase.ForeColor = Color.Green;
            }
            else
            {
                labelCase.ForeColor = Color.Red;
            }
            
            // Шаблон
            string patternNum = @"\d{1,}";
            // Создаем экземпляр Regex   
            Regex rgNum = new Regex(patternNum);
            bool isNum = rgNum.IsMatch(this.txtNew.Text);
            if (isNum)
            {
                labelNum.ForeColor = Color.Green;
            }
            else
            {
                labelNum.ForeColor = Color.Red;
            }

            bool isConfirm = this.txtNew.Text == this.txtConfirm.Text;
            if (isConfirm)
            {
                labelConfirm.ForeColor = Color.Green;
            }
            else
            {
                labelConfirm.ForeColor = Color.Red;
            }

            if(isOld && isLen && isCase && isNum && isConfirm)
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

    }
}
