namespace Yugioh_Life_Points_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int player1lp = 8000;
        int player2lp = 8000;

        string player1_change;
        string player2_change;

        int result;

        private void button2_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(player1_change);

            player1lp = player1lp + temp1;

            if (player1lp <= 0) { MessageBox.Show("Player 2 wins!"); }

            label1.Text = Convert.ToString(player1lp);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            player1_change = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            player2_change = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(player1_change);

            player1lp = player1lp - temp1;

            if (player1lp <= 0) { MessageBox.Show("Player 2 wins!"); }

            label1.Text = Convert.ToString(player1lp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(player2_change);

            player2lp = player2lp - temp1;

            if (player2lp <= 0) { MessageBox.Show("Player 1 wins!"); }

            label2.Text = Convert.ToString(player2lp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(player2_change);

            player2lp = player2lp + temp1;

            if (player2lp <= 0) { MessageBox.Show("Player 1 wins!"); }

            label2.Text = Convert.ToString(player2lp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player1lp = 8000;
            player2lp = 8000;

            label1.Text = Convert.ToString(player1lp);
            label2.Text = Convert.ToString(player2lp);
        }
    }
}