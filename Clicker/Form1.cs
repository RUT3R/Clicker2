namespace Clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonlevel = 1;
        int A1Ammount;
        int A1Interval;

        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlevel = 1;
            A1Ammount = 10;
            A1Interval = 0;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonlevel - 1);
            label1.Text = "SUBY:" + cash.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonlevel);
            if (cash >= upgradeCost)
            {
                buttonlevel++;
                textBox1.Text = buttonlevel.ToString();
                cash -= upgradeCost;
                label1.Text = "SUBY:" + cash.ToString();
                string nextupgradeCost = "(SUBY" + Math.Pow(10, buttonlevel).ToString() + ")";
                button2.Text = "UPGRADE\n" + nextupgradeCost;
            }
        }

        private void A1upgradeinterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if (cash >= upgradeCost)
            {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                cash -= upgradeCost;
                label1.Text = "SUBY:" + cash.ToString();

            }

        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Ammount;
            label1.Text = "SUBY:" + cash.ToString();
        }

        private void A1upgradeAmmount_Click(object sender, EventArgs e)
        {


                A1Ammount += 10;
                A1AmmountTextBox.Text = A1Ammount.ToString();


        }
    }
}