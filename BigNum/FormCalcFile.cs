using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigNum
{
    public partial class FormCalcFile : Form
    {
        public FormCalcFile()
        {
            InitializeComponent();
        }
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbPath.Text = openFileDialog1.FileName;
        }

        private void btnCalcFile_Click(object sender, EventArgs e)
        {
            try
            {

                string input = tbPath.Text;
                int k = 0;
                for (int i = 0; i < input.Length; i++)
                    if (input[i] == '\\') k = i;
                string output = "";
                for (int i = 0; i < k; i++)
                    output += input[i];
                output += "\\Result.txt";

                FileStream f = new FileStream(input, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(f, Encoding.UTF8);
                string line;
                List<string> lststr = new List<string>();
                // doc cac dong cho toi cuoi file
                while ((line = sr.ReadLine()) != null)
                    lststr.Add(line);
                sr.Close();
                f.Close();

                int len_lst = lststr.Count;
                if (len_lst % 3 != 0)
                {
                    MessageBox.Show("Kiểm tra dữ liệu trong file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                f = new FileStream(output, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(f, Encoding.UTF8);

                Form frm = new FormProcess();
                frm.Show();
                Task.Delay(100).Wait();

                len_lst /= 3;
                for (int i = 0; i < len_lst; i++)
                {
                    BigNum BN1 = new BigNum(lststr[3 * i]);
                    string selectFunc = lststr[3 * i + 1];
                    BigNum BN2 = new BigNum(lststr[3 * i + 2]);
                    BigNum Result = new BigNum("0");
                    sw.WriteLine(Result.Calc(BN1, BN2, selectFunc));
                    sw.Flush();
                }
                frm.Close();
                sw.Close();
                f.Close();
                MessageBox.Show("Xử lý xong!\n" +
                    "Kết quả được lưu ở \""+output+"\"");
            }
            catch
            {
                MessageBox.Show("Kiểm tra đường dẫn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

