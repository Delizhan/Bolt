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

namespace Bolt
{
    public partial class SMS_NewPassword : Form
    {
        public SMS_NewPassword()
        {
            InitializeComponent();
            Storage.Instance.sms_newPassword = this;
        }

        private void button__next_Click(object sender, EventArgs e)
        {
            var mainOne = new Main();
            mainOne.Show();
            this.Hide();
            Storage.Instance.sms_newPassword = null;
        }

        private void SMS_NewPassword_FormClosed(object sender, FormClosedEventArgs e)
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
