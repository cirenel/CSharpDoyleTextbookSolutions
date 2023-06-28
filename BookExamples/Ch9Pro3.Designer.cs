namespace BookExamples
{
    partial class Ch9Pro3
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
            this.addBtn = new System.Windows.Forms.Button();
            this.num1Txt = new System.Windows.Forms.TextBox();
            this.num2Txt = new System.Windows.Forms.TextBox();
            this.ansTxt = new System.Windows.Forms.TextBox();
            this.mulBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(302, 41);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(122, 86);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // num1Txt
            // 
            this.num1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num1Txt.Location = new System.Drawing.Point(34, 41);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(228, 44);
            this.num1Txt.TabIndex = 1;
            // 
            // num2Txt
            // 
            this.num2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num2Txt.Location = new System.Drawing.Point(34, 100);
            this.num2Txt.Name = "num2Txt";
            this.num2Txt.Size = new System.Drawing.Size(228, 44);
            this.num2Txt.TabIndex = 2;
            // 
            // ansTxt
            // 
            this.ansTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ansTxt.Location = new System.Drawing.Point(474, 41);
            this.ansTxt.Name = "ansTxt";
            this.ansTxt.Size = new System.Drawing.Size(228, 44);
            this.ansTxt.TabIndex = 3;
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(302, 143);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(122, 86);
            this.mulBtn.TabIndex = 4;
            this.mulBtn.Text = "Multiply";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(302, 246);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(122, 86);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Ch9Pro3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.ansTxt);
            this.Controls.Add(this.num2Txt);
            this.Controls.Add(this.num1Txt);
            this.Controls.Add(this.addBtn);
            this.Name = "Ch9Pro3";
            this.Text = "Ch9Pro3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox num1Txt;
        private System.Windows.Forms.TextBox num2Txt;
        private System.Windows.Forms.TextBox ansTxt;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}