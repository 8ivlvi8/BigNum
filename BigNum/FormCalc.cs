namespace BigNum
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }
        private bool check_input(string s)
        {
            int n = s.Length;
            if (s.Length < 1)
                return false;
            string smin = "", smax = "";
            if (s[0] == '-')
            {
                smin += '-';
                smax += '-';
            }
            for (int i = 0; i < n; i++)
            {
                smin += '0';
                smax += '9';
            }
            if ((s.CompareTo(smax) == -1 && s.CompareTo(smin) == 1) || s == smin || s == smax)
                return true;
            return false;
        }
        private bool check_tb()
        {
            tbRs.Clear();
            if (check_input(tbBN1.Text) == false || check_input(tbBN2.Text) == false)
            {
                MessageBox.Show("Kiểm tra đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (check_tb() == false)
                return;
            BigNum BN1 = new BigNum(tbBN1.Text);
            BigNum BN2 = new BigNum(tbBN2.Text);

            if (cbbSelectFunction.SelectedItem.ToString() == "So sánh")
            {
                char kq = BN1.Compare(BN2);
                if (kq == 'l')
                    tbRs.Text = "Số thứ nhất bé hơn số thứ hai";
                else if (kq == 'e')
                    tbRs.Text = "Số thứ nhất bằng số thứ hai";
                else
                    tbRs.Text = "Số thứ nhất lớn hơn số thứ hai";
            }
            else
            {
                BigNum Rs = new BigNum("0");
                if (cbbSelectFunction.SelectedItem.ToString() == "Cộng")
                {
                    if (BN1.Sign == BN2.Sign)
                    {
                        Rs = Rs.Addition(BN1, BN2);
                        Rs.Sign = BN1.Sign;
                    }
                    else
                    {
                        Rs = Rs.Subtraction(BN1, BN2);
                        if (BN1.Abs().Compare(BN2.Abs()) == 'l')
                            Rs.Sign = BN2.Sign;
                        else if (BN1.Abs().Compare(BN2.Abs()) == 'g')
                            Rs.Sign = BN1.Sign;
                    }
                }
                else if (cbbSelectFunction.SelectedItem.ToString() == "Trừ")
                {
                    if (BN1.Sign != BN2.Sign)
                    {
                        Rs = Rs.Addition(BN1, BN2);
                        Rs.Sign = BN1.Sign;
                    }
                    else
                    {
                        Rs = Rs.Subtraction(BN1, BN2);
                        if (BN1.Abs().Compare(BN2.Abs()) == 'l')
                            Rs.Sign = BN1.Opposite().Sign;
                        else
                            Rs.Sign = BN1.Sign;
                    }
                }
                else if (cbbSelectFunction.SelectedItem.ToString() == "Lũy thừa")
                {
                    Int64 BN = Int64.Parse(tbBN2.Text);
                    Rs.Num = "1";
                    Rs = Rs.Pow(BN1, BN);
                    Rs.Sign = BN1.Sign;
                }
                else
                {
                    if (cbbSelectFunction.SelectedItem.ToString() == "Nhân")
                        Rs = Rs.Multiplication_BN_BN(BN1.Abs(), BN2.Abs());
                    else if (cbbSelectFunction.SelectedItem.ToString() == "Chia lấy phần nguyên")
                        Rs = Rs.Division(BN1.Abs(), BN2.Abs(), 0);
                    else if (cbbSelectFunction.SelectedItem.ToString() == "Chia lấy phần dư")
                        Rs = Rs.Division(BN1.Abs(), BN2.Abs(), 1);

                    if (BN1.Sign != BN2.Sign)
                        Rs.Sign = '-';
                    else
                        Rs.Sign = '+';
                }
                tbRs.Text = Rs.Show();
            }
        }
    }
}