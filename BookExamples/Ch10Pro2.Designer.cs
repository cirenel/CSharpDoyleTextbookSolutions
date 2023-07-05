
namespace BookExamples
{
    partial class Ch10Pro2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.colorCombo = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.displayOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Your Color";
            // 
            // sizeCombo
            // 
            this.sizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.sizeCombo.Location = new System.Drawing.Point(17, 76);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(167, 50);
            this.sizeCombo.TabIndex = 2;
            // 
            // colorCombo
            // 
            this.colorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCombo.FormattingEnabled = true;
            this.colorCombo.Items.AddRange(new object[] {
            "Black",
            "White",
            "Orange",
            "Purple"});
            this.colorCombo.Location = new System.Drawing.Point(17, 206);
            this.colorCombo.Name = "colorCombo";
            this.colorCombo.Size = new System.Drawing.Size(167, 50);
            this.colorCombo.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(298, 58);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(196, 68);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add to Order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Include your name:";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(17, 346);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(420, 49);
            this.nameText.TabIndex = 6;
            // 
            // displayOrder
            // 
            this.displayOrder.Location = new System.Drawing.Point(298, 188);
            this.displayOrder.Name = "displayOrder";
            this.displayOrder.Size = new System.Drawing.Size(196, 68);
            this.displayOrder.TabIndex = 7;
            this.displayOrder.Text = "Display Order";
            this.displayOrder.UseVisualStyleBackColor = true;
            this.displayOrder.Click += new System.EventHandler(this.displayOrder_Click);
            // 
            // Ch10Pro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 554);
            this.Controls.Add(this.displayOrder);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.colorCombo);
            this.Controls.Add(this.sizeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ch10Pro2";
            this.Text = "Ch10Pro2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.ComboBox colorCombo;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button displayOrder;
    }
}