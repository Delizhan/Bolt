using Bolt.ClassesAndInterfaces;
using Bolt.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Storage.Instance.main = this;
        }

        private void button_orenda_Click(object sender, EventArgs e)
        {
            Registration.issuePoint = null;
            if (Registration.registeredUser != null)
            {
                Rent rent = new Rent();
                rent.textBox_login.Text = Registration.registeredUser.FirstName + " " + Registration.registeredUser.LastName;
                rent.Show();
            }
            else
            {
                Registration.registeredUser = null;
                Registration.guest = null;
                Registration.admin = null;
                if (Storage.Instance.registration != null)
                    Storage.Instance.registration.Show();
                this.Hide();
            }
        }

        private void button_lesson1_Click(object sender, EventArgs e)
        {
            Lesson1 lesson1 = new Lesson1();
            lesson1.Show();
        }

        private void button_lesson2_Click(object sender, EventArgs e)
        {
            Lesson2 lesson2 = new Lesson2();
            lesson2.Show();
        }

        private void button_lesson3_Click(object sender, EventArgs e)
        {
            Lesson3 lesson3 = new Lesson3();
            lesson3.Show();
        }

        private void button_lesson4_Click(object sender, EventArgs e)
        {
            Lesson4 lesson4 = new Lesson4();
            lesson4.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (Registration.registeredUsers != null)
                NewPassword.SaveToFileJsonUsers(Registration.registeredUsers);
            Storage.Instance.registration.Close();
            if (Storage.Instance.enter != null)
                Storage.Instance.enter.Close();
            if (Storage.Instance.newPassword != null)
                Storage.Instance.newPassword.Close();
            Storage.Instance.main.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.main = null;
            Application.Exit();
        }
    }
}
