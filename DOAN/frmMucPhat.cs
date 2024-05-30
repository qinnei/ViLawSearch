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
    public partial class frmMucPhat : Form
    {
        List<string> ListKeyPhrase = new List<string>();
        List<string> ListKeySynonym = new List<string>();
        Dictionary<string, List<string> > AllKeySynonym = new Dictionary<string, List<string> >();
        Dictionary<string, List<string>> AllKeySy2 = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> AllKeySy3 = new Dictionary<string, List<string>>();
        List<Vector> ListVectorRegulations = new List<Vector>();
        List <Answer> DicAnswer = new List<Answer>();
       // LinkLabel llbMain = new LinkLabel();
        public frmMucPhat()
        {
            InitializeComponent();
        }
        public void loadListKey(string strFileName, List<string> lKey)
        {
            lKey.Clear();
            string[] tmp = File.ReadAllLines(strFileName);
            foreach(string s in tmp)
            {
                lKey.Add(s);
            }    
        }
        public void loadDicKey(string strFileName,Dictionary<string, List<string> > dKey)
        {
            dKey.Clear();
            string[] tmp = File.ReadAllLines(strFileName);
            foreach (string s in tmp)
            {
                string[] tmp1 = s.Split(',');
                dKey.Add(tmp1[0],new List<string> ());
                for(int i = 0; i < tmp1.Length; i++)
                {
                    dKey[tmp1[0]].Add(tmp1[i]);
                }    
            }
        }
        public string RemovePun(string s)
        {
            string[] Pun = { ",", ".", "?", "!" };
            string s1 = s.ToLower();
            string s2 = "";
            foreach(string s0 in Pun)
            {
                s2 = s1.Replace(s0, "");
                s1 = s2;
            }
            return s2;
        }
        public void LoadKeyVector(string strFileName, List<Vector> Lv )
        {
            string[] tmp = File.ReadAllLines(strFileName);
            foreach(string s in tmp)
            {

                string ss = RemovePun(s);
                //lblThu.Text += ss + "\n";
                Vector Vt = new Vector(ListKeyPhrase.Count);
                for(int i = 0; i < ListKeyPhrase.Count; ++i)
                {
                    foreach (string str in AllKeySynonym[ListKeyPhrase[i]])
                    {
                        if (ss.Contains(str))
                        {
                            Vt[i] = 1000;
                            break;
                        }
                    }
                }
                Lv.Add(Vt);
            }
        }
        public void LoadAnswer(string fileName, List<Answer> DAs)
        {
            string strTmp = File.ReadAllText(fileName);
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            string [] tmp = strTmp.Split('#');
            foreach(string str in tmp)
            {
                string[] ss = str.Split(':');
                dic.Add(ss[0], new List<string>());
                string[] s1 = ss[1].Split('|');
                foreach(string ss1 in s1)
                {
                    dic[ss[0]].Add(ss1);
                }
            }
            int Type = fileName[0] - 48;
            Answer ans = new Answer(Type, dic);
            DAs.Add(ans);
        }
        public void Load1()
        {
            panel1.Controls.Add(llbMain);
            loadListKey("ListKeyPhrase.txt", ListKeyPhrase);
            loadListKey("ListKeySynonym.txt", ListKeySynonym);
            loadDicKey("AllKeySynonym.txt", AllKeySynonym);
            loadDicKey("KeySy2.txt", AllKeySy2);
            loadDicKey("KeySy3.txt", AllKeySy3);
            LoadKeyVector("Regulations.txt", ListVectorRegulations);
            string[] NameRegulations = { "0License.txt", "0Light.txt", "0Pha.txt", "1Speed.txt", "0Phone.txt", "2Alcohol.txt", "3Gave.txt", "3Opposite.txt", "3WLane.txt", "3Xinhan.txt" };
            foreach (string fileName in NameRegulations)
            {
                LoadAnswer(fileName, DicAnswer);
            }
            llbMain.MaximumSize = new System.Drawing.Size(panel1.Width, 0);
            txtHoi.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load1();
        }
        public void xuly()
        {
            string[] tmp = File.ReadAllLines("link.txt");
            string s = llbMain.Text;
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
        }
       /* private void CenterLinkLabel()
        {
            llbMain.Size = new System.Drawing.Size(300, 300);
            // Tính toán vị trí mới cho LinkLabel để nó nằm giữa Panel
            llbMain.Location = new System.Drawing.Point(
                (panel1.Width - llbMain.Width) / 2,
                (panel1.Height - llbMain.Height) / 2);
        }*/
       public int tracuu(string Ques)
        {
            if(Ques.Length == 0)
            { 
                return -1;
            }
            Ques = Ques.ToLower();  
            Vector Vt = new Vector(ListKeyPhrase.Count);
            for (int i = 0; i < ListKeyPhrase.Count; ++i)
            {
                foreach (string str in AllKeySynonym[ListKeyPhrase[i]])
                {
                    if (Ques.Contains(str))
                    {
                        int poss = Ques.IndexOf(str);
                        if (poss == 0 || Ques[poss - 1] == ' ')
                            Vt[i] = 1000;
                        break;
                    }
                }
            }
            for (int i = 0; i < ListKeyPhrase.Count; ++i)
            {
                Console.WriteLine(Vt[i]);
            }    
            double[] Choose = new double[ListVectorRegulations.Count];
            int Pos = 0;
            for (int i = 0; i < ListVectorRegulations.Count; ++i)
            {
                Choose[i] = Vt.Eculid(ListVectorRegulations[i]);
                if (Choose[i] < Choose[Pos])
                    Pos = i;
                // lblThu.Text += Choose[i].ToString() + "\n\n";
            }
            return Pos;
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            llbMain.Text = "";
            if(txtHoi.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập câu hỏi");
                return;
            }    
            string Ques = txtHoi.Text.ToLower();
            Vector Vt = new Vector(ListKeyPhrase.Count);
            for (int i = 0; i < ListKeyPhrase.Count; ++i)
            {
                foreach (string str in AllKeySynonym[ListKeyPhrase[i]])
                {
                    if (Ques.Contains(str))
                    {
                        int poss = Ques.IndexOf(str);
                        if (poss == 0 || Ques[poss - 1] == ' ')
                            Vt[i] = 1000;
                        break;
                    }
                }
            }
            double[] Choose = new double[ListVectorRegulations.Count];
            int Pos = 0;
            for(int i = 0; i < ListVectorRegulations.Count; ++i)
            {
                Choose[i] = Vt.Eculid(ListVectorRegulations[i]);
                if (Choose[i] < Choose[Pos])
                    Pos = i;
               // lblThu.Text += Choose[i].ToString() + "\n\n";
            }
            Console.WriteLine(Pos);
            List <string> Key2 = new List<string>();
            foreach (var item in AllKeySy2)
            {
                foreach(string str in item.Value)
                {
                    if (Ques.Contains(str)) 
                    {
                        int poss = Ques.IndexOf(str);
                        if (poss == 0 || Ques[poss - 1] == ' ')
                            Key2.Add(item.Key);
                        break;
                    }
                }   
            }    
            List <string> Key3 = new List<string>();
            foreach (var item in AllKeySy3)
            {
                foreach (string str in item.Value)
                {
                    if (Ques.Contains(str))
                    {
                        int poss = Ques.IndexOf(str);
                        if (poss == 0 || Ques[poss - 1] == ' ')
                            Key3.Add(item.Key);
                        break;
                    }
                }
            }
            llbMain.Links.Clear();
            llbMain.Text = DicAnswer[Pos].Process(Key2,Key3,Ques);
            xuly();
            
            // CenterLinkLabel();
        }

        private void llbMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
