using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DOAN
{
    public partial class frmQuyDinh : Form
    {
        List<string> FileName = new List<string>();
        Dictionary<string,List<string>> Filelk = new Dictionary<string,List<string>>();
        string Fname1 = "";
        string Fname2 = "";
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        public void xuly(string fileName)
        {
            string s = File.ReadAllText(fileName);
            string[] tmp = File.ReadAllLines("link.txt");
            llbMain.Links.Clear();
            llbMain.Text = s;
            foreach (string str in tmp)
            {
                string[] item = str.Split('|');
                int pos = s.IndexOf(item[0], 0);
                while (pos != -1)
                {
                    llbMain.Links.Add(pos, item[0].Length, item[1]);
                    pos = s.IndexOf(item[0], pos + item[0].Length);
                }
            }
            if(Filelk.ContainsKey(fileName))
            {
                lblDan.Text = Filelk[fileName][1];
                Fname1 = Filelk[fileName][0];
                if(Filelk[fileName].Count > 2)
                {
                    lblDan2.Text = Filelk[fileName][3];
                    Fname2 = Filelk[fileName][2];
                }
                else
                {
                    lblDan2.Text = "";
                    Fname2 = "";
                }    
            }
            else
            {
                lblDan.Text = lblDan2.Text = "";
                Fname1 = Fname2 =  "";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string kt = File.ReadAllText("QuyDinh.txt");
            llbMain.Text = kt;
            string[] tmp = File.ReadAllLines("fileName.txt");
            foreach (string str in tmp)
                FileName.Add(str);
            string[] tmp2 = File.ReadAllLines("Lk.txt");
            foreach (string str in tmp2)
            {
                string[] tmp3 = str.Split('|');
                if (!Filelk.ContainsKey(tmp3[0]))
                    Filelk.Add(tmp3[0],new List<string> { tmp3[1], tmp3[2] });
                else
                {
                    Filelk[tmp3[0]].Add(tmp3[1]);
                    Filelk[tmp3[0]].Add(tmp3[2]);
                }    
            }
        }

        private void llbMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            frmMucPhat f1 = new frmMucPhat();
            f1.Load1();
            if(txtHoi.Text.Length == 0)
            {
                MessageBox.Show("Xin mời nhập câu hỏi : ");
                return;
            }
            int Pos = f1.tracuu(txtHoi.Text);
           // Console.WriteLine(txtHoi.Text);
            xuly(FileName[Pos] + ".txt");
        }

        private void lblDan_Click(object sender, EventArgs e)
        {
            if(Fname1 != "")
                xuly(Fname1);
        }

        private void lblDan2_Click(object sender, EventArgs e)
        {
            if (Fname2 != "")
                xuly(Fname2);
        }
    }
}
