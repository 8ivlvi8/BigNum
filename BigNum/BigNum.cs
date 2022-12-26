using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    internal class BigNum
    {
        private char sign;
        private string num;
        public char Sign { get => sign; set => sign = value; }
        public string Num { get => num; set => num = value; }
        public BigNum(string s)
        {
            if (s.Length > 1 && s[0] == '-')
            {
                num = s.Remove(0, 1);
                sign = '-';
            }
            else
            {
                num = s;
                sign = '+';
            }
        }
        public string Show()
        {
            string s = ((sign == '-') ? "-" : "") + num.TrimStart('0');
            if (s == "" || s == "-")
                s = "0";
            return s;
        }
        public BigNum Opposite()
        {
            BigNum Result = new BigNum(this.Num);
            if (Sign == '-')
                Result.sign = '+';
            else
                Result.sign = '-';
            return Result;
        }
        public BigNum Abs()
        {
            BigNum Result = new BigNum(this.Num);
            if (Result.Sign == '-')
                Result.Sign = '+';
            return Result;
        }
        public char Compare(BigNum BN)

        {
            // l: less than BN
            // g: greater than BN
            // e: equal to BN
            char Result;
            if (this.Sign == BN.Sign)
            {
                if (this.Num.Length < BN.Num.Length)
                    Result = 'l';
                else if (this.Num.Length > BN.Num.Length)
                    Result = 'g';
                else
                {
                    int b = this.Num.CompareTo(BN.Num);
                    if (b == 0)
                        Result = 'e';
                    else if (b == 1)
                        Result = 'g';
                    else
                        Result = 'l';
                }
                if (this.Sign == '-')
                {
                    if (Result == 'g')
                        Result = 'l';
                    else if (Result == 'l')
                        Result = 'g';
                }
            }
            else
            {
                if (this.Sign == '+')
                    Result = 'g';
                else
                    Result = 'l';
            }
            return Result;
        }
        public List<Int64> CutNum(int n)
        {
            List<Int64> cuted = new List<Int64>();
            int len = num.Length;
            int k = len % n;
            int t = len / n;
            string s = "";
            if (k != 0)
            {
                for (int i = 0; i < k; i++)
                    s += num[i];
                cuted.Add(Int64.Parse(s));
                s = "";
            }
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += num[i * n + j + k];
                }
                cuted.Add(Int64.Parse(s));
                s = "";
            }
            return cuted;
        }
        // Thêm số 0 vào location, trả về đúng n ký tự
        public string Add_num_0(int n, string s, string location)
        {
            int len = s.Length;
            if (location == "begin")
                for (int i = 0; i < n - len; i++)
                    s = '0' + s;
            if (location == "end")
                for (int i = 0; i < n - len; i++)
                    s += '0';
            return s;
        }
        // Thêm n số 0 vào location
        public string Add_num_0(string s, string location, int n)
        {
            if (location == "begin")
                for (int i = 0; i < n; i++)
                    s = '0' + s;
            if (location == "end")
                for (int i = 0; i < n; i++)
                    s += '0';
            return s;
        }
        public void Swap(ref BigNum BN1, ref BigNum BN2)
        {
            BigNum temp = BN1;
            BN1 = BN2;
            BN2 = temp;
            return;
        }
        public BigNum Addition(BigNum BN1, BigNum BN2)
        {
            if (BN1.Compare(BN2) == 'l')
                Swap(ref BN1, ref BN2);
            List<Int64> lstB1 = BN1.CutNum(15);
            List<Int64> lstB2 = BN2.CutNum(15);
            List<Int64> lstrs = new List<Int64>();
            Int64 x = 0, y = 0;
            lstB1.Insert(0, x);
            int len_lstB1 = lstB1.Count;
            int len_lstB2 = lstB2.Count;
            for (int i = 0; i < len_lstB1 - len_lstB2; i++)
                lstB2.Insert(0, x);
            for (int i = len_lstB1 - 1; i >= 0; i--)
            {
                x = lstB1[i] + lstB2[i] + y;
                y = x / 1000000000000000;
                x %= 1000000000000000;
                lstrs.Insert(0, x);
            }
            string s = "";
            for (int i = 0; i < lstrs.Count; i++)
                s += Add_num_0(15, lstrs[i].ToString(), "begin");
            return new BigNum(s.TrimStart('0'));
        }
        public BigNum Subtraction(BigNum BN1, BigNum BN2)
        {
            if (BN1.Compare(BN2) == 'e')
                return new BigNum("0");
            else if (BN1.Abs().Compare(BN2.Abs()) == 'l')
                Swap(ref BN1, ref BN2);
            List<Int64> lstB1 = BN1.CutNum(15);
            List<Int64> lstB2 = BN2.CutNum(15);
            List<Int64> lstrs = new List<Int64>();
            lstB1.Insert(0, 0);
            int len_lstB1 = lstB1.Count;
            int len_lstB2 = lstB2.Count;
            for (int i = 0; i < len_lstB1 - len_lstB2; i++)
                lstB2.Insert(0, 0);
            for (int i = len_lstB1 - 1; i >= 0; i--)
            {
                if (lstB1[i] < lstB2[i])
                {
                    lstB1[i - 1] -= 1;
                    lstB1[i] += 1000000000000000;
                }
                lstrs.Insert(0, lstB1[i] - lstB2[i]);
            }
            string s = "";
            for (int i = 0; i < lstrs.Count; i++)
                s += Add_num_0(15, lstrs[i].ToString(), "begin");
            return new BigNum(s.TrimStart('0'));
        }
        public BigNum Multiplication_BN_Int64(BigNum BN, Int64 n)
        {
            List<Int64> lst = BN.CutNum(8);
            string s = "";
            lst.Insert(0, 0);
            int len = lst.Count;
            for (int i = 0; i < len; i++)
                lst[i] *= n;
            for (int i = len - 1; i >= 0; i--)
            {
                if (i > 0) lst[i - 1] += lst[i] / 100000000;
                lst[i] %= 100000000;
            }
            for (int i = 0; i < len; i++)
                s += Add_num_0(8, lst[i].ToString(), "begin");
            return new BigNum(s.TrimStart('0'));
        }
        public BigNum Multiplication_BN_BN(BigNum BN1, BigNum BN2)
        {
            if (BN1.Compare(BN2) == 'l')
                Swap(ref BN1, ref BN2);
            List<Int64> lstBN2 = BN2.CutNum(8);
            List<BigNum> lstBN = new List<BigNum>();
            BigNum Result = new BigNum("0");
            int len = lstBN2.Count;
            for (int i = 0; i < len; i++)
                lstBN.Add(Multiplication_BN_Int64(BN1, lstBN2[i]));
            len = lstBN.Count;
            for (int i = 0; i < len; i++)
            {
                BigNum temp = new BigNum(Add_num_0(lstBN[i].Num, "end", 8 * (len - i - 1)));
                    Result = Addition(Result, temp);
            }
            Result.Num = Result.Num.TrimStart('0');
            return Result;
        }
        public BigNum Division(BigNum BN1, BigNum BN2, int Remainder)
        {
            List<BigNum> lstBN_Bin = new List<BigNum>();
            BigNum Result = new BigNum("0");
            string s = "";
            int lenBN1 = BN1.Num.Length;
            int lenBN2 = BN2.Num.Length;
            int k;
            lstBN_Bin.Add(new BigNum("0"));
            for (int i = 0; i < 10; i++)
                lstBN_Bin.Add(Addition(lstBN_Bin[i], BN2));
            lenBN2--;
            for (int i = 0; i < lenBN2; i++)
                s += BN1.Num[i];
            BigNum temp = new BigNum(s);
            for (int i = lenBN2; i < lenBN1; i++)
            {
                temp.Num += BN1.Num[i];
                temp.Num = temp.Num.TrimStart('0');
                k = Search_Bin(ref temp, ref lstBN_Bin);
                if (k != 0)
                    temp = Subtraction(temp, lstBN_Bin[k]);
                Result.Num += k;
            }
            //Result.Num += Search_Bin(ref temp, ref lstBN_Bin);
            if (Remainder == 1)
                return temp;
            else return Result;
        }
        public int Search_Bin(ref BigNum BN, ref List<BigNum> lstBN_Bin)
        {
            int q = 0, p = 10, k = 0;
            while (p - q != 1)
            {
                k = (q + p) / 2;
                if (BN.Compare(lstBN_Bin[k]) == 'l')
                    p = k;
                else
                    q = k;
            }
            return q;
        }
        public BigNum Pow(BigNum BN1, Int64 BN2)
        {
            int k = (int)Math.Log2(BN2);
            List<BigNum> Pow2n = new List<BigNum>();
            BigNum Result = new BigNum("1");
            Pow2n.Add(BN1);
            for (int i = 0; i < k; i++)
                Pow2n.Add(Multiplication_BN_BN(Pow2n[i], Pow2n[i]));
            while (BN2 > 0)
            {
                k = (int)Math.Log2(BN2);
                Result = Multiplication_BN_BN(Result, Pow2n[k]);
                BN2 -= (int)Math.Pow(2,k);

            }
            return Result;
        }
    }
}