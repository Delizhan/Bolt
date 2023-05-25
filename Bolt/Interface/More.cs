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
using System.Windows.Forms.VisualStyles;
using static Bolt.ClassesAndInterfaces.RegisteredUser;

namespace Bolt.Interface
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
            Storage.Instance.more = this;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd.MM.yyyy";
            if(Registration.registeredUser.Discount == 0)
                button_useDiscount.Enabled = false;
            if (Registration.registeredUser.Scooters.Count == 0)
            {
                button_sort.Enabled = false;
                button_useDiscount.Enabled = false;
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            label_maxSpeed.Text += " " + Scooter.MaxSpeed + " км/год";
            label_maxHumanWeight.Text += " " + Scooter.MaxHumanWeight + " кг";
            label_enginePower.Text += " " + Scooter.EnginePower + " Вт";
            label_steeringRackHeight.Text += " " + Scooter.SteeringRackHeight + " м";
            label_weight.Text += " " + Scooter.Weight + " кг";
            button_info.Enabled = false;
        }

        private void button_speed_Click(object sender, EventArgs e)
        {
            label_speed.Text = Registration.registeredUser?.DefineSpeed(Registration.registeredUser.Age).ToString() + " км/год";
            button_speed.Enabled = false;
        }
        public void SaveToFileJsonScooters(List<Scooter> scooters)
        {
            string lines = "";
            foreach (var scooter in scooters)
            {
                lines += JsonSerializer.Serialize<Scooter>(scooter);
                lines += "\n";
            }
            if (lines != "")
                File.WriteAllText("scooters.json", lines);
        }
        private void button_useDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_startTrip.Text))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_startTrip.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_startTrip.Text, Registration.DefineNumber)
                || (byte.Parse(textBox_startTrip.Text) < 8 
                || byte.Parse(textBox_startTrip.Text) > 20))
            {
                var error = new Error_WrongTime();
                error.ShowDialog();
                textBox_startTrip.Focus();
                return;
            }
            if (dtPicker.Value < DateTime.Today)
            {
                var error = new Error_PastDate();
                error.ShowDialog();
                return;
            }

            Registration.registeredUser.OnMessage += PrintMessage;
            int _idScooter = Registration.registeredUser.UseDiscount(dtPicker.Text, byte.Parse(textBox_startTrip.Text));
            if (_idScooter != -1)
            {
                foreach(Scooter scooter in Registration.allScooters)
                {
                    if(scooter.Id == _idScooter && scooter.IdUser == Registration.registeredUser.Id)
                    {
                        scooter.Discount = Registration.registeredUser.Discount;
                        Registration.registeredUser.Discount = 0;
                        break;
                    }
                }
                SaveToFileJsonScooters(Registration.allScooters);

                NewPassword.SaveToFileJsonUsers(Registration.registeredUsers);

                textBox_startTrip.Text = "";
                button_useDiscount.Enabled = false;
            }
        }

        private void button_getDiscount_Click(object sender, EventArgs e)
        {
            if (Registration.registeredUser != null)
            {
                Registration.registeredUser.OnDate += DetermineForEquality;
                Registration.registeredUser.OnMessage += PrintMessage;
                Registration.registeredUser.GetDiscount();
            }
        }
        public void DetermineForEquality(int day, int month)
        {
            if (day == month && Registration.registeredUser != null)
                Registration.registeredUser.Discount += 15;
            Registration.registeredUser.OnDate -= DetermineForEquality;
        }
        public void PrintMessage(string message)
        {
            SMS_OK sms = new SMS_OK();
            sms.label_text.Text = message;
            sms.ShowDialog();
            Registration.registeredUser.OnMessage -= PrintMessage;
        }
        public void PrintMessageForScooter(string message)
        {
            SMS_OK sms = new SMS_OK();
            sms.label_text.Text = message;
            sms.ShowDialog();
        }
        private void button_calc_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(textBox_kolHour.Text))
            {
                var error = new Error_KolHours();
                error.ShowDialog();
                textBox_kolHour.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_kolHour.Text, Registration.DefineNumber)
                || (byte.Parse(textBox_kolHour.Text) <= 0))
            {
                var error = new Error_KolHours();
                error.ShowDialog();
                textBox_kolHour.Focus();
                return;
            }

            Scooter temporaryScooter = new Scooter(byte.Parse(textBox_kolScooters.Text));
            temporaryScooter.OnMessage += PrintMessageForScooter;
            Scooter.CalculatePrice(temporaryScooter.CountScooters, byte.Parse(textBox_kolHour.Text), temporaryScooter.Mult);
            temporaryScooter.OnMessage -= PrintMessageForScooter;
            textBox_kolHour.Text = "";
            textBox_kolScooters.Text = "";
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            Registration.registeredUser.Scooters.Sort();
            dataGridView_scooterRecords.DataSource = Registration.registeredUser.Scooters;
            button_sort.Enabled = false;
        }

        private void button_additionally_Click(object sender, EventArgs e)
        {
            Additionally additionally = new Additionally();
            this.Hide();
            additionally.Show();
        }

        private void More_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.more = null;
        }
    }
}
