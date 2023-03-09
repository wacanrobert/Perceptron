namespace Perceptron
{
    public partial class Form1 : Form
    {
        double learningRate;
        int epochLimit;
        double[] weights = new double[2];
        int r1, r2, r3, r4;
        Perceptron p1, p2, p3, p4;
        int[] row1 = { 0, 0 };
        int[] row2 = { 0, 1 };
        int[] row3 = { 1, 0 };
        int[] row4 = { 1, 1 };

        public Form1()
        {
            InitializeComponent();

            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = 0.01m;

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox3.SelectAll();
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;

            Random rnd = new Random(new Random().Next());
            weights[0] = (rnd.Next(2) == 0) ? -1 : 1;
            weights[1] = (rnd.Next(2) == 0) ? -1 : 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                this.epochLimit = (int)numericUpDown1.Value;
            }
            if (numericUpDown2.Value > 0)
            {
                this.learningRate = (double)numericUpDown2.Value;
            }



            int[] targetOR = { 0, 1, 1, 1 };
            int[] targetAND = { 0, 0, 0, 1 };
            int[] targetNOR = { 1, 0, 0, 0 };
            int[] targetNAND = { 1, 1, 1, 0 };



            p1 = new Perceptron(weights, this.learningRate, epochLimit);
            p2 = new Perceptron(weights, this.learningRate, epochLimit);
            p3 = new Perceptron(weights, this.learningRate, epochLimit);
            p4 = new Perceptron(weights, this.learningRate, epochLimit);

            if (radioButton1.Checked)
            {
                p1.Train(row1, targetOR[0]);
                p2.Train(row2, targetOR[1]);
                p3.Train(row3, targetOR[2]);
                p4.Train(row4, targetOR[3]);
            }
            else if (radioButton2.Checked)
            {
                p1.Train(row1, targetAND[0]);
                p2.Train(row2, targetAND[1]);
                p3.Train(row3, targetAND[2]);
                p4.Train(row4, targetAND[3]);

            }
            else if (radioButton3.Checked)
            {
                p1.Train(row1, targetNOR[0]);
                p2.Train(row2, targetNOR[1]);
                p3.Train(row3, targetNOR[2]);
                p4.Train(row4, targetNOR[3]);
            }
            else if (radioButton4.Checked)
            {
                p1.Train(row1, targetNAND[0]);
                p2.Train(row2, targetNAND[1]);
                p3.Train(row3, targetNAND[2]);
                p4.Train(row4, targetNAND[3]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = p1.CalculateOutput(row1).ToString();
            richTextBox9.Text = p2.CalculateOutput(row2).ToString();
            richTextBox12.Text = p3.CalculateOutput(row3).ToString();
            richTextBox15.Text = p4.CalculateOutput(row4).ToString();
        }
    }
}