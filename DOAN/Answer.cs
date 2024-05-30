using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
namespace DOAN
{
    public class Answer
    {
        public int Type;
        public Dictionary<string,List<string> > Ans;
        public Dictionary<string,List<double> > Limit1;
        public Dictionary<string, List<double>> Limit2;
        
        public string Change(string s)
        {
            string ss = "";
            for(int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == ',' && char.IsDigit(s[i - 1]) && char.IsDigit(s[i + 1]))
                {
                    ss += '.';
                }
                else
                    ss += s[i];
            }
            return ss;
        }
        public List<double> ExtractNumbers(string input)
        {
            List<double> numbers = new List<double>();
            string pattern = @"-?\d+(\.\d+)?"; // Pattern để tìm các số nguyên hoặc số thực trong chuỗi

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (double.TryParse(match.Value, out double number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }
        public Answer(int type, Dictionary<string, List<string> > ans)
        {
            Type = type;
            Ans = ans;
            if(Type == 1 || Type == 2)
            {
                Limit1 = new Dictionary<string, List<double>>();
                Limit2 = new Dictionary<string, List<double>>();
                foreach (var item in Ans)
                {
                    Limit1.Add(item.Key, new List<double>());
                    Limit2.Add(item.Key, new List<double>());

                    for (int i = 1; i < item.Value.Count; i++)
                    {
                        if (Type == 2)
                        {
                            string[] S1 = item.Value[i].Split(';');
                            string ss = Change(S1[0]);
                            string separator = "hoặc";
                            string[] s2 = ss.Split(new string[] { separator }, StringSplitOptions.None);
                            List<double> num1 = ExtractNumbers(s2[0]);
                            List<double> num2 = ExtractNumbers(s2[1]);
                            num1.RemoveAt(num1.Count - 1);
                            num2.RemoveAt(num2.Count - 1);
                            foreach (double Num in num1)
                            {
                                if (Limit1[item.Key].Count == 0)
                                {
                                    Limit1[item.Key].Add(Num);
                                    break;
                                }
                                else
                                {
                                    if (Num > Limit1[item.Key][Limit1[item.Key].Count - 1])
                                    {
                                        Limit1[item.Key].Add(Num);
                                        break;
                                    }
                                }
                            }
                            foreach (double Num in num2)
                            {
                                if (Limit2[item.Key].Count == 0)
                                {
                                    Limit2[item.Key].Add(Num);
                                    break;
                                }
                                else
                                {
                                    if (Num > Limit2[item.Key][Limit2[item.Key].Count - 1])
                                    {
                                        Limit2[item.Key].Add(Num);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if(Type == 1)
                            {
                                string[] S1 = item.Value[i].Split(';');
                                string ss = Change(S1[0]);
                               
                                List<double> num1 = new List<double>();
                                string[] NUM = ss.Split(' ');
                                for(int ii = 1; ii < NUM.Length; ii++)
                                {
                                    if (NUM[ii][0] >= 48 && NUM[ii][0] <= 57)
                                    {
                                        double so = double.Parse(NUM[ii]);
                                        if (NUM[ii - 1] == "trên")
                                            ++so;
                                        if (NUM[ii - 1] == "dưới")
                                            --so;
                                        
                                       
                                        num1.Add(so);
                                    }    
                                }
                                foreach (double Num in num1)
                                {
                                    
                                    if (Limit1[item.Key].Count == 0)
                                    {
                                        Limit1[item.Key].Add(Num);
                                    }
                                    else
                                    {
                                        if (Num > Limit1[item.Key][Limit1[item.Key].Count - 1])
                                        {
                                            Limit1[item.Key].Add(Num);
                                           
                                        }
                                    }
                                }
                            }
                            
                        }    
                        
                    }
                }
            }   
        }
        public string All()
        {
            string s = "";
            foreach (var item in Ans)
            {
                foreach (string str in item.Value)
                {
                    s += str + "\n";
                }
            }
            return s;
        }
        public string Doi(string str)
        {
            List <string> stop = new List<string>() {"ngưỡng", "mức"};
            foreach(string s in stop)
            {
                str = str.Replace(s, "");
            }    
            List<string> Check = new List<string> { "ít hơn", "thấp hơn", "thấp", "ít", "nhỏ hơn", "nhỏ","bé hơn","bé", "chưa tới" };
            foreach (string s in Check)
            {
                str = str.Replace(s, "dưới");
            }
            List<string> Check2 = new List<string> { "nhiều hơn", "cao hơn", "cao", "nhiều", "to hơn", "to", "lớn hơn", "lớn","quá","vượt" };
            
            foreach (string s in Check2)
            {
                str = str.Replace(s, "hơn");
            }
            
            return str;
        }
        public string Process(List<string> Key, List<string> Key2, string Ques)
        {
            
            Ques = Ques.ToLower();
            Ques = " " + Ques + " ";
            Ques = Change(Ques);
            
            string s = "";
            
            if (Type == 0)
            {
                if (Key.Count == 0)
                    return All();
                foreach (string key in Key)
                {
                    if (Ans.ContainsKey(key))
                        s += Ans[key][0] + "\n";
                }
                return s;
            }
            if (Type == 3)
            {
                foreach (string str in Key2)
                    Console.WriteLine(str);
                if (Key.Count > 0)
                {
                    foreach (string key in Key)
                    {
                        s += Ans[key][0] + "\n";
                        int[] Point = new int[Ans[key].Count];
                        int MAX = 0;
                        int pos = 1;
                        for (int i = 1; i < Ans[key].Count; ++i)
                        {
                            Point[i] = 0;
                            foreach (string str in Key2)
                            {
                                if (Ans[key][i].Contains(str))
                                {
                                    ++Point[i];
                                }
                            }
                            if (Point[i] > MAX)
                            {
                                MAX = Point[i];
                                pos = i;
                            }
                        }
                        for (int i = 1; i < Ans[key].Count; ++i)
                            if(Point[i] == Point[pos])
                                s += Ans[key][i] + "\n";
                    }
                }
                else
                {
                    foreach (var item in Ans)
                    {
                        string key = item.Key;
                        s += Ans[key][0] + "\n";
                        int[] Point = new int[Ans[key].Count];
                        int MAX = 0;
                        int pos = 1;
                        for (int i = 1; i < Ans[key].Count; ++i)
                        {
                            Point[i] = 0;
                            foreach (string str in Key2)
                            {
                                if (Ans[key][i].Contains(str))
                                {
                                    ++Point[i];
                                }
                            }
                            if (Point[i] > MAX)
                            {
                                MAX = Point[i];
                                pos = i;
                            }
                        }
                        for (int i = 1; i < Ans[key].Count; ++i)
                            if (Point[i] == Point[pos])
                                s += Ans[key][i] + "\n";
                    }
                }
                return s;
            }
            if (Type == 2)
            {

                string queS = Ques.ToLower();
                string ques = queS.Replace("mlg", "miligam");
                ques = Doi(ques);
                Console.WriteLine( ques );
                double limit = 0;
                int ty = -1;
                string[] s1 = ques.Split(' ');
               
                for (int i = 1; i < s1.Length; ++i)
                {
                    if (s1[i] == "miligam/100")
                    {
                        ty = 1;
                        limit = double.Parse(s1[i - 1]);
                        if (i > 1 && (s1[i - 2] == "hơn"))
                            limit += 0.001;
                        if (i > 1 && (s1[i - 2] == "dưới"))
                            limit -= 0.001;
                        break;
                    }
                    if (s1[i] == "miligam/1")
                    {
                        ty = 0;
                        limit = double.Parse(s1[i - 1]);
                        if (i > 1 && (s1[i - 2] == "hơn"))
                            limit += 0.001;
                        if (i > 1 && (s1[i - 2] == "dưới"))
                            limit -= 0.001;
                        break;
                    }
                }
                
                if(ty == -1)
                {
                    if (Key.Count > 0)
                    {
                        foreach (string key in Key)
                        {
                            foreach (string str in Ans[key])
                                s += str + "\n";
                        }
                    }
                    else
                        return All();
                    return s;
                }    
                if (ty == 1)
                {
                    if(Key.Count > 0)
                    {
                        foreach(string key in Key)
                        {
                            s += Ans[key][0] + "\n";
                            int i = 0;
                            for(; i<Limit1[key].Count; ++i)
                            {
                                if (Limit1[key][i] >= limit)
                                    break;
                            }
                            s += Ans[key][i+1] + "\n";

                        }
                    }
                    else
                    {
                        foreach (var item in Ans)
                        {
                            string key = item.Key;
                            s += Ans[key][0] + "\n";
                            int i = 0;
                            for (; i < Limit1[key].Count; ++i)
                            {
                                if (Limit1[key][i] >= limit)
                                    break;
                            }
                            s += Ans[key][i+1] + "\n";
                        }
                    }
                }
                else
                {
                    if (Key.Count > 0)
                    {
                        foreach (string key in Key)
                        {
                            s += Ans[key][0] + "\n";
                            int i = 0;
                            for (; i < Limit2[key].Count; ++i)
                            {
                                if (Limit2[key][i] >= limit)
                                    break;
                            }
                            s += Ans[key][i+1] + "\n";

                        }
                    }
                    else
                    {
                        foreach (var item in Ans)
                        {
                            string key = item.Key;
                            s += Ans[key][0] + "\n";
                            int i = 0;
                            for (; i < Limit2[key].Count; ++i)
                            {
                                if (Limit2[key][i] >= limit)
                                    break;
                            }
                            s += Ans[key][i+1] + "\n";
                        }
                    }
                }    
                return s;
            }   
            if (Type == 1)
            {
                string queS = Ques.ToLower();
                string ques = queS.Replace("cây số giờ", "km/h");
                double limit = 0;
                double [] l1 = new double[2];
                int sl = 0;
                string[] arr = ques.Split(' ');
                for(int i = 1; i<arr.Length; ++i) 
                {
                    if (arr[i] == "km/h")
                    {
                        l1[sl] = double.Parse(arr[i-1]);
                        ++sl;
                    }
                }
                
                if (sl == 0)
                {
                    if (Key.Count > 0)
                    {
                        foreach (string key in Key)
                        {
                            if (Ans.ContainsKey(key))
                            {
                                foreach (string str in Ans[key])
                                {
                                    s += str + "\n";
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in Ans) 
                        { 
                            foreach(string str in item.Value)
                            {
                                s += str + "\n";
                            }
                        }
                    }
                    return s;
                }
                if (sl == 2)
                {
                    
                    string[] s1 = { "được chạy","cho phép", "cho chạy", "giới hạn", "được phép","có quyền", "được quyền", "tối đa","lớn nhất", "quy định tốc độ" };
                    string Newstr = "";
                    
                    foreach (string str in s1)
                    {
                        int position = ques.IndexOf(str);
                        if(position != -1)
                        {
                            Newstr = ques.Substring(position);
                            break;
                        }
                    }
                    if(Newstr != null)
                    {
                        string[] arr2 = Newstr.Split(' ');
                        int dem = 0;
                        for(int i = 0;  i < arr2.Length; i++) { if (arr2[i] == "km/h") ++dem; }
                        if(dem <= 1)
                        {
                            if (l1[0] <= l1[1])
                                return "Bạn không vi phạm lỗi quá tốc độ.";
                        }
                        else
                        {
                            if (dem == 2)
                            {
                                if (l1[1] <= l1[0])
                                    return "Bạn không vi phạm lỗi quá tốc độ.";
                            }
                            else
                            {
                                return "Có vẻ câu hỏi của bạn hơi lủng củng bạn nên hỏi rõ ràng hơn !";
                            }    
                        }    
                    }   
                    limit = Math.Abs(l1[0] - l1[1]);
                    /*foreach(double dt in Limit1["xe máy"])
                        Console.WriteLine(dt);*/
                }
                else
                    limit = l1[0];
                if (limit < 5)
                    return $"Bạn chỉ vượt tốc độ cho phép là {limit} km/h cho nên bạn chưa vi phạm lỗi quá tốc độ \nNgưỡng tối thiểu để vi phạm lỗi quá tốc độ là từ 5 km/h trở lên";
                if (Key.Count > 0)
                {
                    foreach (string key in Key)
                    {
                        int i = 0;

                        for (; i < Limit1[key].Count; ++i)
                        {
                            if (Limit1[key][i] >= limit)
                            {
                                break;
                            }
                        }
                        if (Ans.ContainsKey(key))
                        {
                            s += Ans[key][0] + "\n";
                            s += Ans[key][i/2 + 1] + "\n";
                        }
                    }
                }
                else
                {
                    foreach (var item in Ans)
                    {
                        string key = item.Key;
                        int i = 0;

                        for (; i < Limit1[key].Count; ++i)
                        {
                            if (Limit1[key][i] >= limit)
                            {
                                break;
                            }
                        }
                        if (Ans.ContainsKey(key))
                        {
                            s += Ans[key][0] + "\n";
                            s += Ans[key][i/2 + 1] + "\n";
                        }
                    }
                }
                return s;
            }
            return s;
        }

    }
}
