namespace DOAN
{
    partial class frmMucPhat
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
            this.lblThu = new System.Windows.Forms.Label();
            this.txtHoi = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbMain = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Location = new System.Drawing.Point(56, 458);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(0, 16);
            this.lblThu.TabIndex = 1;
            // 
            // txtHoi
            // 
            this.txtHoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoi.Location = new System.Drawing.Point(23, 38);
            this.txtHoi.Multiline = true;
            this.txtHoi.Name = "txtHoi";
            this.txtHoi.Size = new System.Drawing.Size(1072, 76);
            this.txtHoi.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Crimson;
            this.btnTraCuu.Location = new System.Drawing.Point(476, 120);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(166, 57);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.llbMain);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 338);
            this.panel1.TabIndex = 3;
            // 
            // llbMain
            // 
            this.llbMain.AutoSize = true;
            this.llbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbMain.Location = new System.Drawing.Point(54, 27);
            this.llbMain.Name = "llbMain";
            this.llbMain.Size = new System.Drawing.Size(0, 25);
            this.llbMain.TabIndex = 0;
            this.llbMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMain_LinkClicked);
            // 
            // frmMucPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1115, 540);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtHoi);
            this.Controls.Add(this.lblThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMucPhat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.TextBox txtHoi;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbMain;
    }
}

