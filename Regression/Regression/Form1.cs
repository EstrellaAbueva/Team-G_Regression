namespace Regression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}