
using System.Media;
namespace Clicker
{
    public partial class SYMULAT : Form
    {
        int cash;
        int buttonlevel = 1;
        int A1Ammount;
        int A1Interval;

        public SYMULAT()
        {
            InitializeComponent();
            cash = 0;
            buttonlevel = 1;
            A1Ammount = 1;
            A1Interval = 1;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonlevel - 1);
            label1.Text = "SUBY:" + cash.ToString();
            SoundPlayer splayer = new SoundPlayer(Clicker.Properties.Resources.zarzynanie_swini);
            splayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Clicker.Properties.Resources.aaaaaaaaa);
            splayer.Play();

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
            SoundPlayer splayer = new SoundPlayer(Clicker.Properties.Resources.kurwa);
            splayer.Play();
            int upgradeCost = A1Interval * 100;
            if (cash >= upgradeCost)
            {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                cash -= upgradeCost;
                int nextUpgradeCost = A1Interval * 100;
                label1.Text = "SUBY:" + cash.ToString();
                string nextupgradeCost = "(SUBY" + nextUpgradeCost.ToString() + ")";
                A1upgradeinterval.Text = "Ulepsz czêstotliwoœæ\n" + nextupgradeCost;

            }

        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Ammount;
            label1.Text = "SUBY:" + cash.ToString();
        }

        private void A1upgradeAmmount_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Clicker.Properties.Resources.kurwa_kurwa_kurwa_kurwa);
            splayer.Play();
            int upgradeCost = A1Ammount * 100;
            if (cash >= upgradeCost)
            {

                A1Ammount ++;
                A1AmmountTextBox.Text = A1Ammount.ToString();
                cash -= upgradeCost;
                int nextUpgradeCost = A1Ammount * 100;
                label1.Text = "SUBY:" + cash.ToString();
                string nextupgradeCost = "(SUBY" + nextUpgradeCost.ToString() + ")";
                A1upgradeAmmount.Text = "Ulepsz iloœæ\n" + nextupgradeCost;

            }
        }



        private void SYMULAT_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}