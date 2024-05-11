﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving_school_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbSystemDSMS.mdf;Integrated Security=True");

        private void UpdateCounts()
        {
            try
            {
                connection.Open();

                // Get count of drivers
                SqlCommand driverCmd = new SqlCommand("SELECT COUNT(*) FROM Driver", connection);
                int driverCount = Convert.ToInt32(driverCmd.ExecuteScalar());

                // Get count of vehicles
                SqlCommand vehicleCmd = new SqlCommand("SELECT COUNT(*) FROM Vehicle", connection);
                int vehicleCount = Convert.ToInt32(vehicleCmd.ExecuteScalar());

                SqlCommand learnerCmd = new SqlCommand("SELECT COUNT(*) FROM Learner", connection);
                int learnerCount = Convert.ToInt32(learnerCmd.ExecuteScalar());

                // Display counts on labels
                driverCountLabel.Text = driverCount.ToString();
                vehicleCountLabel.Text = vehicleCount.ToString();
                studentsCountLabel.Text = learnerCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateCounts();
            LoadTomorrowsEventsToListView();
        }

        private void LoadTomorrowsEventsToListView()
        {
            // Get tomorrow's date
            DateTime tomorrow = DateTime.Today.AddDays(1);

            // Fetch events for tomorrow
            List<string> events = GetEventsForDate(tomorrow);

            // Display events in ListView
            listView1.Items.Clear();
            foreach (string ev in events)
            {
                listView1.Items.Add(ev);
            }
        }
        public List<string> GetEventsForDate(DateTime selectedDate)
        {
            List<string> events = new List<string>();



            SqlCommand checkCmd = new SqlCommand("SELECT Details FROM Schedule WHERE Date = @SelectedDate", connection);
            checkCmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

            connection.Open();
            SqlDataReader reader = checkCmd.ExecuteReader();

            while (reader.Read())
            {
                events.Add(reader["Details"].ToString());
            }

            connection.Close();
            return events;
        }

    }
}
