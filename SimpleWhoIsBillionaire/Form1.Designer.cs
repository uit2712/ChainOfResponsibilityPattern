namespace SimpleWhoIsBillionaire
{
    partial class Form1
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
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestionContent = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.rbAnswerD = new System.Windows.Forms.RadioButton();
            this.rbAnswerC = new System.Windows.Forms.RadioButton();
            this.rbAnswerB = new System.Windows.Forms.RadioButton();
            this.rbAnswerA = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(22, 13);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(84, 20);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Câu hỏi số";
            // 
            // lblQuestionContent
            // 
            this.lblQuestionContent.AutoSize = true;
            this.lblQuestionContent.Location = new System.Drawing.Point(26, 45);
            this.lblQuestionContent.Name = "lblQuestionContent";
            this.lblQuestionContent.Size = new System.Drawing.Size(72, 20);
            this.lblQuestionContent.TabIndex = 1;
            this.lblQuestionContent.Text = "Nội dung";
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Location = new System.Drawing.Point(26, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(676, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.Location = new System.Drawing.Point(416, 13);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(114, 20);
            this.lblMoneyTitle.TabIndex = 0;
            this.lblMoneyTitle.Text = "Số tiền hiện có";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(536, 13);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(56, 20);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "0 VNĐ";
            // 
            // rbAnswerD
            // 
            this.rbAnswerD.AutoSize = true;
            this.rbAnswerD.Location = new System.Drawing.Point(30, 173);
            this.rbAnswerD.Name = "rbAnswerD";
            this.rbAnswerD.Size = new System.Drawing.Size(114, 24);
            this.rbAnswerD.TabIndex = 4;
            this.rbAnswerD.TabStop = true;
            this.rbAnswerD.Text = "Câu trả lời D";
            this.rbAnswerD.UseVisualStyleBackColor = true;
            // 
            // rbAnswerC
            // 
            this.rbAnswerC.AutoSize = true;
            this.rbAnswerC.Location = new System.Drawing.Point(30, 143);
            this.rbAnswerC.Name = "rbAnswerC";
            this.rbAnswerC.Size = new System.Drawing.Size(113, 24);
            this.rbAnswerC.TabIndex = 5;
            this.rbAnswerC.TabStop = true;
            this.rbAnswerC.Text = "Câu trả lời C";
            this.rbAnswerC.UseVisualStyleBackColor = true;
            // 
            // rbAnswerB
            // 
            this.rbAnswerB.AutoSize = true;
            this.rbAnswerB.Location = new System.Drawing.Point(30, 113);
            this.rbAnswerB.Name = "rbAnswerB";
            this.rbAnswerB.Size = new System.Drawing.Size(113, 24);
            this.rbAnswerB.TabIndex = 6;
            this.rbAnswerB.TabStop = true;
            this.rbAnswerB.Text = "Câu trả lời B";
            this.rbAnswerB.UseVisualStyleBackColor = true;
            // 
            // rbAnswerA
            // 
            this.rbAnswerA.AutoSize = true;
            this.rbAnswerA.Location = new System.Drawing.Point(30, 83);
            this.rbAnswerA.Name = "rbAnswerA";
            this.rbAnswerA.Size = new System.Drawing.Size(113, 24);
            this.rbAnswerA.TabIndex = 7;
            this.rbAnswerA.TabStop = true;
            this.rbAnswerA.Text = "Câu trả lời A";
            this.rbAnswerA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 279);
            this.Controls.Add(this.rbAnswerD);
            this.Controls.Add(this.rbAnswerC);
            this.Controls.Add(this.rbAnswerB);
            this.Controls.Add(this.rbAnswerA);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblQuestionContent);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMoneyTitle);
            this.Controls.Add(this.lblQuestionNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestionContent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMoneyTitle;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.RadioButton rbAnswerD;
        private System.Windows.Forms.RadioButton rbAnswerC;
        private System.Windows.Forms.RadioButton rbAnswerB;
        private System.Windows.Forms.RadioButton rbAnswerA;
    }
}

