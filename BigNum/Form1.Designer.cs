namespace BigNum
{
    partial class Form1
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
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBN1
            // 
            this.tbBN1.Location = new System.Drawing.Point(97, 9);
            this.tbBN1.Multiline = true;
            this.tbBN1.Name = "tbBN1";
            this.tbBN1.Size = new System.Drawing.Size(519, 45);
            this.tbBN1.TabIndex = 0;
            // 
            // tbBN2
            // 
            this.tbBN2.Location = new System.Drawing.Point(97, 60);
            this.tbBN2.Multiline = true;
            this.tbBN2.Name = "tbBN2";
            this.tbBN2.Size = new System.Drawing.Size(519, 45);
            this.tbBN2.TabIndex = 0;
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(97, 111);
            this.tbKQ.Multiline = true;
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(519, 45);
            this.tbKQ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(44, 204);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "So sánh";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(138, 204);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "Cộng";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tbBN2);
            this.Controls.Add(this.tbBN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBN1;
        private TextBox tbBN2;
        private TextBox tbKQ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCompare;
        private Button btnAddition;
    }
}