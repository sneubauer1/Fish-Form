using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prog_Assign_07_Fish_Example
{
    public partial class FormFishModify : Form
    {
        private Fish fishToModify;
        public FormFishModify(Fish fish)
        {
            InitializeComponent();
            if (fish.getId() < 1)
            {
                MessageBox.Show("Select a fish first.");
                this.Close();
            }
            else
            {
                fishToModify = fish;
            }
        }

        private void FormFishModify_Load(object sender, EventArgs e)
        {
            // Center to the parent window
            this.CenterToParent();

            // Set the msg to the empty string
            labelMsg.Text = "";

            // Initialize the fish info
            textBoxName.Text = fishToModify.getName();
            if (fishToModify.getWater().ToUpper().Contains("FRESH"))
            {
                radioButtonFresh.Checked = true;
            }
            else
            {
                radioButtonSalt.Checked = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Get an instance of the fish class
            Fish fish = new Fish();
            string waterType = "";
            if (radioButtonFresh.Checked)
            {
                waterType = radioButtonFresh.Text;
            }
            else if (radioButtonSalt.Checked)
            {
                waterType = radioButtonSalt.Text;
            }
            // Modify the fish
            string errorMsg = fish.modify(fishToModify.getId(), textBoxName.Text, waterType);
            // Check the return for any error messages
            if (errorMsg.Length != 0)
            {
                // Error discovered
                // Set the text for the label to red
                labelMsg.ForeColor = Color.Red;
                /* Set the text for the label to the
                   returned error message */
                labelMsg.Text = errorMsg;
            }
            else
            {
                // No errors
                // Set the text for the label to green
                labelMsg.ForeColor = Color.Green;
                // Set the text for the label to the read
                // "nnn saved." Where nnn is the name of the fish
                labelMsg.Text = textBoxName.Text.Trim() + " saved.";
                // set the textbox text to the empty string
                textBoxName.Text = "";
                // deselect both radio buttons
                radioButtonFresh.Checked = false;
                radioButtonSalt.Checked = false;
            }
            // Set the focus back to the textbox
            textBoxName.Focus();
        }
    }
}
