using System.Globalization;

namespace MarsRoverPhotoApp
{
    public partial class MarsRoverPhotoForm : Form
    {
        public MarsRoverPhotoForm()
        {
            InitializeComponent();
        }

        private void photoBox_Click(object sender, EventArgs e)
        {

        }

        private void dateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void camBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void photoButton_Click(object sender, EventArgs e)
        {

            // CHECK FOR VALID DATE AND CHECK IF/WHICH CAMERA VIEW IS SELECTED //
            bool dateStatus = false;
            bool camStatus = false;

            string userDate = "";
            string userCam = "";

            DateTime minDate = new DateTime(2012, 08, 05);
            DateTime maxDate = DateTime.Parse(DateTime.Now.ToString());

            string[] userData = new string[2];

            try
            {
                DateTime chosenDate = DateTime.Parse(dateText.Text, CultureInfo.InvariantCulture);
                if (chosenDate > minDate && chosenDate < maxDate)
                {
                    dateStatus = true;
                    userDate = chosenDate.ToString("yyyy-MM-dd");
                }
                else if (chosenDate > maxDate)
                {
                    MessageBox.Show("Unfortunately not even NASA can time travel yet. The date entered is a future date.", "Date Error");
                }
                else if (chosenDate < minDate)
                {
                    MessageBox.Show("Please enter a date after 2012/08/05.", "Date Error");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid Earth date. Ex: '2015/07/15'", "Date Error");
            }



            if (camBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please choose a rover camera.", "Rover Cam Error");
            }
            else
            {
                camStatus = true;
                userCam = camBox.Text;
            }

            // IF REQUIRED SELECTIONS HAVE BEEN MADE, CONTINUE (dateStatus & camStatus)
            if (dateStatus && camStatus)
            {
                userData[0] = userDate;
                userData[1] = userCam;
                Program.UserInfoConversion(userData);
            }

            // DISPLAY FINAL RESULT
            if (Program.selectedPhoto != null)
            {
                photoBox.Load(Program.selectedPhoto);
                dateText.BackColor = Color.Black; dateText.ForeColor = Color.White;
                dateLabel.BackColor = Color.Black; dateLabel.ForeColor = Color.White;
                camBox.BackColor = Color.Black; camBox.ForeColor = Color.White;
                photoButton.BackColor = Color.Black; photoButton.ForeColor = Color.White;
            }
        }
    }
}