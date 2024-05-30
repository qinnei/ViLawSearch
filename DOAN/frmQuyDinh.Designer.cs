namespace DOAN
{
    partial class frmQuyDinh
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
            this.txtHoi = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.llbMain = new System.Windows.Forms.LinkLabel();
            this.lblDan = new System.Windows.Forms.Label();
            this.lblDan2 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoi
            // 
            this.txtHoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoi.Location = new System.Drawing.Point(12, 12);
            this.txtHoi.Multiline = true;
            this.txtHoi.Name = "txtHoi";
            this.txtHoi.Size = new System.Drawing.Size(1134, 93);
            this.txtHoi.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(484, 111);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(205, 50);
            this.btnTraCuu.TabIndex = 3;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnMain.Controls.Add(this.llbMain);
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.Location = new System.Drawing.Point(12, 167);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1134, 408);
            this.pnMain.TabIndex = 4;
            // 
            // llbMain
            // 
            this.llbMain.AutoSize = true;
            this.llbMain.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbMain.Location = new System.Drawing.Point(49, 28);
            this.llbMain.Name = "llbMain";
            this.llbMain.Size = new System.Drawing.Size(0, 29);
            this.llbMain.TabIndex = 0;
            this.llbMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMain_LinkClicked);
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDan.ForeColor = System.Drawing.Color.Blue;
            this.lblDan.Location = new System.Drawing.Point(28, 578);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(0, 29);
            this.lblDan.TabIndex = 5;
            this.lblDan.Click += new System.EventHandler(this.lblDan_Click);
            // 
            // lblDan2
            // 
            this.lblDan2.AutoSize = true;
            this.lblDan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDan2.ForeColor = System.Drawing.Color.Blue;
            this.lblDan2.Location = new System.Drawing.Point(28, 624);
            this.lblDan2.Name = "lblDan2";
            this.lblDan2.Size = new System.Drawing.Size(0, 29);
            this.lblDan2.TabIndex = 6;
            this.lblDan2.Click += new System.EventHandler(this.lblDan2_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 806);
            this.Controls.Add(this.lblDan2);
            this.Controls.Add(this.lblDan);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuyDinh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoi;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.LinkLabel llbMain;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.Label lblDan2;
    }
}