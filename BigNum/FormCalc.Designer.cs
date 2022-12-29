namespace BigNum
{
    partial class FormCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBN1 = new System.Windows.Forms.TextBox();
            this.tbBN2 = new System.Windows.Forms.TextBox();
            this.tbRs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSelectFunction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCalcFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBN1
            // 
            this.tbBN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBN1.Location = new System.Drawing.Point(112, 12);
            this.tbBN1.Multiline = true;
            this.tbBN1.Name = "tbBN1";
            this.tbBN1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBN1.Size = new System.Drawing.Size(415, 105);
            this.tbBN1.TabIndex = 0;
            // 
            // tbBN2
            // 
            this.tbBN2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBN2.Location = new System.Drawing.Point(112, 123);
            this.tbBN2.Multiline = true;
            this.tbBN2.Name = "tbBN2";
            this.tbBN2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBN2.Size = new System.Drawing.Size(415, 105);
            this.tbBN2.TabIndex = 0;
            // 
            // tbRs
            // 
            this.tbRs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRs.Location = new System.Drawing.Point(112, 234);
            this.tbRs.Multiline = true;
            this.tbRs.Name = "tbRs";
            this.tbRs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRs.Size = new System.Drawing.Size(415, 105);
            this.tbRs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // cbbSelectFunction
            // 
            this.cbbSelectFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbbSelectFunction.FormattingEnabled = true;
            this.cbbSelectFunction.ItemHeight = 21;
            this.cbbSelectFunction.Items.AddRange(new object[] {
            "So sánh",
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia lấy phần nguyên",
            "Chia lấy phần dư",
            "Lũy thừa"});
            this.cbbSelectFunction.Location = new System.Drawing.Point(542, 116);
            this.cbbSelectFunction.Margin = new System.Windows.Forms.Padding(5);
            this.cbbSelectFunction.Name = "cbbSelectFunction";
            this.cbbSelectFunction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbSelectFunction.Size = new System.Drawing.Size(181, 29);
            this.cbbSelectFunction.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chọn phép toán";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(570, 150);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(125, 35);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Thực hiện";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCalcFile
            // 
            this.btnCalcFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcFile.Location = new System.Drawing.Point(570, 191);
            this.btnCalcFile.Name = "btnCalcFile";
            this.btnCalcFile.Size = new System.Drawing.Size(125, 37);
            this.btnCalcFile.TabIndex = 6;
            this.btnCalcFile.Text = "Xử lý file";
            this.btnCalcFile.UseVisualStyleBackColor = true;
            this.btnCalcFile.Click += new System.EventHandler(this.btnCalcFile_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 355);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbSelectFunction);
            this.Controls.Add(this.btnCalcFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRs);
            this.Controls.Add(this.tbBN2);
            this.Controls.Add(this.tbBN1);
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BigNum";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBN1;
        private TextBox tbBN2;
        private TextBox tbRs;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbSelectFunction;
        private Label label4;
        private Button btnCalc;
        private Button btnCalcFile;
    }
}