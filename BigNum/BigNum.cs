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
            if (num.Contains("-"))
                MessageBox.Show("Nhập sai định dạng số");
        }
        public char Sign { get => sign; set => sign = value; }
        public string Num { get => num; set => num = value; }
        public char Compare(BigNum BN)

        {
            // l: less than BN
            // g: greater than BN
            // e: equal to BN
            if (this.Sign == BN.Sign)
            {
                if (this.Num.Length < BN.Num.Length)
                    return 'l';
                else if (this.Num.Length > BN.Num.Length)
                    return 'g';
                else
                {
                    int b = this.Num.CompareTo(BN.Num);
                    if (b == 0)
                        return 'e';
                    else if (b == 1)
                        return 'g';
                    else
                        return 'l';
                }
            }
            else
            {
                if (this.Sign == '+')
                    return 'g';
                else
                    return 'l';
            }
        }
        public List<Int64> CutNum(BigNum BN)
        {
            List<Int64> cuted = new List<Int64>();
            return cuted;
        }
    }
}