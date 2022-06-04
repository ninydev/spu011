namespace WinFormsApp1.Views.Auth
{
    partial class FormChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLen = new System.Windows.Forms.Label();
            this.labelCase = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.labelOld = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLen
            // 
            this.labelLen.AutoSize = true;
            this.labelLen.Location = new System.Drawing.Point(27, 72);
            this.labelLen.Name = "labelLen";
            this.labelLen.Size = new System.Drawing.Size(234, 15);
            this.labelLen.TabIndex = 0;
            this.labelLen.Text = "Длинна пароля более 8 символов (до 40)";
            // 
            // labelCase
            // 
            this.labelCase.AutoSize = true;
            this.labelCase.Location = new System.Drawing.Point(27, 98);
            this.labelCase.Name = "labelCase";
            this.labelCase.Size = new System.Drawing.Size(226, 15);
            this.labelCase.TabIndex = 1;
            this.labelCase.Text = "Содержит большие и маленькие буквы";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(27, 125);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(194, 15);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "Содержит цифры и спецсимволы";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(306, 46);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(156, 23);
            this.txtOld.TabIndex = 3;
            this.txtOld.TextChanged += new System.EventHandler(this.ValidateInputs);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(306, 75);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(156, 23);
            this.txtNew.TabIndex = 4;
            this.txtNew.TextChanged += new System.EventHandler(this.ValidateInputs);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(306, 145);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(156, 23);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.TextChanged += new System.EventHandler(this.ValidateInputs);
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(27, 46);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(181, 15);
            this.labelOld.TabIndex = 6;
            this.labelOld.Text = "Введите верный старый пароль";
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Location = new System.Drawing.Point(27, 153);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(146, 15);
            this.labelConfirm.TabIndex = 7;
            this.labelConfirm.Text = "Подтвердите ваш пароль";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(401, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Change";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 239);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.labelOld);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelCase);
            this.Controls.Add(this.labelLen);
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLen;
        private Label labelCase;
        private Label labelNum;
        private TextBox txtOld;
        private TextBox txtNew;
        private TextBox txtConfirm;
        private Label labelOld;
        private Label labelConfirm;
        private Button btnCancel;
        private Button btnOk;
    }
}