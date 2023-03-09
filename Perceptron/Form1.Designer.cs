namespace Perceptron
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
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            radioButton4 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox15 = new RichTextBox();
            richTextBox14 = new RichTextBox();
            richTextBox13 = new RichTextBox();
            richTextBox12 = new RichTextBox();
            richTextBox11 = new RichTextBox();
            richTextBox10 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumAquamarine;
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.Location = new Point(545, 57);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 25);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.ThousandsSeparator = true;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(544, 149);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 25);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.FromArgb(255, 192, 128);
            radioButton4.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(772, 188);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(69, 25);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "NAND";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(694, 268);
            button2.Name = "button2";
            button2.Size = new Size(138, 57);
            button2.TabIndex = 10;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(544, 268);
            button1.Name = "button1";
            button1.Size = new Size(138, 57);
            button1.TabIndex = 9;
            button1.Text = "Train";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(545, 188);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 8;
            label2.Text = "Epoch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(545, 95);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 7;
            label1.Text = "Learning Rate";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.FromArgb(255, 192, 128);
            radioButton3.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(773, 147);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 25);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "NOR";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(255, 192, 128);
            radioButton2.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(773, 104);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 25);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "AND";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(255, 192, 128);
            radioButton1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(772, 57);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 25);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "OR";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox1.Location = new Point(513, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 296);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(richTextBox15, 2, 4);
            tableLayoutPanel1.Controls.Add(richTextBox14, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox13, 0, 4);
            tableLayoutPanel1.Controls.Add(richTextBox12, 2, 3);
            tableLayoutPanel1.Controls.Add(richTextBox11, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox10, 0, 3);
            tableLayoutPanel1.Controls.Add(richTextBox9, 2, 2);
            tableLayoutPanel1.Controls.Add(richTextBox8, 1, 2);
            tableLayoutPanel1.Controls.Add(richTextBox7, 0, 2);
            tableLayoutPanel1.Controls.Add(richTextBox6, 2, 1);
            tableLayoutPanel1.Controls.Add(richTextBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox4, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(40, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(415, 296);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // richTextBox15
            // 
            richTextBox15.BackColor = Color.Linen;
            richTextBox15.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox15.Location = new Point(280, 238);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.ReadOnly = true;
            richTextBox15.Size = new Size(128, 47);
            richTextBox15.TabIndex = 29;
            richTextBox15.Text = "";
            // 
            // richTextBox14
            // 
            richTextBox14.BackColor = Color.Linen;
            richTextBox14.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox14.Location = new Point(143, 238);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.ReadOnly = true;
            richTextBox14.Size = new Size(128, 47);
            richTextBox14.TabIndex = 28;
            richTextBox14.Text = "1";
            // 
            // richTextBox13
            // 
            richTextBox13.BackColor = Color.Linen;
            richTextBox13.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox13.Location = new Point(6, 238);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.ReadOnly = true;
            richTextBox13.Size = new Size(128, 47);
            richTextBox13.TabIndex = 27;
            richTextBox13.Text = "1";
            // 
            // richTextBox12
            // 
            richTextBox12.BackColor = Color.Linen;
            richTextBox12.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox12.Location = new Point(280, 180);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.ReadOnly = true;
            richTextBox12.Size = new Size(128, 47);
            richTextBox12.TabIndex = 26;
            richTextBox12.Text = "";
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = Color.Linen;
            richTextBox11.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox11.Location = new Point(143, 180);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.ReadOnly = true;
            richTextBox11.Size = new Size(128, 47);
            richTextBox11.TabIndex = 25;
            richTextBox11.Text = "0";
            // 
            // richTextBox10
            // 
            richTextBox10.BackColor = Color.Linen;
            richTextBox10.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox10.Location = new Point(6, 180);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.ReadOnly = true;
            richTextBox10.Size = new Size(128, 47);
            richTextBox10.TabIndex = 24;
            richTextBox10.Text = "1";
            // 
            // richTextBox9
            // 
            richTextBox9.BackColor = Color.Linen;
            richTextBox9.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox9.Location = new Point(280, 122);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.ReadOnly = true;
            richTextBox9.Size = new Size(128, 47);
            richTextBox9.TabIndex = 23;
            richTextBox9.Text = "";
            // 
            // richTextBox8
            // 
            richTextBox8.BackColor = Color.Linen;
            richTextBox8.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox8.Location = new Point(143, 122);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.ReadOnly = true;
            richTextBox8.Size = new Size(128, 47);
            richTextBox8.TabIndex = 22;
            richTextBox8.Text = "1";
            // 
            // richTextBox7
            // 
            richTextBox7.BackColor = Color.Linen;
            richTextBox7.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox7.Location = new Point(6, 122);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.ReadOnly = true;
            richTextBox7.Size = new Size(128, 47);
            richTextBox7.TabIndex = 21;
            richTextBox7.Text = "0";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = Color.Linen;
            richTextBox6.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox6.Location = new Point(280, 64);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new Size(128, 47);
            richTextBox6.TabIndex = 20;
            richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.Linen;
            richTextBox5.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(143, 64);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(128, 47);
            richTextBox5.TabIndex = 19;
            richTextBox5.Text = "0";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.Linen;
            richTextBox4.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(6, 64);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(128, 47);
            richTextBox4.TabIndex = 18;
            richTextBox4.Text = "0";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Tan;
            richTextBox1.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(6, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(128, 47);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "X1";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Tan;
            richTextBox3.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(280, 6);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(129, 47);
            richTextBox3.TabIndex = 16;
            richTextBox3.Text = "a";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Tan;
            richTextBox2.Font = new Font("Franklin Gothic Demi Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(143, 6);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(128, 47);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "X2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 435);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Wacan - Perceptron";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox15;
        private RichTextBox richTextBox14;
        private RichTextBox richTextBox13;
        private RichTextBox richTextBox12;
        private RichTextBox richTextBox11;
        private RichTextBox richTextBox10;
        private RichTextBox richTextBox9;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}