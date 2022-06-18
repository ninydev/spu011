namespace WinFormsApp2.Views
{
    partial class FormSimpleImg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimpleImg));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "JS Frameworks",
            "Vue",
            "React",
            "Angular"}, 0);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("JS Framework");
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.imgList_Small = new System.Windows.Forms.ImageList(this.components);
            this.listViewCodes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.imgList_Big = new System.Windows.Forms.ImageList(this.components);
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::WinFormsApp2.Properties.Resources.vue;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(599, 45);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(329, 210);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // imgList_Small
            // 
            this.imgList_Small.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList_Small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Small.ImageStream")));
            this.imgList_Small.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Small.Images.SetKeyName(0, "JavaScript-logo.png");
            this.imgList_Small.Images.SetKeyName(1, "vue.png");
            // 
            // listViewCodes
            // 
            this.listViewCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCodes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCodes.LargeImageList = this.imgList_Big;
            this.listViewCodes.Location = new System.Drawing.Point(34, 61);
            this.listViewCodes.Name = "listViewCodes";
            this.listViewCodes.Size = new System.Drawing.Size(447, 144);
            this.listViewCodes.SmallImageList = this.imgList_Small;
            this.listViewCodes.TabIndex = 1;
            this.listViewCodes.UseCompatibleStateImageBehavior = false;
            this.listViewCodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название элемента";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Первое из колекции";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Второе из коллекции";
            // 
            // imgList_Big
            // 
            this.imgList_Big.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList_Big.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Big.ImageStream")));
            this.imgList_Big.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Big.Images.SetKeyName(0, "JavaScript-logo.png");
            this.imgList_Big.Images.SetKeyName(1, "vue.png");
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(115, 22);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(34, 22);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 23);
            this.btnLarge.TabIndex = 3;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(579, 294);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imgList_Small;
            this.treeView1.Location = new System.Drawing.Point(34, 238);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "JS Framework";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(334, 154);
            this.treeView1.TabIndex = 5;
            // 
            // FormSimpleImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 497);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.listViewCodes);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "FormSimpleImg";
            this.Text = "FormSimpleImg";
            this.Load += new System.EventHandler(this.FormSimpleImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private ImageList imgList_Small;
        private ListView listViewCodes;
        private ImageList imgList_Big;
        private Button btnSmall;
        private Button btnLarge;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnLoadImage;
        private TreeView treeView1;
    }
}