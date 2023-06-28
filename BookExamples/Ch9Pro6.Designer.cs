namespace BookExamples
{
    partial class Ch9Pro6
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.compareBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pwTxt1 = new System.Windows.Forms.TextBox();
            this.pwText2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(546, 66);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(134, 77);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Text = "Test Password";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(546, 188);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(134, 77);
            this.compareBtn.TabIndex = 1;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Visible = false;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password:";
            // 
            // pwTxt1
            // 
            this.pwTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pwTxt1.Location = new System.Drawing.Point(31, 82);
            this.pwTxt1.Name = "pwTxt1";
            this.pwTxt1.Size = new System.Drawing.Size(487, 44);
            this.pwTxt1.TabIndex = 3;
            // 
            // pwText2
            // 
            this.pwText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pwText2.Location = new System.Drawing.Point(31, 206);
            this.pwText2.Name = "pwText2";
            this.pwText2.Size = new System.Drawing.Size(487, 44);
            this.pwText2.TabIndex = 5;
            this.pwText2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Retype New Password:";
            this.label2.Visible = false;
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(546, 302);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(134, 77);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.Text = "Confirm Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Visible = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Ch9Pro6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.pwText2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwTxt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.confirmBtn);
            this.Name = "Ch9Pro6";
            this.Text = "Ch9Pro6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwTxt1;
        private System.Windows.Forms.TextBox pwText2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeBtn;
    }
}