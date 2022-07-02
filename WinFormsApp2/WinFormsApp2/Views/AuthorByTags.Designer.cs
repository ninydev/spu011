namespace WinFormsApp2.Views
{
    partial class AuthorByTags
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
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.btnSearchOne = new System.Windows.Forms.Button();
            this.btnNoTags = new System.Windows.Forms.Button();
            this.btnAnonim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTags
            // 
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 15;
            this.listBoxTags.Location = new System.Drawing.Point(12, 26);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTags.Size = new System.Drawing.Size(187, 304);
            this.listBoxTags.TabIndex = 8;
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 15;
            this.listBoxAuthors.Location = new System.Drawing.Point(234, 26);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(521, 304);
            this.listBoxAuthors.TabIndex = 7;
            // 
            // btnSearchOne
            // 
            this.btnSearchOne.Location = new System.Drawing.Point(468, 352);
            this.btnSearchOne.Name = "btnSearchOne";
            this.btnSearchOne.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOne.TabIndex = 9;
            this.btnSearchOne.Text = "SearchOne";
            this.btnSearchOne.UseVisualStyleBackColor = true;
            this.btnSearchOne.Click += new System.EventHandler(this.btnSearchOne_Click);
            // 
            // btnNoTags
            // 
            this.btnNoTags.Location = new System.Drawing.Point(468, 381);
            this.btnNoTags.Name = "btnNoTags";
            this.btnNoTags.Size = new System.Drawing.Size(75, 23);
            this.btnNoTags.TabIndex = 10;
            this.btnNoTags.Text = "noTags";
            this.btnNoTags.UseVisualStyleBackColor = true;
            this.btnNoTags.Click += new System.EventHandler(this.btnNoTags_Click);
            // 
            // btnAnonim
            // 
            this.btnAnonim.Location = new System.Drawing.Point(28, 348);
            this.btnAnonim.Name = "btnAnonim";
            this.btnAnonim.Size = new System.Drawing.Size(75, 23);
            this.btnAnonim.TabIndex = 11;
            this.btnAnonim.Text = "Anonim";
            this.btnAnonim.UseVisualStyleBackColor = true;
            this.btnAnonim.Click += new System.EventHandler(this.btnAnonim_Click);
            // 
            // AuthorByTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnonim);
            this.Controls.Add(this.btnNoTags);
            this.Controls.Add(this.btnSearchOne);
            this.Controls.Add(this.listBoxTags);
            this.Controls.Add(this.listBoxAuthors);
            this.Name = "AuthorByTags";
            this.Text = "AuthorByTags";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxTags;
        private ListBox listBoxAuthors;
        private Button btnSearchOne;
        private Button btnNoTags;
        private Button btnAnonim;
    }
}