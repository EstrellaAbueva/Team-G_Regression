using Regression.Classes;

namespace Regression
{
    public partial class Form1 : Form
    {
        public RegressionMethod regressionMethod;
        public int age;
        public double weight;
        public double neck;
        public double abdomen;
        public double thigh;
        public double forearm;
        public double wrist;
        
        public Form1()
        {
            InitializeComponent();
            regressionMethod = new RegressionMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            fAge.ResetText();
            fWeight.ResetText();
            fNeck.ResetText();
            fAbdomen.ResetText();
            fThigh.ResetText();
            fForearm.ResetText();
            fWrist.ResetText();
            bfCount.ResetText();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            age = Convert.ToInt32(fAge.Text);
            weight = Convert.ToDouble(fWeight.Text);
            neck = Convert.ToDouble(fNeck.Text);
            abdomen = Convert.ToDouble(fAbdomen.Text);
            thigh = Convert.ToDouble(fThigh.Text);
            forearm = Convert.ToDouble(fForearm.Text);
            wrist = Convert.ToDouble(fWrist.Text);
            
            bfCount.Text = regressionMethod.CalculateRegression(age, weight, neck, abdomen, thigh, forearm, wrist).ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}