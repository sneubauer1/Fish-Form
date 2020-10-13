using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Assign_07_Fish_Example
{
    public partial class FormFishAdd : Form
    {
        public FormFishAdd()
        {
            InitializeComponent();
        }

        private void FormFishAdd_Load(object sender, EventArgs e)
        {
            // Center to the parent window
            this.CenterToParent();

            // Set the msg to the empty string
            labelMsg.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Get an instance of the fish class
            Fish fish = new Fish();
            string waterType = "";
            if (radioButtonFresh.Checked)
            {
                waterType = radioButtonFresh.Text;
            } else if (radioButtonSalt.Checked)
            {
                waterType = radioButtonSalt.Text;
            }
            // Add the new fish
            string errorMsg = fish.add(textBoxName.Text, waterType);
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
