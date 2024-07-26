namespace Calcolatrice {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Risultato = new Panel();
            RESULT = new Label();
            EXPRESSION = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b6 = new Button();
            b9 = new Button();
            b8 = new Button();
            b5 = new Button();
            b4 = new Button();
            b7 = new Button();
            b0 = new Button();
            button10 = new Button();
            bAns = new Button();
            bEquals = new Button();
            bMinus = new Button();
            bPlus = new Button();
            bTimes = new Button();
            bDivide = new Button();
            bAC = new Button();
            bD = new Button();
            offf = new Label();
            OFF = new PictureBox();
            Risultato.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OFF).BeginInit();
            SuspendLayout();
            // 
            // Risultato
            // 
            Risultato.BackColor = Color.FromArgb(207, 227, 228);
            Risultato.Controls.Add(RESULT);
            Risultato.Controls.Add(EXPRESSION);
            Risultato.Location = new Point(15, 18);
            Risultato.Name = "Risultato";
            Risultato.Size = new Size(337, 100);
            Risultato.TabIndex = 2;
            // 
            // RESULT
            // 
            RESULT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RESULT.Location = new Point(10, 69);
            RESULT.Name = "RESULT";
            RESULT.Size = new Size(317, 22);
            RESULT.TabIndex = 1;
            // 
            // EXPRESSION
            // 
            EXPRESSION.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EXPRESSION.Location = new Point(10, 9);
            EXPRESSION.Name = "EXPRESSION";
            EXPRESSION.Size = new Size(317, 60);
            EXPRESSION.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 44, 44);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(offf);
            panel2.Controls.Add(OFF);
            panel2.Controls.Add(Risultato);
            panel2.Location = new Point(12, 12);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 431);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(b1, 0, 2);
            tableLayoutPanel1.Controls.Add(b2, 1, 2);
            tableLayoutPanel1.Controls.Add(b3, 2, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b9, 2, 0);
            tableLayoutPanel1.Controls.Add(b8, 1, 0);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b7, 0, 0);
            tableLayoutPanel1.Controls.Add(b0, 0, 3);
            tableLayoutPanel1.Controls.Add(button10, 1, 3);
            tableLayoutPanel1.Controls.Add(bAns, 3, 3);
            tableLayoutPanel1.Controls.Add(bEquals, 4, 3);
            tableLayoutPanel1.Controls.Add(bMinus, 4, 2);
            tableLayoutPanel1.Controls.Add(bPlus, 3, 2);
            tableLayoutPanel1.Controls.Add(bTimes, 3, 1);
            tableLayoutPanel1.Controls.Add(bDivide, 4, 1);
            tableLayoutPanel1.Controls.Add(bAC, 4, 0);
            tableLayoutPanel1.Controls.Add(bD, 3, 0);
            tableLayoutPanel1.Location = new Point(25, 190);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(317, 240);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // b1
            // 
            b1.BackColor = Color.FromArgb(115, 115, 114);
            b1.BackgroundImageLayout = ImageLayout.None;
            b1.Cursor = Cursors.Hand;
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b1.ForeColor = Color.White;
            b1.Location = new Point(0, 120);
            b1.Margin = new Padding(0);
            b1.Name = "b1";
            b1.Size = new Size(55, 43);
            b1.TabIndex = 5;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.FromArgb(115, 115, 114);
            b2.BackgroundImageLayout = ImageLayout.None;
            b2.Cursor = Cursors.Hand;
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b2.ForeColor = Color.White;
            b2.Location = new Point(63, 120);
            b2.Margin = new Padding(0);
            b2.Name = "b2";
            b2.Size = new Size(55, 43);
            b2.TabIndex = 5;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.FromArgb(115, 115, 114);
            b3.BackgroundImageLayout = ImageLayout.None;
            b3.Cursor = Cursors.Hand;
            b3.FlatStyle = FlatStyle.Popup;
            b3.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b3.ForeColor = Color.White;
            b3.Location = new Point(126, 120);
            b3.Margin = new Padding(0);
            b3.Name = "b3";
            b3.Size = new Size(55, 43);
            b3.TabIndex = 5;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.FromArgb(115, 115, 114);
            b6.BackgroundImageLayout = ImageLayout.None;
            b6.Cursor = Cursors.Hand;
            b6.FlatStyle = FlatStyle.Popup;
            b6.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b6.ForeColor = Color.White;
            b6.Location = new Point(126, 60);
            b6.Margin = new Padding(0);
            b6.Name = "b6";
            b6.Size = new Size(55, 43);
            b6.TabIndex = 5;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.FromArgb(115, 115, 114);
            b9.BackgroundImageLayout = ImageLayout.None;
            b9.Cursor = Cursors.Hand;
            b9.FlatStyle = FlatStyle.Popup;
            b9.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b9.ForeColor = Color.White;
            b9.Location = new Point(126, 0);
            b9.Margin = new Padding(0);
            b9.Name = "b9";
            b9.Size = new Size(55, 43);
            b9.TabIndex = 5;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.FromArgb(115, 115, 114);
            b8.BackgroundImageLayout = ImageLayout.None;
            b8.Cursor = Cursors.Hand;
            b8.FlatStyle = FlatStyle.Popup;
            b8.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b8.ForeColor = Color.White;
            b8.Location = new Point(63, 0);
            b8.Margin = new Padding(0);
            b8.Name = "b8";
            b8.Size = new Size(55, 43);
            b8.TabIndex = 5;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.FromArgb(115, 115, 114);
            b5.BackgroundImageLayout = ImageLayout.None;
            b5.Cursor = Cursors.Hand;
            b5.FlatStyle = FlatStyle.Popup;
            b5.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b5.ForeColor = Color.White;
            b5.Location = new Point(63, 60);
            b5.Margin = new Padding(0);
            b5.Name = "b5";
            b5.Size = new Size(55, 43);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.FromArgb(115, 115, 114);
            b4.BackgroundImageLayout = ImageLayout.None;
            b4.Cursor = Cursors.Hand;
            b4.FlatStyle = FlatStyle.Popup;
            b4.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b4.ForeColor = Color.White;
            b4.Location = new Point(0, 60);
            b4.Margin = new Padding(0);
            b4.Name = "b4";
            b4.Size = new Size(55, 43);
            b4.TabIndex = 5;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.FromArgb(115, 115, 114);
            b7.BackgroundImageLayout = ImageLayout.None;
            b7.Cursor = Cursors.Hand;
            b7.FlatStyle = FlatStyle.Popup;
            b7.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b7.ForeColor = Color.White;
            b7.Location = new Point(0, 0);
            b7.Margin = new Padding(0);
            b7.Name = "b7";
            b7.Size = new Size(55, 43);
            b7.TabIndex = 5;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b0
            // 
            b0.BackColor = Color.FromArgb(115, 115, 114);
            b0.BackgroundImageLayout = ImageLayout.None;
            b0.Cursor = Cursors.Hand;
            b0.FlatStyle = FlatStyle.Popup;
            b0.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b0.ForeColor = Color.White;
            b0.Location = new Point(0, 180);
            b0.Margin = new Padding(0);
            b0.Name = "b0";
            b0.Size = new Size(55, 43);
            b0.TabIndex = 5;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b0_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(115, 115, 114);
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Cursor = Cursors.Hand;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(63, 180);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(55, 43);
            button10.TabIndex = 5;
            button10.Text = "·";
            button10.UseVisualStyleBackColor = false;
            // 
            // bAns
            // 
            bAns.BackColor = Color.FromArgb(115, 115, 114);
            bAns.BackgroundImageLayout = ImageLayout.None;
            bAns.Cursor = Cursors.Hand;
            bAns.FlatStyle = FlatStyle.Popup;
            bAns.Font = new Font("Cascadia Mono", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAns.ForeColor = Color.White;
            bAns.Location = new Point(189, 180);
            bAns.Margin = new Padding(0);
            bAns.Name = "bAns";
            bAns.Size = new Size(55, 43);
            bAns.TabIndex = 5;
            bAns.Text = "Ans";
            bAns.UseVisualStyleBackColor = false;
            bAns.Click += bAns_Click;
            // 
            // bEquals
            // 
            bEquals.BackColor = Color.FromArgb(115, 115, 114);
            bEquals.BackgroundImageLayout = ImageLayout.None;
            bEquals.Cursor = Cursors.Hand;
            bEquals.FlatStyle = FlatStyle.Popup;
            bEquals.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bEquals.ForeColor = Color.White;
            bEquals.Location = new Point(252, 180);
            bEquals.Margin = new Padding(0);
            bEquals.Name = "bEquals";
            bEquals.Size = new Size(55, 43);
            bEquals.TabIndex = 5;
            bEquals.Text = "=";
            bEquals.UseVisualStyleBackColor = false;
            bEquals.Click += bEquals_Click;
            // 
            // bMinus
            // 
            bMinus.BackColor = Color.FromArgb(115, 115, 114);
            bMinus.BackgroundImageLayout = ImageLayout.None;
            bMinus.Cursor = Cursors.Hand;
            bMinus.FlatStyle = FlatStyle.Popup;
            bMinus.Font = new Font("Cascadia Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bMinus.ForeColor = Color.White;
            bMinus.Location = new Point(252, 120);
            bMinus.Margin = new Padding(0);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(55, 43);
            bMinus.TabIndex = 5;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = false;
            bMinus.Click += bMinus_Click;
            // 
            // bPlus
            // 
            bPlus.BackColor = Color.FromArgb(115, 115, 114);
            bPlus.BackgroundImageLayout = ImageLayout.None;
            bPlus.Cursor = Cursors.Hand;
            bPlus.FlatStyle = FlatStyle.Popup;
            bPlus.Font = new Font("Cascadia Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bPlus.ForeColor = Color.White;
            bPlus.Location = new Point(189, 120);
            bPlus.Margin = new Padding(0);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(55, 43);
            bPlus.TabIndex = 5;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = false;
            bPlus.Click += bPlus_Click;
            // 
            // bTimes
            // 
            bTimes.BackColor = Color.FromArgb(115, 115, 114);
            bTimes.BackgroundImageLayout = ImageLayout.None;
            bTimes.Cursor = Cursors.Hand;
            bTimes.FlatStyle = FlatStyle.Popup;
            bTimes.Font = new Font("Cascadia Mono", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bTimes.ForeColor = Color.White;
            bTimes.Location = new Point(189, 60);
            bTimes.Margin = new Padding(0);
            bTimes.Name = "bTimes";
            bTimes.Size = new Size(55, 43);
            bTimes.TabIndex = 5;
            bTimes.Text = "*";
            bTimes.UseVisualStyleBackColor = false;
            bTimes.Click += bTimes_Click;
            // 
            // bDivide
            // 
            bDivide.BackColor = Color.FromArgb(115, 115, 114);
            bDivide.BackgroundImageLayout = ImageLayout.None;
            bDivide.Cursor = Cursors.Hand;
            bDivide.FlatStyle = FlatStyle.Popup;
            bDivide.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bDivide.ForeColor = Color.White;
            bDivide.Location = new Point(252, 60);
            bDivide.Margin = new Padding(0);
            bDivide.Name = "bDivide";
            bDivide.Size = new Size(55, 43);
            bDivide.TabIndex = 5;
            bDivide.Text = "/";
            bDivide.UseVisualStyleBackColor = false;
            bDivide.Click += bDivide_Click;
            // 
            // bAC
            // 
            bAC.BackColor = Color.FromArgb(157, 181, 98);
            bAC.BackgroundImageLayout = ImageLayout.None;
            bAC.Cursor = Cursors.Hand;
            bAC.FlatStyle = FlatStyle.Popup;
            bAC.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bAC.ForeColor = Color.White;
            bAC.Location = new Point(252, 0);
            bAC.Margin = new Padding(0);
            bAC.Name = "bAC";
            bAC.Size = new Size(55, 43);
            bAC.TabIndex = 5;
            bAC.Text = "AC";
            bAC.UseVisualStyleBackColor = false;
            bAC.Click += bAC_Click;
            // 
            // bD
            // 
            bD.BackColor = Color.FromArgb(157, 181, 98);
            bD.BackgroundImageLayout = ImageLayout.None;
            bD.Cursor = Cursors.Hand;
            bD.FlatStyle = FlatStyle.Popup;
            bD.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bD.ForeColor = Color.White;
            bD.Location = new Point(189, 0);
            bD.Margin = new Padding(0);
            bD.Name = "bD";
            bD.Size = new Size(55, 43);
            bD.TabIndex = 5;
            bD.Text = "D";
            bD.UseVisualStyleBackColor = false;
            bD.Click += bD_Click;
            // 
            // offf
            // 
            offf.AutoSize = true;
            offf.ForeColor = Color.White;
            offf.Location = new Point(304, 129);
            offf.Name = "offf";
            offf.Size = new Size(28, 15);
            offf.TabIndex = 4;
            offf.Text = "OFF";
            // 
            // OFF
            // 
            OFF.Image = (Image)resources.GetObject("OFF.Image");
            OFF.Location = new Point(302, 152);
            OFF.Margin = new Padding(0);
            OFF.Name = "OFF";
            OFF.Size = new Size(30, 22);
            OFF.SizeMode = PictureBoxSizeMode.AutoSize;
            OFF.TabIndex = 3;
            OFF.TabStop = false;
            OFF.Click += OFF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(400, 453);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Calcolatrice";
            Risultato.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OFF).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Risultato;
        private Panel panel2;
        private PictureBox OFF;
        private Label offf;
        private Button b1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b2;
        private Button b3;
        private Button b6;
        private Button b9;
        private Button b8;
        private Button b5;
        private Button b4;
        private Button b7;
        private Button b0;
        private Button button10;
        private Button bAns;
        private Button bEquals;
        private Button bMinus;
        private Button bPlus;
        private Button bTimes;
        private Button bDivide;
        private Button bAC;
        private Button bD;
        private Label EXPRESSION;
        private Label RESULT;
    }
}
