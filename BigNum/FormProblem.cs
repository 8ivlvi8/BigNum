using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigNum
{
    public partial class FormProblem : Form
    {
        public FormProblem()
        {
            InitializeComponent();
        }

        private void FormProblem_Load(object sender, EventArgs e)
        {
            rbtnFactorial.Select();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool check = int.TryParse(tbinput.Text, out n);
            if (!check || ((n = int.Parse(tbinput.Text)) < 1) || n < 1)
            {
                MessageBox.Show("Kiểm tra đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BigNum Result = new BigNum("1");
            if (rbtnFactorial.Checked)
            {
                BigNum BN = new BigNum("1");
                for (int i = 1; i <= n; i++)
                    BN *= i;
                Result = BN;
            }
            if (rbtnFibo.Checked)
            {
                BigNum a = new BigNum("1");
                BigNum b = new BigNum("1");
                BigNum c = new BigNum("1");
                for (int i = 3; i <=n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Result = c;
            }
            tbResult.Text = Result.Show();
        }
    }
}
