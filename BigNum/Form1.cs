namespace BigNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            BigNum B1 = new BigNum(tbBN1.Text);
            BigNum B2= new BigNum(tbBN2.Text);
            char kq = B1.Compare(B2);
            if (kq == 'l')
                tbKQ.Text = "Số thứ nhất bé hơn số thứ hai";
            else if (kq == 'e')
                tbKQ.Text = "Số thứ nhất bằng số thứ hai";
            else
                tbKQ.Text = "Số thứ nhất lớn hơn số thứ hai";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

        }
    }
}