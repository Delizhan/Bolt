using Bolt.ClassesAndInterfaces;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminWindow : Form
    {
        IssuePoint _issuePoint;
        public AdminWindow()
        {
            InitializeComponent();
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd.MM.yyyy";
            dataGridView_users.DataSource = Registration.registeredUsers;
            dataGridView_scooters.DataSource = Registration.allScooters;
            dataGridView_points.DataSource = Registration.allPoints;

            if(Registration.registeredUsers.Count == 0)
            {
                button_delUser.Enabled = false;
                button_updateUser.Enabled = false;
                button_updateScooterAndPoint.Enabled = false;
                button_delScooterAndPoint.Enabled = false;
                button_addScooterAndPoint.Enabled = false;
            }
            if(Registration.allScooters.Count == 0)
            {
                button_updateScooterAndPoint.Enabled = false;
                button_delScooterAndPoint.Enabled = false;
            }
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            bool availability = false;
            if (!string.IsNullOrWhiteSpace(textBox_name.Text) && !string.IsNullOrWhiteSpace(textBox_surname.Text) && Registration.registeredUsers.Count != 0)
            {
                foreach (RegisteredUser user in Registration.registeredUsers)
                {
                    if (user.FirstName == textBox_name.Text && user.LastName == textBox_surname.Text)
                    {
                        availability = true;
                        break;
                    }
                }
            }

            if (!availability)
            {
                if (string.IsNullOrWhiteSpace(textBox_name.Text)
                    || textBox_name.Text.Length > 20)
                {
                    var error = new Error_Name();
                    error.ShowDialog();
                    textBox_name.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_surname.Text)
                    || textBox_surname.Text.Length > 20)
                {
                    var error = new Error_Name();
                    error.ShowDialog();
                    textBox_surname.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_phone.Text)
                    || !Registration.DoOperation(textBox_phone.Text, Registration.DefineNumber)
                    || int.Parse(textBox_phone.Text) < 100000000
                    || int.Parse(textBox_phone.Text) > 999999999)
                {
                    var error = new Error_Phone();
                    error.ShowDialog();
                    textBox_phone.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_password.Text)
                    || textBox_password.Text.Length > 12
                    || textBox_password.Text.Length < 8)
                {
                    var error = new Error_Password();
                    error.ShowDialog();
                    textBox_password.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_age.Text)
                    || !Registration.DoOperation(textBox_age.Text, Registration.DefineNumber)
                    || !RegisteredUser.CheckAge(byte.Parse(textBox_age.Text)))
                {
                    var error = new Error_Age();
                    error.ShowDialog();
                    textBox_age.Focus();
                    return;
                }
                Registration.guest = new Guest();
                Registration.registeredUser = new RegisteredUser(textBox_name.Text, textBox_surname.Text, int.Parse(textBox_phone.Text), textBox_password.Text);
                Registration.registeredUser.Discount = Registration.guest.gift.Discount;
                Registration.registeredUser.Age = byte.Parse(textBox_age.Text);
                if (Registration.registeredUsers.Count == 0)
                    Registration.registeredUser.Id = 0;
                else
                    Registration.registeredUser.Id = Registration.registeredUsers[Registration.registeredUsers.Count - 1].Id + 1;

                textBox_name.Text = "";
                textBox_surname.Text = "";
                textBox_phone.Text = "";
                textBox_password.Text = "";
                textBox_userDiscount.Text = "";
                textBox_age.Text = "";
                textBox_idUser_forUpdate.Text = "";
            }
            else
            {
                var error = new Error_WrongName();
                error.ShowDialog();
                textBox_name.Focus();
                return;
            }

            Registration.registeredUsers.Add(Registration.registeredUser);

            button_delUser.Enabled = true;
            button_updateUser.Enabled = true;
            button_addScooterAndPoint.Enabled = true;

            dataGridView_users.DataSource = null;
            dataGridView_users.DataSource = Registration.registeredUsers;
        }

        private void button_delUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_idUser.Text))
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser.Focus();
                return;
            }
            if(!Registration.DoOperation(textBox_idUser.Text, Registration.DefineNumber)
                || int.Parse(textBox_idUser.Text) < 0)
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser.Focus();
                return;
            }

            bool availability = false;
            if (Registration.registeredUsers.Count != 0)
            {
                foreach (RegisteredUser user in Registration.registeredUsers)
                {
                    if (user.Id == int.Parse(textBox_idUser.Text))
                    {
                        availability = true;
                        break;
                    }
                }
            }

            if(!availability)
            {
                var error = new Error_NotFoundId();
                error.ShowDialog();
                textBox_idUser.Focus();
                return;
            }
            else
            {
                List<RegisteredUser> temporaryUsers = new List<RegisteredUser>();
                foreach(RegisteredUser user in Registration.registeredUsers)
                    if (user.Id != int.Parse(textBox_idUser.Text))
                        temporaryUsers.Add(user);
                Registration.registeredUsers = temporaryUsers;

                dataGridView_users.DataSource = null;
                dataGridView_users.DataSource = Registration.registeredUsers;

                if (Registration.registeredUsers.Count == 0)
                {
                    button_delUser.Enabled = false;
                    button_updateUser.Enabled = false;
                    button_updateScooterAndPoint.Enabled = false;
                    button_delScooterAndPoint.Enabled = false;
                    button_addScooterAndPoint.Enabled = false;
                    button_delUser.Enabled = false;
                }

                availability = false;
                if (Registration.allScooters.Count != 0)
                {
                    foreach (Scooter scooter in Registration.allScooters)
                    {
                        if (scooter.IdUser == int.Parse(textBox_idUser.Text))
                        {
                            availability = true;
                            break;
                        }
                    }
                }

                if(!availability)
                {
                    textBox_idUser.Text = "";
                    return;
                }
                else
                {
                    List<Scooter> temporaryScooters = new List<Scooter>();
                    List<int> numbers = new List<int>();
                    foreach (Scooter scooter in Registration.allScooters)
                    {
                        if (scooter.IdUser != int.Parse(textBox_idUser.Text))
                            temporaryScooters.Add(scooter);
                        else
                            numbers.Add(scooter.Id);
                    }
                    Registration.allScooters = temporaryScooters;

                    List<IssuePoint> temporaryPoints = new List<IssuePoint>();
                    foreach(IssuePoint point in Registration.allPoints)
                    {
                        availability = false;
                        foreach(int number in numbers)
                        {
                            if(number == point.IdScooter)
                            {
                                availability = true;
                                break;
                            }
                        }

                        if(!availability)
                            temporaryPoints.Add(point);
                    }
                    Registration.allPoints = temporaryPoints;
                    dataGridView_scooters.DataSource = null;
                    dataGridView_points.DataSource = null;

                    dataGridView_scooters.DataSource = Registration.allScooters;
                    dataGridView_points.DataSource = Registration.allPoints;

                    textBox_idUser.Text = "";
                }
            }

            if (Registration.allScooters.Count == 0)
            {
                button_updateScooterAndPoint.Enabled = false;
                button_delScooterAndPoint.Enabled = false;
            }
        }

        private void button_delScooterAndPoint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idScooter_forDel.Text))
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idScooter_forDel.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idScooter_forDel.Text, Registration.DefineNumber)
                || int.Parse(textBox_idScooter_forDel.Text) < 0)
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idScooter_forDel.Focus();
                return;
            }

            bool availability = false;
            if (Registration.allScooters.Count != 0)
            {
                foreach (Scooter scooter in Registration.allScooters)
                {
                    if (scooter.Id == int.Parse(textBox_idScooter_forDel.Text))
                    {
                        availability = true;
                        break;
                    }
                }
            }

            if (!availability)
            {
                var error = new Error_NotFoundId();
                error.ShowDialog();
                textBox_idScooter_forDel.Focus();
                return;
            }
            else
            {
                List<Scooter> temporaryScooters = new List<Scooter>();
                foreach (Scooter scooter in Registration.allScooters)
                    if (scooter.Id != int.Parse(textBox_idScooter_forDel.Text))
                        temporaryScooters.Add(scooter);
                Registration.allScooters = temporaryScooters;

                List<IssuePoint> temporaryPoints = new List<IssuePoint>();
                foreach (IssuePoint point in Registration.allPoints)
                    if (point.IdScooter != int.Parse(textBox_idScooter_forDel.Text))
                        temporaryPoints.Add(point);
                Registration.allPoints = temporaryPoints;

                dataGridView_scooters.DataSource = null;
                dataGridView_points.DataSource = null;

                dataGridView_scooters.DataSource = Registration.allScooters;
                dataGridView_points.DataSource = Registration.allPoints;

                textBox_idScooter_forDel.Text = "";
            }

            if (Registration.allScooters.Count == 0)
            {
                button_updateScooterAndPoint.Enabled = false;
                button_delScooterAndPoint.Enabled = false;
            }
        }

        private void button_addScooterAndPoint_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Registration.allScooters.Count != 0)
                foreach (Scooter _scooter in Registration.allScooters)
                    count += _scooter.CountScooters;
            Scooter.TotalCountScooters = 15 - count;

            if (string.IsNullOrWhiteSpace(textBox_idPoint.Text))
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_idPoint.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idPoint.Text, Registration.DefineNumber)
                || byte.Parse(textBox_idPoint.Text) < 1 || byte.Parse(textBox_idPoint.Text) > 3)
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_idPoint.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_city.Text))
            {
                var error = new Error_City();
                error.ShowDialog();
                textBox_city.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_street.Text))
            {
                var error = new Error_Street();
                error.ShowDialog();
                textBox_street.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_numberBuilding.Text))
            {
                var error = new Error_NumberBuilding();
                error.ShowDialog();
                textBox_numberBuilding.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_numberBuilding.Text, Registration.DefineNumber)
                || short.Parse(textBox_numberBuilding.Text) <= 0)
            {
                var error = new Error_NumberBuilding();
                error.ShowDialog();
                textBox_numberBuilding.Focus();
                return;
            }

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
            if (dtPicker.Value == DateTime.Today)
            {
                if (byte.Parse(textBox_start.Text) < DateTime.Now.Hour
                    || byte.Parse(textBox_end.Text) < DateTime.Now.Hour)
                {
                    var error = new Error_KolHours();
                    error.ShowDialog();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(textBox_scooterDiscount.Text)
                || !Registration.DoOperation(textBox_scooterDiscount.Text, Registration.DefineNumber)
                || !(byte.Parse(textBox_scooterDiscount.Text) >= 0))
            {
                var error = new Error_Discount();
                error.ShowDialog();
                textBox_scooterDiscount.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_idUser_forAdd.Text))
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser_forAdd.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idUser_forAdd.Text, Registration.DefineNumber)
                || int.Parse(textBox_idUser_forAdd.Text) < 0)
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser_forAdd.Focus();
                return;
            }

            bool availability = false;
            if (Registration.registeredUsers.Count != 0)
            {
                foreach (RegisteredUser user in Registration.registeredUsers)
                {
                    if (user.Id == int.Parse(textBox_idUser_forAdd.Text))
                    {
                        availability = true;
                        break;
                    }
                }
            }
            if (!availability)
            {
                var error = new Error_NotFoundId();
                error.ShowDialog();
                textBox_idUser_forAdd.Focus();
                return;
            }

            IssuePoint issuePoint = new ClassesAndInterfaces.IssuePoint(byte.Parse(textBox_idPoint.Text), textBox_city.Text, textBox_street.Text, short.Parse(textBox_numberBuilding.Text));

            List<int> coupons = new List<int>();
            if (Registration.allScooters == null)
            {
                Registration.allScooters = new List<Scooter>();
            }
            else
            {
                foreach(Scooter _scooter in Registration.allScooters)
                    coupons.Add(_scooter.Coupon);
            }
            short coupon;
            Random rnd = new Random();
            bool result = true;
            if (Registration.allScooters.Count != 0)
            {
                do
                {
                    coupon = (short)rnd.Next(1000, 10000);
                    result = coupons.Exists(c => c == coupon);
                } while (result);
            }
            else
            {
                coupon = (short)rnd.Next(1000, 10000);
            }

            Scooter scooter = new Scooter(byte.Parse(textBox_kolScooters.Text), byte.Parse(textBox_start.Text), byte.Parse(textBox_end.Text), dtPicker.Text, coupon, byte.Parse(textBox_scooterDiscount.Text), issuePoint);
            if (Registration.allScooters.Count == 0)
                scooter.Id = 0;
            else
                scooter.Id = Registration.allScooters[Registration.allScooters.Count - 1].Id + 1;
            scooter.IdUser = int.Parse(textBox_idUser_forAdd.Text);
            scooter.issuePoint.IdScooter = scooter.Id;
            Registration.allScooters.Add(scooter);
            Registration.allPoints.Add(issuePoint);
            Scooter.TotalCountScooters -= scooter.CountScooters;

            dataGridView_points.DataSource = null;
            dataGridView_points.DataSource = Registration.allPoints;
            dataGridView_scooters.DataSource = null;
            dataGridView_scooters.DataSource = Registration.allScooters;

            textBox_idPoint.Text = "";
            textBox_city.Text = "";
            textBox_street.Text = "";
            textBox_numberBuilding.Text = "";
            textBox_idUser_forAdd.Text = "";
            textBox_kolScooters.Text = "";
            textBox_end.Text = "";
            textBox_start.Text = "";
            textBox_scooterDiscount.Text = "";
            textBox_idScooter.Text = "";

            button_delScooterAndPoint.Enabled = true;
            button_updateScooterAndPoint.Enabled = true;
        }

        private void button_updateScooterAndPoint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idPoint.Text))
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_idPoint.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idPoint.Text, Registration.DefineNumber)
                || byte.Parse(textBox_idPoint.Text) < 1 || byte.Parse(textBox_idPoint.Text) > 3)
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_idPoint.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_city.Text))
            {
                var error = new Error_City();
                error.ShowDialog();
                textBox_city.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_street.Text))
            {
                var error = new Error_Street();
                error.ShowDialog();
                textBox_street.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_numberBuilding.Text))
            {
                var error = new Error_NumberBuilding();
                error.ShowDialog();
                textBox_numberBuilding.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_numberBuilding.Text, Registration.DefineNumber)
                || short.Parse(textBox_numberBuilding.Text) <= 0)
            {
                var error = new Error_NumberBuilding();
                error.ShowDialog();
                textBox_numberBuilding.Focus();
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
            if (dtPicker.Value == DateTime.Today)
            {
                if (byte.Parse(textBox_start.Text) < DateTime.Now.Hour
                    || byte.Parse(textBox_end.Text) < DateTime.Now.Hour)
                {
                    var error = new Error_KolHours();
                    error.ShowDialog();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(textBox_scooterDiscount.Text)
                || !Registration.DoOperation(textBox_scooterDiscount.Text, Registration.DefineNumber)
                || !(byte.Parse(textBox_scooterDiscount.Text) >= 0))
            {
                var error = new Error_Discount();
                error.ShowDialog();
                textBox_scooterDiscount.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_idScooter.Text))
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idScooter.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idScooter.Text, Registration.DefineNumber)
                || int.Parse(textBox_idScooter.Text) < 0)
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idScooter.Focus();
                return;
            }

            bool availability = false;
            if (Registration.allScooters.Count != 0)
            {
                foreach (Scooter _scooter in Registration.allScooters)
                {
                    if (_scooter.Id == int.Parse(textBox_idScooter.Text))
                    {
                        availability = true;
                        break;
                    }
                }
            }
            if (!availability)
            {
                var error = new Error_NotFoundId();
                error.ShowDialog();
                textBox_idScooter.Focus();
                return;
            }

            int count = 0;
            if (Registration.allScooters.Count != 0)
                foreach (Scooter _scooter in Registration.allScooters)
                    if (_scooter.Id != int.Parse(textBox_idScooter.Text))
                        count += _scooter.CountScooters;
            Scooter.TotalCountScooters = 15 - count;

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

            foreach(IssuePoint point in Registration.allPoints)
                if(point.IdScooter == int.Parse(textBox_idScooter.Text))
                {
                    point.Id = byte.Parse(textBox_idPoint.Text);
                    point.City = textBox_city.Text;
                    point.Street = textBox_street.Text;
                    point.NumberBuilding = short.Parse(textBox_numberBuilding.Text);
                    _issuePoint = point;
                    break;
                }

            foreach(Scooter _scooter in Registration.allScooters)
                if(_scooter.Id == int.Parse(textBox_idScooter.Text))
                {
                    _scooter.CountScooters = byte.Parse(textBox_kolScooters.Text);
                    _scooter.StartTrip = byte.Parse(textBox_start.Text);
                    _scooter.EndTrip = byte.Parse(textBox_end.Text);
                    _scooter.Date = dtPicker.Text;
                    _scooter.Discount = byte.Parse(textBox_scooterDiscount.Text);
                    _scooter.issuePoint = _issuePoint;
                    Scooter.TotalCountScooters -= _scooter.CountScooters;
                    break;
                }

            dataGridView_points.DataSource = null;
            dataGridView_points.DataSource = Registration.allPoints;
            dataGridView_scooters.DataSource = null;
            dataGridView_scooters.DataSource = Registration.allScooters;

            textBox_idPoint.Text = "";
            textBox_city.Text = "";
            textBox_street.Text = "";
            textBox_numberBuilding.Text = "";
            textBox_idUser_forAdd.Text = "";
            textBox_kolScooters.Text = "";
            textBox_end.Text = "";
            textBox_start.Text = "";
            textBox_scooterDiscount.Text = "";
            textBox_idScooter.Text = "";
        }

        private void button_updateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idUser_forUpdate.Text))
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser_forUpdate.Focus();
                return;
            }
            if (!Registration.DoOperation(textBox_idUser_forUpdate.Text, Registration.DefineNumber)
                || int.Parse(textBox_idUser_forUpdate.Text) < 0)
            {
                var error = new Error_WrongId();
                error.ShowDialog();
                textBox_idUser_forUpdate.Focus();
                return;
            }

            bool availability = false;
            if (Registration.registeredUsers.Count != 0)
            {
                foreach (RegisteredUser user in Registration.registeredUsers)
                {
                    if (user.Id == int.Parse(textBox_idUser_forUpdate.Text))
                    {
                        availability = true;
                        break;
                    }
                }
            }

            if (!availability)
            {
                var error = new Error_NotFoundId();
                error.ShowDialog();
                textBox_idUser_forUpdate.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_name.Text)
                || textBox_name.Text.Length > 20)
            {
                var error = new Error_Name();
                error.ShowDialog();
                textBox_name.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_surname.Text)
                || textBox_surname.Text.Length > 20)
            {
                var error = new Error_Name();
                error.ShowDialog();
                textBox_surname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_phone.Text)
                || !Registration.DoOperation(textBox_phone.Text, Registration.DefineNumber)
                || int.Parse(textBox_phone.Text) < 100000000
                || int.Parse(textBox_phone.Text) > 999999999)
            {
                var error = new Error_Phone();
                error.ShowDialog();
                textBox_phone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_password.Text)
                || textBox_password.Text.Length > 12
                || textBox_password.Text.Length < 8)
            {
                var error = new Error_Password();
                error.ShowDialog();
                textBox_password.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_age.Text)
                || !Registration.DoOperation(textBox_age.Text, Registration.DefineNumber)
                || !RegisteredUser.CheckAge(byte.Parse(textBox_age.Text)))
            {
                var error = new Error_Age();
                error.ShowDialog();
                textBox_age.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_userDiscount.Text)
                || !Registration.DoOperation(textBox_userDiscount.Text, Registration.DefineNumber)
                || !(byte.Parse(textBox_userDiscount.Text) >= 0))
            {
                var error = new Error_Discount();
                error.ShowDialog();
                textBox_userDiscount.Focus();
                return;
            }

            foreach(RegisteredUser user in Registration.registeredUsers)
                if(user.Id == int.Parse(textBox_idUser_forUpdate.Text))
                {
                    user.FirstName = textBox_name.Text;
                    user.LastName = textBox_surname.Text;
                    user.NumberPhone = int.Parse(textBox_phone.Text);
                    user.Password = textBox_password.Text;
                    user.Discount = byte.Parse(textBox_userDiscount.Text);
                    user.Age = byte.Parse(textBox_age.Text);
                    break;
                }

            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_phone.Text = "";
            textBox_password.Text = "";
            textBox_userDiscount.Text = "";
            textBox_age.Text = "";
            textBox_idUser_forUpdate.Text = "";

            dataGridView_users.DataSource = null;
            dataGridView_users.DataSource = Registration.registeredUsers;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            string lines = "";
            if (Registration.registeredUsers != null)
            {
                foreach (var user in Registration.registeredUsers)
                {
                    lines += JsonSerializer.Serialize<RegisteredUser>(user);
                    lines += "\n";
                }
            }
            File.WriteAllText("users.json", lines);

            lines = "";
            if (Registration.allScooters != null)
            {
                foreach (var scooter in Registration.allScooters)
                {
                    lines += JsonSerializer.Serialize<Scooter>(scooter);
                    lines += "\n";
                }
            }
            File.WriteAllText("scooters.json", lines);

            lines = "";
            if (Registration.allPoints != null)
            {
                foreach (var point in Registration.allPoints)
                {
                    lines += JsonSerializer.Serialize<IssuePoint>(point);
                    lines += "\n";
                }
            }
            File.WriteAllText("issuePoints.json", lines);

            Storage.Instance.registration.Close();
        }

        private void AdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.registration.Close();
        }
    }
}
