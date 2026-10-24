namespace WinFormsApplab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool PassScore(int score)
        {
            return score >= 50;
        }

        private string GetLetterGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (89 > score && score >= 80)
            {
                return "B";
            }
            else if (79 > score && score >= 70)
            {
                return "C";
            }
            else if (69 > score && score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            bool passed = PassScore(score);
            string grade = GetLetterGrade(score);

            lblResult.Text = "Passed: " + passed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            string grade = GetLetterGrade(score);

            lblResult.Text = "Letter Grade: " + grade;
        }

        private int PointsTo100(int score)
        {
            return 100 - score;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            int pointsNeeded = PointsTo100(score);

            lblResult.Text = "Points needed to reach 100: " + pointsNeeded;
        }

        
    }
}
