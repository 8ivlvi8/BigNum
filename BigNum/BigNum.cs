﻿using System;
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
        public BigNum(string s)
        {
            if (s[0] == '-')
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
        public char Sign { get => sign; set => sign = value; }
        public string Num { get => num; set => num = value; }
        public string Show()
        {
            string s = ((sign == '-') ? "-" : "") + num.TrimStart('0');
            if (s == "" || s == "-")
                s = "0";
            return s;
        }
        public BigNum Opposite()
        {
            BigNum rs = new BigNum(this.Num);
            if (Sign == '-')
                rs.sign = '+';
            else
                rs.sign = '-';
            return rs;
        }
        public BigNum Abs()
        {
            BigNum rs = new BigNum(this.Num);
            if (rs.Sign == '-')
                rs.Sign = '+';
            return rs;
        }
        public char Compare(BigNum BN)

        {
            // l: less than BN
            // g: greater than BN
            // e: equal to BN
            char rs;
            if (this.Sign == BN.Sign)
            {
                if (this.Num.Length < BN.Num.Length)
                    rs = 'l';
                else if (this.Num.Length > BN.Num.Length)
                    rs = 'g';
                else
                {
                    int b = this.Num.CompareTo(BN.Num);
                    if (b == 0)
                        rs = 'e';
                    else if (b == 1)
                        rs = 'g';
                    else
                        rs = 'l';
                }
                if (this.Sign == '-')
                {
                    if (rs == 'g')
                        rs = 'l';
                    else if (rs == 'l')
                        rs = 'g';
                }
            }
            else
            {
                if (this.Sign == '+')
                    rs = 'g';
                else
                    rs = 'l';
            }
            return rs;
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
            return new BigNum(s);
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
            return new BigNum(s);
        }
        public BigNum Multiplication_BN_Int64(BigNum BN1, Int64 n)
        {
            List<Int64> lst = new List<Int64>();
            string s = "";
            lst = BN1.CutNum(8);
            lst.Insert(0, 0);
            lst.Insert(0, 0);
            int len = lst.Count;
            Int64 x = 0;
            for (int i = len - 1; i >= 0; i--)
                lst[i] *= n;
            for (int i = len - 1; i >= 0; i--)
            {
                x = lst[i] / 100000000;
                if (i > 0) lst[i - 1] += x;
                lst[i] %= 100000000;
            }
            for (int i = 0; i < len; i++)
                s += Add_num_0(8, lst[i].ToString(), "begin");
            return new BigNum(s);
        }
        public BigNum Multiplication_BN_BN(BigNum BN1, BigNum BN2)
        {
            if (BN1.Compare(BN2) == 'l')
                Swap(ref BN1, ref BN2);
            List<Int64> lstBN2 = BN2.CutNum(8);
            List<BigNum> lstBN = new List<BigNum>();
            BigNum Rs = new BigNum("0");
            int len = lstBN2.Count;
            for (int i = 0; i < len; i++)
                lstBN.Add(Multiplication_BN_Int64(BN1, lstBN2[i]));
            len = lstBN.Count;
            for (int i = 0; i < len; i++)
            {
                Rs = Addition(Rs, new BigNum(Add_num_0(8*(len-i), lstBN[i].Num, "end")));

            }
            Rs.Num = Rs.num.TrimStart('0');
            return Rs;
        }
    }
}