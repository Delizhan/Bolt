using Bolt.ClassesAndInterfaces;
using Bolt.Interface;
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

namespace Bolt
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
            Storage.Instance.newPassword = this;
        }
        public static short _code = 0;
        public static void SaveToFileJsonUsers(List<RegisteredUser> users)
        {
            string lines = "";
            foreach (var user in users)
            {
                lines += JsonSerializer.Serialize<RegisteredUser>(user);
                lines += "\n";
            }
            if (lines != "")
                File.WriteAllText("users.json", lines);
        }
        private void button_password_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                var error = new Error_Name();
                error.ShowDialog();
                textBox_name.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_surname.Text))
            {
                var error = new Error_Name();
                error.ShowDialog();
                textBox_surname.Focus();
                return;
            }
            if (textBox_name.Text == "Admin")
            {
                var error = new Error_Admin();
                error.ShowDialog();
                textBox_name.Focus();
                return;
            }
            if (textBox_surname.Text == "Admin")
            {
                var error = new Error_Admin();
                error.ShowDialog();
                textBox_surname.Focus();
                return;
            }

            bool availability = false;
            if (Registration.registeredUsers.Count != 0)
            {
                foreach (RegisteredUser user in Registration.registeredUsers)
                {
                    if (user.FirstName == textBox_name.Text
                        && user.LastName == textBox_surname.Text)
                    {
                        Registration.registeredUser = user;
                        availability = true;
                        break;
                    }
                }
            }

            if (availability)
            {
                if (!(textBox_name.Text.Length > 20))
                {
                    if (!(textBox_surname.Text.Length > 20))
                    {
                        if (!string.IsNullOrWhiteSpace(textBox_new_password.Text)
                            && !(textBox_new_password.Text.Length > 12)
                            && !(textBox_new_password.Text.Length < 8))
                        {
                            if (Registration.registeredUser != null)
                            {
                                if (textBox_new_password.Text != Registration.registeredUser.Password)
                                {
                                    if(_code == 0
                                        || string.IsNullOrWhiteSpace(textBox_code.Text)
                                        || !Registration.DoOperation(textBox_code.Text, Registration.DefineNumber)
                                        || int.Parse(textBox_code.Text) < 1000
                                        || int.Parse(textBox_code.Text) > 9999)
                                    {
                                        var error = new Error_Code();
                                        error.ShowDialog();
                                        textBox_code.Focus();
                                        return;
                                    }

                                    Registration.registeredUser.Code = _code;

                                    if (Registration.registeredUser.ChangePassword(short.Parse(textBox_code.Text), textBox_new_password.Text))
                                    {
                                        SaveToFileJsonUsers(Registration.registeredUsers);
                                        var sucNewPassword = new SMS_NewPassword();
                                        sucNewPassword.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        var error = new Error_Code();
                                        error.ShowDialog();
                                        textBox_code.Focus();
                                    }
                                }
                                else
                                {
                                    var error = new Error_NewPassword();
                                    error.ShowDialog();
                                    textBox_new_password.Focus();
                                }
                            }
                        }
                        else
                        {
                            var error = new Error_Password();
                            error.ShowDialog();
                            textBox_new_password.Focus();
                        }
                    }
                    else
                    {
                        var error = new Error_Name();
                        error.ShowDialog();
                        textBox_surname.Focus();
                    }
                }
                else
                {
                    var error = new Error_Name();
                    error.ShowDialog();
                    textBox_name.Focus();
                }
            }
            else
            {
                var error = new Error_UserAccount();
                error.ShowDialog();
                textBox_name.Focus();
            }

        }
        private void button_code_Click(object sender, EventArgs e)
        {
            var code = new Code();
            code.Show();
        }

        private void NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.newPassword = null;
            Application.Exit();
        }
    }
}
