namespace BigNum
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void btnCompare_Click(object sender, EventArgs e)
        {
            BigNum B1 = new BigNum(tbBN1.Text);
            BigNum B2 = new BigNum(tbBN2.Text);
            char kq = B1.Compare(B2);
            if (kq == 'l')
                tbKQ.Text = "Số thứ nhất bé hơn số thứ hai";
            else if (kq == 'e')
                tbKQ.Text = "Số thứ nhất bằng số thứ hai";
            else
                tbKQ.Text = "Số thứ nhất lớn hơn số thứ hai";
        }
        private bool check_tb()
        {
            if (check_input(tbBN1.Text) == false || check_input(tbBN2.Text) == false)
            {
                MessageBox.Show("Kiểm tra đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            tbBN2.Clear();
            BigNum B1 = new BigNum(tbBN1.Text);
            List<Int64> list = B1.CutNum(15);
            for (int i = 0; i < list.Count; i++)
            {
                tbBN2.Text += list[i].ToString() + ' ';

            }
        }
    }
}