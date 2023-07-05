
namespace BookExamples
{
    partial class Ch10Pro9
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hardwoodTab = new System.Windows.Forms.TabPage();
            this.hardwoodList = new System.Windows.Forms.ListBox();
            this.carpetTab = new System.Windows.Forms.TabPage();
            this.carpetList = new System.Windows.Forms.ListBox();
            this.laminateTab = new System.Windows.Forms.TabPage();
            this.laminateList = new System.Windows.Forms.ListBox();
            this.tileTab = new System.Windows.Forms.TabPage();
            this.tileList = new System.Windows.Forms.ListBox();
            this.computeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lenFtTxt = new System.Windows.Forms.TextBox();
            this.lenInTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.widInTxt = new System.Windows.Forms.TextBox();
            this.widFtTxt = new System.Windows.Forms.TextBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.yardLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.hardwoodTab.SuspendLayout();
            this.carpetTab.SuspendLayout();
            this.laminateTab.SuspendLayout();
            this.tileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hardwoodTab);
            this.tabControl1.Controls.Add(this.carpetTab);
            this.tabControl1.Controls.Add(this.laminateTab);
            this.tabControl1.Controls.Add(this.tileTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // hardwoodTab
            // 
            this.hardwoodTab.Controls.Add(this.hardwoodList);
            this.hardwoodTab.Location = new System.Drawing.Point(8, 39);
            this.hardwoodTab.Name = "hardwoodTab";
            this.hardwoodTab.Padding = new System.Windows.Forms.Padding(3);
            this.hardwoodTab.Size = new System.Drawing.Size(851, 605);
            this.hardwoodTab.TabIndex = 0;
            this.hardwoodTab.Text = "Hardwood";
            this.hardwoodTab.UseVisualStyleBackColor = true;
            // 
            // hardwoodList
            // 
            this.hardwoodList.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwoodList.FormattingEnabled = true;
            this.hardwoodList.ItemHeight = 32;
            this.hardwoodList.Items.AddRange(new object[] {
            $"{"Cherry ".PadRight(40,'.')} {40.50:c2}",
            $"{"Oak ".PadRight(40,'.')} {20.45:c2}",
            $"{"Pine ".PadRight(40,'.')} {15.40:c2}",
            $"{"Maple ".PadRight(40,'.')} {40.32:c2}",
            $"{"Walnut ".PadRight(40,'.')} {34.95:c2}"});
            this.hardwoodList.Location = new System.Drawing.Point(13, 59);
            this.hardwoodList.Name = "hardwoodList";
            this.hardwoodList.Size = new System.Drawing.Size(798, 420);
            this.hardwoodList.TabIndex = 0;
            // 
            // carpetTab
            // 
            this.carpetTab.Controls.Add(this.carpetList);
            this.carpetTab.Location = new System.Drawing.Point(8, 39);
            this.carpetTab.Name = "carpetTab";
            this.carpetTab.Padding = new System.Windows.Forms.Padding(3);
            this.carpetTab.Size = new System.Drawing.Size(851, 605);
            this.carpetTab.TabIndex = 1;
            this.carpetTab.Text = "Carpet";
            this.carpetTab.UseVisualStyleBackColor = true;
            // 
            // carpetList
            // 
            this.carpetList.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetList.FormattingEnabled = true;
            this.carpetList.ItemHeight = 32;
            this.carpetList.Items.AddRange(new object[] {
            $"{"Berber ".PadRight(40,'.')} {80.50:c2}",
            $"{"Wool ".PadRight(40,'.')} {63.45:c2}",
            $"{"Skating Rink ".PadRight(40,'.')} {15.40:c2}",
            $"{"Nylon ".PadRight(40,'.')} {17.32:c2}",
            $"{"Polyester ".PadRight(40,'.')} {21.95:c2}"});
            this.carpetList.Location = new System.Drawing.Point(13, 59);
            this.carpetList.Name = "carpetList";
            this.carpetList.Size = new System.Drawing.Size(798, 420);
            this.carpetList.TabIndex = 1;
            // 
            // laminateTab
            // 
            this.laminateTab.Controls.Add(this.laminateList);
            this.laminateTab.Location = new System.Drawing.Point(8, 39);
            this.laminateTab.Name = "laminateTab";
            this.laminateTab.Padding = new System.Windows.Forms.Padding(3);
            this.laminateTab.Size = new System.Drawing.Size(851, 605);
            this.laminateTab.TabIndex = 2;
            this.laminateTab.Text = "Laminate";
            this.laminateTab.UseVisualStyleBackColor = true;
            // 
            // laminateList
            // 
            this.laminateList.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laminateList.FormattingEnabled = true;
            this.laminateList.ItemHeight = 32;

            this.laminateList.Location = new System.Drawing.Point(13, 59);
            this.laminateList.Name = "laminateList";
            this.laminateList.Items.AddRange(new object[] {
            $"{"Imitation Marble ".PadRight(40,'.')} {29.50:c2}",
            $"{"Imitation Stone ".PadRight(40,'.')} {12.25:c2}",
            $"{"Imitation Wood ".PadRight(40,'.')} {15.40:c2}",
            $"{"Classic Brick ".PadRight(40,'.')} {20.32:c2}"});
            this.laminateList.Size = new System.Drawing.Size(798, 420);
            this.laminateList.TabIndex = 1;
            // 
            // tileTab
            // 
            this.tileTab.Controls.Add(this.tileList);
            this.tileTab.Location = new System.Drawing.Point(8, 39);
            this.tileTab.Name = "tileTab";
            this.tileTab.Size = new System.Drawing.Size(851, 605);
            this.tileTab.TabIndex = 3;
            this.tileTab.Text = "Tile";
            this.tileTab.UseVisualStyleBackColor = true;
            // 
            // tileList
            // 
            this.tileList.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileList.FormattingEnabled = true;
            this.tileList.ItemHeight = 32;
            this.tileList.Location = new System.Drawing.Point(13, 59);
            this.tileList.Name = "tileList";
            this.tileList.Items.AddRange(new object[] {
            $"{"Marble ".PadRight(40,'.')} {50.50:c2}",
            $"{"Granite ".PadRight(40,'.')} {30.45:c2}",
            $"{"Ceramic ".PadRight(40,'.')} {25.40:c2}",
            $"{"Imitation Brick ".PadRight(40,'.')} {14.32:c2}"});
            this.tileList.Size = new System.Drawing.Size(798, 420);
            this.tileList.TabIndex = 1;
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(1026, 523);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(223, 130);
            this.computeBtn.TabIndex = 1;
            this.computeBtn.Text = "Compute";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1021, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // lenFtTxt
            // 
            this.lenFtTxt.Location = new System.Drawing.Point(1026, 109);
            this.lenFtTxt.Name = "lenFtTxt";
            this.lenFtTxt.Size = new System.Drawing.Size(100, 31);
            this.lenFtTxt.TabIndex = 4;
            this.lenFtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intText_KeyPress);
            // 
            // lenInTxt
            // 
            this.lenInTxt.Location = new System.Drawing.Point(1149, 109);
            this.lenInTxt.Name = "lenInTxt";
            this.lenInTxt.Size = new System.Drawing.Size(100, 31);
            this.lenInTxt.TabIndex = 5;
            this.lenInTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1097, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1220, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1220, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1097, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "ft";
            // 
            // widInTxt
            // 
            this.widInTxt.Location = new System.Drawing.Point(1149, 234);
            this.widInTxt.Name = "widInTxt";
            this.widInTxt.Size = new System.Drawing.Size(100, 31);
            this.widInTxt.TabIndex = 9;
            this.widInTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intText_KeyPress);
            // 
            // widFtTxt
            // 
            this.widFtTxt.Location = new System.Drawing.Point(1026, 234);
            this.widFtTxt.Name = "widFtTxt";
            this.widFtTxt.Size = new System.Drawing.Size(100, 31);
            this.widFtTxt.TabIndex = 8;
            this.widFtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intText_KeyPress);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(893, 314);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 33);
            this.displayLabel.TabIndex = 12;
            // 
            // yardLbl
            // 
            this.yardLbl.AutoSize = true;
            this.yardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yardLbl.Location = new System.Drawing.Point(13, 23);
            this.yardLbl.Name = "yardLbl";
            this.yardLbl.Size = new System.Drawing.Size(367, 37);
            this.yardLbl.TabIndex = 13;
            this.yardLbl.Text = "All prices by square yard";
            // 
            // Ch10Pro9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 752);
            this.Controls.Add(this.yardLbl);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.widInTxt);
            this.Controls.Add(this.widFtTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lenInTxt);
            this.Controls.Add(this.lenFtTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Ch10Pro9";
            this.Text = "Ch10Pro9";
            this.tabControl1.ResumeLayout(false);
            this.hardwoodTab.ResumeLayout(false);
            this.carpetTab.ResumeLayout(false);
            this.laminateTab.ResumeLayout(false);
            this.tileTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hardwoodTab;
        private System.Windows.Forms.ListBox hardwoodList;
        private System.Windows.Forms.TabPage carpetTab;
        private System.Windows.Forms.ListBox carpetList;
        private System.Windows.Forms.TabPage laminateTab;
        private System.Windows.Forms.ListBox laminateList;
        private System.Windows.Forms.TabPage tileTab;
        private System.Windows.Forms.ListBox tileList;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lenFtTxt;
        private System.Windows.Forms.TextBox lenInTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox widInTxt;
        private System.Windows.Forms.TextBox widFtTxt;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label yardLbl;
    }
}