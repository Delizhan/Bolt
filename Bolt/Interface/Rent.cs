using Bolt.ClassesAndInterfaces;
using Bolt.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Bolt
{
    public partial class Rent : Form
    {
        public List<short>? coupons = null;
        public Rent()
        {
            InitializeComponent();
            Storage.Instance.rent = this;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd.MM.yyyy";
            Registration.registeredUser.Scooters = ReadScooterRecordsForUser();
            dataGridView_scooterRecords.DataSource = Registration.registeredUser.Scooters;
        }
        public List<Scooter> ReadScooterRecordsForUser()
        {
            List<Scooter>? scooters = new List<Scooter>();
            Scooter.TotalCountScooters = 15;
            List<string> linesScooters = new List<string>();
            linesScooters = File.ReadLines("scooters.json").ToList();
            List<string> linesPoints = new List<string>();
            linesPoints = File.ReadLines("issuePoints.json").ToList();
            coupons = new List<short>();
            foreach (string lineScooter in linesScooters)
            {
                Scooter? scooter;
                scooter = JsonSerializer.Deserialize<Scooter>(lineScooter);
                foreach (string linePoint in linesPoints)
                {
                    IssuePoint? issuePoint = JsonSerializer.Deserialize<IssuePoint>(linePoint);
                    if (issuePoint.IdScooter == scooter.Id)
                    {
                        scooter.issuePoint = issuePoint;
                        break;
                    }
                }
                if (scooter.IdUser == Registration.registeredUser.Id)
                    scooters.Add(scooter);
                Scooter.TotalCountScooters -= scooter.CountScooters;
                coupons.Add(scooter.Coupon);
            }
            if (linesScooters.Count == 0)
            {
                Scooter.TotalCountScooters = 15;
            }
            return scooters;
        }
        public static bool DoOperation(string str, Func<string, bool> operation) => operation(str);
        public static bool CheckLetter(string str)
        {
            if(string.IsNullOrWhiteSpace(str))
                return false;
            if (str[0] == '-')
                return false;
            foreach (char c in str)
            {
                if ((int)c == ' ' || (int)c == '-') continue;
                if ((int)c < 1040 || (int)c > 1103)
                    return false;
            }
            return true;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            if(!DoOperation(textBox_search.Text, CheckLetter))
            {
                var error = new Error_City();
                error.ShowDialog();
                textBox_search.Focus();
                return;
            }
            pictureBox_mape.Visible = true;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            pictureBox_mape.Visible = false;
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_kolScooters.Text))
            {
                var error = new Error_KolScooters();
                error.ShowDialog();
                textBox_kolScooters.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_kolScooters.Text, Registration.DefineNumber) 
                || (byte.Parse(textBox_kolScooters.Text) <= 0))
            {
                var error = new Error_KolScooters();
                error.ShowDialog();
                textBox_kolScooters.Focus();
                return;
            }
            if (byte.Parse(textBox_kolScooters.Text) > Scooter.TotalCountScooters)
            {
                var sms = new Message_NumScooters();
                int num = Scooter.TotalCountScooters;
                sms.textBox_numScooters.Text = num.ToString();
                sms.ShowDialog();
                textBox_kolScooters.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_start.Text))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_start.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_start.Text, Registration.DefineNumber)
                || !(byte.Parse(textBox_start.Text) >= 8 && byte.Parse(textBox_start.Text) <= 20))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_start.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_end.Text))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_end.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_end.Text, Registration.DefineNumber) 
                || !(byte.Parse(textBox_end.Text) >= 9 && byte.Parse(textBox_end.Text) <= 21)
                || (byte.Parse(textBox_end.Text) < (byte.Parse(textBox_start.Text))))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_end.Focus();
                return;
            }
            if (byte.Parse(textBox_start.Text) == byte.Parse(textBox_end.Text))
            {
                var error = new Error_Time();
                error.ShowDialog();
                textBox_end.Focus();
                return;
            }
            if (dtPicker.Value < DateTime.Today)
            {
                var error = new Error_PastDate();
                error.ShowDialog();
                return;
            }
            if(dtPicker.Value == DateTime.Today)
            {
                if(byte.Parse(textBox_start.Text) < DateTime.Now.Hour
                    || byte.Parse(textBox_end.Text) < DateTime.Now.Hour)
                {
                    var error = new Error_KolHours();
                    error.ShowDialog();
                    return;
                }
            }
            short coupon;
            Random rnd = new Random();
            bool result = true;
            do
            {
                coupon = (short)rnd.Next(1000, 10000);
                if (File.ReadLines("scooters.json").ToList() != null)
                {
                    result = coupons.Exists(c => c == coupon);
                }
            } while (result);

            if (Registration.issuePoint != null)
            {
                Registration.scooter = new Scooter(byte.Parse(textBox_kolScooters.Text), byte.Parse(textBox_start.Text), byte.Parse(textBox_end.Text), dtPicker.Text, coupon, 0, Registration.issuePoint);
                Registration.scooter.DefineId();
                Registration.scooter.IdUser = Registration.registeredUser.Id;
                Registration.scooter.issuePoint.IdScooter = Registration.scooter.Id;
                Registration.registeredUser.Scooters.Add(Registration.scooter);
                Registration.allScooters.Add(Registration.scooter);
                Scooter.TotalCountScooters -= Registration.scooter.CountScooters;

                string lines = "";
                lines += JsonSerializer.Serialize<Scooter>(Registration.scooter);
                lines += "\n";
                if (lines != "")
                    File.AppendAllText("scooters.json", lines);

                lines = "";
                lines += JsonSerializer.Serialize<IssuePoint>(Registration.issuePoint);
                lines += "\n";
                if (lines != "")
                    File.AppendAllText("issuePoints.json", lines);

                dataGridView_scooterRecords.DataSource = null;
                dataGridView_scooterRecords.DataSource = Registration.registeredUser.Scooters;

                Registration.issuePoint = null;
                Registration.scooter = null;
                textBox_kolScooters.Text = "";
                textBox_start.Text = "";
                textBox_end.Text = "";
                var sms = new SMS_SucRent();
                sms.Show();
            }
            else
            {
                var error = new Error_IssuePoint();
                error.ShowDialog();
                button_issuePoint.Focus();
            }
        }
        private void button_issuePoint_Click(object sender, EventArgs e)
        {
            ChooseIssuePoint chooseIssuePoint = new ChooseIssuePoint();
            chooseIssuePoint.Show();
        }

        private void button_more_Click(object sender, EventArgs e)
        {
            More more = new More();
            more.Show();
            this.Hide();
        }

        private void Rent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.rent = null;
        }
    }
}
