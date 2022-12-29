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
            BigNum Result = new BigNum("0");
            string selectFunc = cbbSelectFunction.SelectedItem.ToString();
            tbRs.Text = Result.Calc(BN1, BN2, selectFunc);
        }
        private void btnCalcFile_Click(object sender, EventArgs e)
        {
            Form frm = new FormCalcFile();
            frm.Show();
        }
        private void FormCalc_Load(object sender, EventArgs e)
        {
            cbbSelectFunction.Text = "So sánh";
        }
    }
}