using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prog_Assign_07_Fish_Example
{
    public partial class FormFish : Form
    {
        private List<Fish> fishList = new List<Fish>();
        public FormFish()
        {
            InitializeComponent();
        }

        private void FormFish_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // Set the water label to the empty string
            labelWaterType.Text = "";
            // Populate the Fish list box
            populateFishListBox();
        }

        private void populateFishListBox()
        {
            listBoxFish.Items.Clear();

            Fish fish = new Fish();
            fishList = fish.getAll();

            foreach (Fish afish in fishList)
            {
                listBoxFish.Items.Add(afish.getName());
            }

            listBoxFish.Items.Insert(0, "");
            listBoxFish.SelectedIndex = 0;
        }

        private void listBoxFish_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fish fish = new Fish();
            labelWaterType.Text = fish.waterByFishName(listBoxFish.SelectedItem.ToString());
        }

        private void buttonAddFish_Click(object sender, EventArgs e)
        {
            // Create an instance of the state add form
            FormFishAdd formFishAdd = new FormFishAdd();
            // Position the new form at center of parent
            formFishAdd.StartPosition = FormStartPosition.CenterParent;
            // Show the instance as a modal dialog
            formFishAdd.ShowDialog();
            // Reload the listbox
            populateFishListBox();
        }
        private Fish getSelectedFish()
        {
            string fishName = listBoxFish.SelectedItem.ToString();
            foreach (Fish fish in fishList)
            {
                if (fish.getName() == fishName)
                    return fish;
            }
            return new Fish();
        }
        private void buttonModifyFish_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the fish modify form
                // and pass it the selected fish id
                FormFishModify formFishModify = new FormFishModify(getSelectedFish());
                // Position the new form at center of parent
                formFishModify.StartPosition = FormStartPosition.CenterParent;
                // Show the instance as a modal dialog
                formFishModify.ShowDialog();
                // Reload the listbox
                populateFishListBox();
            } catch (ObjectDisposedException)
            {
                // Ignore this type of exception
            }
        }
    }
}
