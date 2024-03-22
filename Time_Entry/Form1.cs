using System.Diagnostics.Eventing.Reader;

namespace Time_Entry
{
    public partial class Form1 : Form
    {
        double[] hours = new double[7];
        double displayTime = 0;
        String Weekday;
        String Day;

        public Form1()
        {
            InitializeComponent();
            Reset.Enabled = true;
            Lookup.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            Array.Clear(hours, 0, hours.Length);
            displayTime = 0;
            SunText.Text = "";
            MonText.Text = "";
            TuesText.Text = "";
            WedText.Text = "";
            ThursText.Text = "";
            FriText.Text = "";
            SatText.Text = "";
            display.Text = "Display hours for day selected";
            Entry.Text = "";
            Reset.Enabled = false;
            Lookup.Enabled = false;
            Submit.Enabled = true;
            SunText.Focus();
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SunText.Text))
            {
                hours[0] = 0;
            }
            else
            {
                hours[0] = double.Parse(SunText.Text);
            }

            if (String.IsNullOrEmpty(MonText.Text))
            {
                hours[1] = 0;
            }
            else
            {
                hours[1] = double.Parse(MonText.Text);
            }

            if (String.IsNullOrEmpty(TuesText.Text))
            {
                hours[2] = 0;
            }
            else
            {
                hours[2] = double.Parse(TuesText.Text);
            }

            if (String.IsNullOrEmpty(WedText.Text))
            {
                hours[3] = 0;
            }
            else
            {
                hours[3] = double.Parse(WedText.Text);
            }

            if (String.IsNullOrEmpty(ThursText.Text))
            {
                hours[4] = 0;
            }
            else
            {
                hours[4] = double.Parse(ThursText.Text);
            }

            if (String.IsNullOrEmpty(FriText.Text))
            {
                hours[5] = 0;
            }
            else
            {
                hours[5] = double.Parse(FriText.Text);
            }

            if (String.IsNullOrEmpty(SatText.Text))
            {
                hours[6] = 0;
            }
            else
            {
                hours[6] = double.Parse(SatText.Text);
            }

            SunText.Text = "";
            MonText.Text = "";
            TuesText.Text = "";
            WedText.Text = "";
            ThursText.Text = "";
            FriText.Text = "";
            SatText.Text = "";


        }

        private void Lookup_Click_1(object sender, EventArgs e)
        {
            Weekday = Entry.Text;
            displayTime = 0;

            switch (Weekday)
            {
                case "Sunday":
                    displayTime = hours[0];
                    break;
                case "Monday":
                    displayTime = hours[1];
                    break;
                case "Tuesday":
                    displayTime = hours[2];
                    break;
                case "Wednesday":
                    displayTime = hours[3];
                    break;
                case "Thursday":
                    displayTime = hours[4];
                    break;
                case "Friday":
                    displayTime = hours[5];
                    break;
                case "Saturday":
                    displayTime = hours[6];
                    break;

            }

            Reset.Enabled = true;
            Lookup.Enabled = true;
            Submit.Enabled = false;

            display.Text = "Hours Worked: " + displayTime;
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            Init();
        }

       
    }
}