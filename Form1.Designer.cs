namespace Calculator
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblInputNumberOrResult = new System.Windows.Forms.Label();
            this.lblCalHistory = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearLast = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblInputNumberOrResult);
            this.pnlTop.Controls.Add(this.lblCalHistory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(285, 128);
            this.pnlTop.TabIndex = 0;
            // 
            // lblInputNumberOrResult
            // 
            this.lblInputNumberOrResult.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.lblInputNumberOrResult.Location = new System.Drawing.Point(3, 55);
            this.lblInputNumberOrResult.Name = "lblInputNumberOrResult";
            this.lblInputNumberOrResult.Size = new System.Drawing.Size(259, 70);
            this.lblInputNumberOrResult.TabIndex = 1;
            this.lblInputNumberOrResult.Text = "123,456,789";
            this.lblInputNumberOrResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalHistory
            // 
            this.lblCalHistory.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lblCalHistory.Location = new System.Drawing.Point(5, 7);
            this.lblCalHistory.Name = "lblCalHistory";
            this.lblCalHistory.Size = new System.Drawing.Size(257, 38);
            this.lblCalHistory.TabIndex = 0;
            this.lblCalHistory.Text = "123,456,789";
            this.lblCalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnEqual);
            this.pnlBody.Controls.Add(this.btnDot);
            this.pnlBody.Controls.Add(this.btn0);
            this.pnlBody.Controls.Add(this.btnPlus);
            this.pnlBody.Controls.Add(this.btn3);
            this.pnlBody.Controls.Add(this.btn2);
            this.pnlBody.Controls.Add(this.btn1);
            this.pnlBody.Controls.Add(this.btnMinus);
            this.pnlBody.Controls.Add(this.btn6);
            this.pnlBody.Controls.Add(this.btn5);
            this.pnlBody.Controls.Add(this.btn4);
            this.pnlBody.Controls.Add(this.btnMultiple);
            this.pnlBody.Controls.Add(this.btn9);
            this.pnlBody.Controls.Add(this.btn8);
            this.pnlBody.Controls.Add(this.btn7);
            this.pnlBody.Controls.Add(this.btnDivide);
            this.pnlBody.Controls.Add(this.btnBackspace);
            this.pnlBody.Controls.Add(this.btnClearAll);
            this.pnlBody.Controls.Add(this.btnClearLast);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 128);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(285, 355);
            this.pnlBody.TabIndex = 1;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(213, 282);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 63);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(145, 282);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(62, 63);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = "．";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(74, 282);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 63);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(213, 213);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 63);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "＋";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(145, 213);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 63);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(77, 213);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 63);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(9, 213);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 63);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(213, 144);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 63);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "－";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(145, 144);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 63);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(77, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 63);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(9, 144);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 63);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(213, 75);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(62, 63);
            this.btnMultiple.TabIndex = 7;
            this.btnMultiple.Text = "＊";
            this.btnMultiple.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(145, 75);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 63);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(77, 75);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 63);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(9, 75);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 63);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(213, 6);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(62, 63);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "／";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(145, 6);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(62, 63);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(77, 6);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(62, 63);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnClearLast
            // 
            this.btnClearLast.Location = new System.Drawing.Point(9, 6);
            this.btnClearLast.Name = "btnClearLast";
            this.btnClearLast.Size = new System.Drawing.Size(62, 63);
            this.btnClearLast.TabIndex = 0;
            this.btnClearLast.Text = "CE";
            this.btnClearLast.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 483);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblInputNumberOrResult;
        private System.Windows.Forms.Label lblCalHistory;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearLast;
    }
}

