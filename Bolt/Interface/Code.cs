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
    public partial class Code : Form
    {
        public Code()
        {
            InitializeComponent();
        }
        private void button_code_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label_code.Text += random.Next(1000, 10000);
            NewPassword._code = short.Parse(label_code.Text);
        }
    }
}
