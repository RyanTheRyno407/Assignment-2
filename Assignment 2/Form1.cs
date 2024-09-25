using System.Collections;

namespace Assignment_2
{
    public partial class Form1 : Form
    {

        public enum Colors
        {
            Green, Blue, Black, Red
        }
        String selectedColor = "default";
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Colors.Black.ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            lblSum.ForeColor = Color.Black;
            String selectedModel = "empty";

            if(lbMakeandModel.SelectedIndex != -1)
            {
                selectedModel = (String)lbMakeandModel.SelectedItem;
            }
            else
            {
                lblSum.ForeColor = Color.Red;
                lblSum.Text = "The Model you put is not valid please try again";
            }
            
            
            if ( int.TryParse(txtYear.Text, out _))
            {
                
                //lblSum.Text = $"You have purchased a  {txtYear.Text}  with the following features: ";
                
            }
            else
            {
                lblSum.ForeColor = Color.Red;
                lblSum.Text = "The year you put is not valid please try again";
            }

            String selectedFeatures = " ";
            if (chkAC.Checked) selectedFeatures += "AC, ";
            if (chkPowerWindows.Checked) selectedFeatures += "Power Windows, ";
            if (chkSyrius.Checked) selectedFeatures += "Syrius Radio, ";
            if (chkLane.Checked) selectedFeatures += "Lane Assist, ";

            lblSum.Text = $"You have Purchased a {selectedColor} {txtYear.Text} with the following features: {selectedFeatures}";





        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Colors.Green.ToString();
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor= Colors.Blue.ToString();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor=Colors.Red.ToString();
        }
    }
}
