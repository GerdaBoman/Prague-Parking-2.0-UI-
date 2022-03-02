using DataAccess.Data;
using FontAwesome.Sharp;
using UI.Forms;

namespace PragueeParking
{
    public partial class Form : System.Windows.Forms.Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private System.Windows.Forms.Form currentChildForm;

        
        public Form()
        {
            InitializeComponent();
            MightyKnightsContext db = new();
            db.Database.EnsureCreated();

            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            menuPanel.Controls.Add(leftBorderButton);
            OpenChildForm(new FormHome());
        }

        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            currentChildForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentChildFormLabel.Text = childForm.Text;
        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormHome());
        }

        private void parkingLotButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormParkingLot());
        }

        private void vechileManagementButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormVehicleManagment());
        }

        private void vechileCheckInButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormCheckIn());
        }

        private void vechileCheckOutButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormCheckOut());
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormSettings());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            Application.Exit();
        }

        private void HighlightButton(object selectedButton, Color colour)
        {
            if (selectedButton != null)
            {
                DisableHighlightButton();

                currentButton = (IconButton)selectedButton;
                currentButton.BackColor = Color.FromArgb(56, 111, 164);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderButton.BackColor = colour;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                currentChildButton.IconChar = currentButton.IconChar;
                currentChildButton.IconColor = Color.Gainsboro;

            }
        }
        private void DisableHighlightButton()
        {
            if (currentButton != null)
            {

                currentButton.BackColor = Color.FromArgb(19, 60, 85);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            DisableHighlightButton();
            OpenChildForm(new FormHome());
            
        }
    }
}