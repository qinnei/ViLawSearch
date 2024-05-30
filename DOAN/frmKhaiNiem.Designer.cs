namespace DOAN
{
    partial class frmKhaiNiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhaiNiem));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.lblRelate = new System.Windows.Forms.Label();
            this.picDemo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNdLienQuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 2;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(14, 20);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 1;
            this.treeView.Size = new System.Drawing.Size(427, 565);
            this.treeView.TabIndex = 3;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "f1.png");
            this.imageList1.Images.SetKeyName(1, "f2.png");
            this.imageList1.Images.SetKeyName(2, "f3.png");
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(447, 78);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(677, 169);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // lblRelate
            // 
            this.lblRelate.AutoSize = true;
            this.lblRelate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRelate.Location = new System.Drawing.Point(643, 550);
            this.lblRelate.Name = "lblRelate";
            this.lblRelate.Size = new System.Drawing.Size(160, 22);
            this.lblRelate.TabIndex = 1;
            this.lblRelate.Text = "Nội dung liên quan";
            this.lblRelate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRelate.Click += new System.EventHandler(this.lblRelate_Click);
            // 
            // picDemo
            // 
            this.picDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDemo.Location = new System.Drawing.Point(589, 260);
            this.picDemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDemo.Name = "picDemo";
            this.picDemo.Size = new System.Drawing.Size(400, 246);
            this.picDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDemo.TabIndex = 5;
            this.picDemo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(476, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 29);
            this.lblTitle.TabIndex = 6;
            // 
            // lblNdLienQuan
            // 
            this.lblNdLienQuan.AutoSize = true;
            this.lblNdLienQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdLienQuan.Location = new System.Drawing.Point(459, 552);
            this.lblNdLienQuan.Name = "lblNdLienQuan";
            this.lblNdLienQuan.Size = new System.Drawing.Size(157, 20);
            this.lblNdLienQuan.TabIndex = 7;
            this.lblNdLienQuan.Text = "Nội dung liên quan: ";
            // 
            // frmKhaiNiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 599);
            this.Controls.Add(this.lblNdLienQuan);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picDemo);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblRelate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhaiNiem";
            this.Text = "frmKhaiNiem";
            this.Load += new System.EventHandler(this.frmKhaiNiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label lblRelate;
        private System.Windows.Forms.PictureBox picDemo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNdLienQuan;
    }
}