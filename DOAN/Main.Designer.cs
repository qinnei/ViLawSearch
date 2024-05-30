namespace DOAN
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMucPhat = new System.Windows.Forms.Button();
            this.btnQuyDinh = new System.Windows.Forms.Button();
            this.btnKhaiNiem = new System.Windows.Forms.Button();
            this.mainView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1072, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tra cứu luật giao thông đường bộ hiện hành";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1753, 77);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnAboutUs);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMucPhat);
            this.panel2.Controls.Add(this.btnQuyDinh);
            this.panel2.Controls.Add(this.btnKhaiNiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 778);
            this.panel2.TabIndex = 2;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(0, 558);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(219, 52);
            this.btnAboutUs.TabIndex = 6;
            this.btnAboutUs.Text = "Thông tin nhóm";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMucPhat
            // 
            this.btnMucPhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMucPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMucPhat.Location = new System.Drawing.Point(3, 203);
            this.btnMucPhat.Name = "btnMucPhat";
            this.btnMucPhat.Size = new System.Drawing.Size(213, 57);
            this.btnMucPhat.TabIndex = 5;
            this.btnMucPhat.Text = "Tra cứu mức phạt";
            this.btnMucPhat.UseVisualStyleBackColor = false;
            this.btnMucPhat.Click += new System.EventHandler(this.btnMucPhat_Click);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyDinh.Location = new System.Drawing.Point(3, 123);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Size = new System.Drawing.Size(213, 57);
            this.btnQuyDinh.TabIndex = 4;
            this.btnQuyDinh.Text = "Tra cứu quy định";
            this.btnQuyDinh.UseVisualStyleBackColor = false;
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // btnKhaiNiem
            // 
            this.btnKhaiNiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKhaiNiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhaiNiem.Location = new System.Drawing.Point(3, 43);
            this.btnKhaiNiem.Name = "btnKhaiNiem";
            this.btnKhaiNiem.Size = new System.Drawing.Size(213, 57);
            this.btnKhaiNiem.TabIndex = 3;
            this.btnKhaiNiem.Text = "Khái niệm";
            this.btnKhaiNiem.UseVisualStyleBackColor = false;
            this.btnKhaiNiem.Click += new System.EventHandler(this.btnKhaiNiem_Click);
            // 
            // mainView
            // 
            this.mainView.AutoSize = true;
            this.mainView.BackColor = System.Drawing.SystemColors.Control;
            this.mainView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Location = new System.Drawing.Point(216, 77);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(1537, 741);
            this.mainView.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1753, 855);
            this.Controls.Add(this.mainView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKhaiNiem;
        private System.Windows.Forms.Panel mainView;
        private System.Windows.Forms.Button btnQuyDinh;
        private System.Windows.Forms.Button btnMucPhat;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnExit;
    }
}