using Bolt.ClassesAndInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolt.Interface
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }

        private void button__next_Click(object sender, EventArgs e)
        {
            if (Registration.registeredUser != null || Registration.guest != null)
            {
                var mainOne = new Main();
                mainOne.Show();
                this.Hide();
            }
            else
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                this.Hide();
            }
        }

        private void SMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Storage.Instance.registration.Close();
            if (Storage.Instance.enter != null)
                Storage.Instance.enter.Close();
            if (Storage.Instance.newPassword != null)
                Storage.Instance.newPassword.Close();
            this.Close();
        }
    }
}
