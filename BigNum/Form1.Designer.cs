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
            this.tbRs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBN1
            // 
            this.tbBN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBN1.Location = new System.Drawing.Point(125, 12);
            this.tbBN1.Multiline = true;
            this.tbBN1.Name = "tbBN1";
            this.tbBN1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBN1.Size = new System.Drawing.Size(519, 86);
            this.tbBN1.TabIndex = 0;
            // 
            // tbBN2
            // 
            this.tbBN2.Location = new System.Drawing.Point(125, 104);
            this.tbBN2.Multiline = true;
            this.tbBN2.Name = "tbBN2";
            this.tbBN2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBN2.Size = new System.Drawing.Size(519, 86);
            this.tbBN2.TabIndex = 0;
            // 
            // tbRs
            // 
            this.tbRs.Location = new System.Drawing.Point(125, 196);
            this.tbRs.Multiline = true;
            this.tbRs.Name = "tbRs";
            this.tbRs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRs.Size = new System.Drawing.Size(519, 86);
            this.tbRs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(28, 295);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "So sánh";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(109, 295);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "Cộng";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(190, 295);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 4;
            this.btnSubtraction.Text = "Trừ";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(271, 295);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 5;
            this.btnMultiplication.Text = "Nhân";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(352, 295);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(75, 23);
            this.btn_Division.TabIndex = 5;
            this.btn_Division.Text = "Chia";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 329);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRs);
            this.Controls.Add(this.tbBN2);
            this.Controls.Add(this.tbBN1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BigNum";
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
        private Button btnCompare;
        private Button btnAddition;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btn_Division;
    }
}