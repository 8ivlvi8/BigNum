namespace BigNum
{
    partial class FormProblem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbtnFactorial = new System.Windows.Forms.RadioButton();
            this.rbtnFibo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(603, 118);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(130, 39);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Thực hiện";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rbtnFactorial
            // 
            this.rbtnFactorial.AutoSize = true;
            this.rbtnFactorial.Location = new System.Drawing.Point(25, 26);
            this.rbtnFactorial.Name = "rbtnFactorial";
            this.rbtnFactorial.Size = new System.Drawing.Size(120, 25);
            this.rbtnFactorial.TabIndex = 1;
            this.rbtnFactorial.TabStop = true;
            this.rbtnFactorial.Text = "Giai thừa (n!)";
            this.rbtnFactorial.UseVisualStyleBackColor = true;
            // 
            // rbtnFibo
            // 
            this.rbtnFibo.AutoSize = true;
            this.rbtnFibo.Location = new System.Drawing.Point(25, 51);
            this.rbtnFibo.Name = "rbtnFibo";
            this.rbtnFibo.Size = new System.Drawing.Size(197, 25);
            this.rbtnFibo.TabIndex = 1;
            this.rbtnFibo.TabStop = true;
            this.rbtnFibo.Text = "F(n): Số Fibonacci thứ n";
            this.rbtnFibo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFactorial);
            this.groupBox1.Controls.Add(this.rbtnFibo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(550, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn bài toán";
            // 
            // tbinput
            // 
            this.tbinput.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbinput.Location = new System.Drawing.Point(114, 12);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(430, 27);
            this.tbinput.TabIndex = 3;
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResult.Location = new System.Drawing.Point(114, 45);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(430, 112);
            this.tbResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập n (>0):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả:";
            // 
            // FormProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProblem";
            this.Load += new System.EventHandler(this.FormProblem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalc;
        private RadioButton rbtnFactorial;
        private RadioButton rbtnFibo;
        private GroupBox groupBox1;
        private TextBox tbinput;
        private TextBox tbResult;
        private Label label1;
        private Label label2;
    }
}