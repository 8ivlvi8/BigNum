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
        }
        public char Sign { get => sign; set => sign = value; }
        public string Num { get => num; set => num = value; }
        public char Compare(BigNum B1, BigNum B2)
        {
            // l: B1 less than B2
            // g: B1 greater than B2
            // e: B1 equal to B2
            if (B1.Sign == B2.Sign)
            {
                if (B1.Num == B2.Num)
                    return 'e';
                else if (B1.Num.Length < B2.Num.Length)
                    return 'l';

            }
            else
            {
                if (B1.Sign == '+')
                    return 'g';
                else
                    return 'l';
            }
            return 'a';
        }
    }
}