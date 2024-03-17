using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackResults.Controller;

namespace TrackResults.View
{
    public partial class MainForm : Form
    {
        private TrackMeetController controller;

        public MainForm()
        {
            InitializeComponent();
            controller = new TrackMeetController();
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            eventComboBox.Items.Clear();
            foreach (string eventName in controller.GetEventNames())
            {
                eventComboBox.Items.Add(eventName);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(eventNameTextBox.Text) || string.IsNullOrEmpty(timeTextBox.Text))
            {
                MessageBox.Show("Please enter event name and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string eventName = eventNameTextBox.Text;
            string time = timeTextBox.Text;

            if (controller.AddOrUpdateEvent(eventName, time))
            {
                MessageBox.Show("Event added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventNameTextBox.Clear();
                timeTextBox.Clear();
                UpdateComboBox();
            }
            else
            {
                MessageBox.Show("Changes were not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent = eventComboBox.SelectedItem.ToString();
            Dictionary<string, string> eventData = controller.GetEventDetails(selectedEvent);
            if (eventData != null)
            {
                eventNameTextBox.Text = eventData["name"];
                timeTextBox.Text = eventData["time"];
            }
        }
    }
}
