using Bolt.ClassesAndInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolt.Interface
{
    public partial class Additionally : Form
    {
        public Additionally()
        {
            InitializeComponent();
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd.MM.yyyy";
            if (Registration.registeredUser.Scooters.Count == 0)
            {
                button_coupon.Enabled = false;
                button_date.Enabled = false;
                button_point.Enabled = false;
            }
        }

        private void button_coupon_Click(object sender, EventArgs e)
        {
            var sortedScooters = Registration.registeredUser.Scooters.OrderBy(s => s.Coupon).ToList();
            dataGridView_coupon.DataSource = sortedScooters;
            button_coupon.Enabled = false;
        }

        private void button_date_Click(object sender, EventArgs e)
        {
            if (dtPicker.Value < DateTime.Today)
            {
                var error = new Error_PastDate();
                error.ShowDialog();
                return;
            }

            var sortedScooters = Registration.registeredUser.Scooters.Where(s => s.Date == dtPicker.Text).ToList();
            
            if(sortedScooters.Count == 0)
            {
                SMS_OK sms = new SMS_OK();
                sms.label_text.Text = "Немає записів із вказаною датою.";
                sms.ShowDialog();
                dataGridView_date.DataSource = null;
                return;
            }

            dataGridView_date.DataSource = sortedScooters;
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            dataGridView_point.DataSource = ReadPointsRecordsForUser();
            button_point.Enabled = false;
        }
        public List<IssuePoint> ReadPointsRecordsForUser()
        {
            List<IssuePoint>? points = new List<IssuePoint>();
            IssuePoint? issuePoint = null;
            foreach (Scooter scooter in Registration.registeredUser.Scooters)
            {
                issuePoint = (IssuePoint)scooter.issuePoint.Clone();
                points.Add(issuePoint);
            }
            return points;
        }

    }
}
