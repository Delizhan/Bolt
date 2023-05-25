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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            Storage.Instance.enter = this;
        }
        public void PrintMessage(string message)
        {
            SMS sms = new SMS();
            sms.label_LogIn.Text = message;
            this.Hide();
            sms.ShowDialog();
            if (Registration.registeredUser != null)
                Registration.registeredUser.OnMessage -= PrintMessage;
            else if (Registration.admin != null)
                Registration.admin.OnMessage -= PrintMessage;
        }
        private void button_sign_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "Admin"
                && textBox_surname.Text == "Admin"
                && textBox_password.Text == "admin787")
            {
                Registration.admin = new Admin();
                Registration.admin.OnMessage += PrintMessage;
                Registration.admin.LogInSystem();
            }
            else
            {
                bool availability = false;
                if (!string.IsNullOrWhiteSpace(textBox_name.Text)
                    && !string.IsNullOrWhiteSpace(textBox_surname.Text)
                    && Registration.registeredUsers.Count != 0)
                {
                    foreach (RegisteredUser user in Registration.registeredUsers)
                    {
                        if (user.FirstName == textBox_name.Text && user.LastName == textBox_surname.Text && user.Password == textBox_password.Text)
                        {
                            Registration.registeredUser = user;
                            availability = true;
                            break;
                        }
                    }
                }
                else
                {
                    var error = new Error_UserAccount();
                    error.ShowDialog();
                }

                if (availability && Registration.registeredUser != null)
                {
                    Registration.registeredUser.OnMessage += PrintMessage;
                    Registration.registeredUser.LogInSystem();
                }
                else
                {
                    var error = new Error_UserAccount();
                    error.ShowDialog();
                }
            }
        }

        private void button_choose_password_Click(object sender, EventArgs e)
        {
            var password = new NewPassword();
            this.Hide();
            password.Show();
        }

        private void Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.enter = null;
            Application.Exit();
        }
    }
}
