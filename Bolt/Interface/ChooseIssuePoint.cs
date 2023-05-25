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
using System.Windows.Forms.VisualStyles;

namespace Bolt.Interface
{
    public partial class ChooseIssuePoint : Form
    {
        public ChooseIssuePoint()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_id.Focus();
                return;
            }
            if(!Registration.DoOperation(textBox_id.Text, Registration.DefineNumber)
                || byte.Parse(textBox_id.Text) < 1 || byte.Parse(textBox_id.Text) > 3)
            {
                var error = new Error_Id();
                error.ShowDialog();
                textBox_id.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(textBox_city.Text))
            {
                var error = new Error_City();
                error.ShowDialog();
                textBox_city.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(textBox_street.Text))
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
            if(!Registration.DoOperation(textBox_numberBuilding.Text, Registration.DefineNumber)
                || short.Parse(textBox_numberBuilding.Text) <= 0)
            {
                var error = new Error_NumberBuilding();
                error.ShowDialog();
                textBox_numberBuilding.Focus();
                return;
            }

            Registration.issuePoint = new ClassesAndInterfaces.IssuePoint(byte.Parse(textBox_id.Text), textBox_city.Text, textBox_street.Text, short.Parse(textBox_numberBuilding.Text));
            this.Close();
        }
    }
}
