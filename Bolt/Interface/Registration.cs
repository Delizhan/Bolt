using Bolt.ClassesAndInterfaces;
using Bolt.Interface;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.LinkLabel;

namespace Bolt
{
    public partial class Registration : Form
    {
        public static RegisteredUser? registeredUser = null;
        public static Guest? guest = null;
        public static Admin? admin = null;
        public static IssuePoint? issuePoint = null;
        public static Scooter? scooter = null;
        public static List<RegisteredUser>? registeredUsers = null;
        public static List<Scooter>? allScooters = null;
        public static List<IssuePoint>? allPoints = null;
        public Registration()
        {
            InitializeComponent();
            Storage.Instance.registration = this;
            registeredUsers = ReadUserRecords();
            allScooters = ReadScooterRecords();
            allPoints = ReadPointRecords();
            if (registeredUsers == null)
                registeredUsers = new List<RegisteredUser>();
            if(allScooters == null)
                allScooters = new List<Scooter>();
            if(allPoints == null)
                allPoints = new List<IssuePoint>();
        }
        public List<RegisteredUser> ReadUserRecords()
        {
            List<RegisteredUser>? users = new List<RegisteredUser>();
            if (File.ReadLines("users.json").ToList() == null)
                users = null;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("users.json").ToList();
                foreach (string line in lines)
                {
                    RegisteredUser? user;
                    user = JsonSerializer.Deserialize<RegisteredUser>(line);
                    users.Add(user);
                }
            }
            return users;
        }
        public List<Scooter> ReadScooterRecords()
        {
            List<Scooter>? scooters = new List<Scooter>();
            if (File.ReadLines("scooters.json").ToList() == null)
                scooters = null;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("scooters.json").ToList();
                foreach (string line in lines)
                {
                    Scooter? _scooter;
                    _scooter = JsonSerializer.Deserialize<Scooter>(line);
                    scooters.Add(_scooter);
                }
            }
            return scooters;
        }
        public List<IssuePoint> ReadPointRecords()
        {
            List<IssuePoint>? points = new List<IssuePoint>();
            if (File.ReadLines("issuePoints.json").ToList() == null)
                points = null;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("issuePoints.json").ToList();
                foreach (string line in lines)
                {
                    IssuePoint? point;
                    point = JsonSerializer.Deserialize<IssuePoint>(line);
                    points.Add(point);
                }
            }
            return points;
        }
        public static bool DoOperation(string number, Func<string, bool> operation) => operation(number);
        public static bool DefineNumber(string number)
        {
            foreach(char c in number)
                if((int)c < 48 || (int)c > 57)
                    return false;
            return true;
        }
        private void button_sign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
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
            if (registeredUsers != null)
            {
                foreach (RegisteredUser user in registeredUsers)
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
                if (textBox_name.Text.Length > 20)
                {
                    var error = new Error_Name();
                    error.ShowDialog();
                    textBox_name.Focus();
                    return;
                }
                if (textBox_surname.Text.Length > 20)
                {
                    var error = new Error_Name();
                    error.ShowDialog();
                    textBox_surname.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_phone.Text)
                    || !DoOperation(textBox_phone.Text, DefineNumber)
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
                    || !DoOperation(textBox_age.Text, DefineNumber)
                    || !RegisteredUser.CheckAge(byte.Parse(textBox_age.Text)))
                {
                    var error = new Error_Age();
                    error.ShowDialog();
                    textBox_age.Focus();
                    return;
                }
                guest = new Guest();
                registeredUser = new RegisteredUser(textBox_name.Text, textBox_surname.Text, int.Parse(textBox_phone.Text), textBox_password.Text);
                registeredUser.Discount = guest.gift.Discount;
                registeredUser.Age = byte.Parse(textBox_age.Text);
                registeredUser.DefineId();
            }
            else
            {
                var error = new Error_WrongName();
                error.ShowDialog();
                textBox_name.Focus();
                return;
            }

            if (registeredUser != null)
            {
                string line = JsonSerializer.Serialize<RegisteredUser>(registeredUser);
                line += '\n';
                File.AppendAllText("users.json", line);
                registeredUsers.Add(registeredUser);
                var sucRegister = new SMS_Registration();
                sucRegister.Show();
                this.Hide();
            }
        }
        public void PrintMessage(string message)
        {
            SMS sms = new SMS();
            sms.label_LogIn.Text = message;
            this.Hide();
            sms.ShowDialog();
            guest.OnMessage -= PrintMessage;
        }
        private void button_guest_Click(object sender, EventArgs e)
        {
            guest = new Guest();
            guest.OnMessage += PrintMessage;
            guest.LogInSystem();
        }
        private void button_enter_Click(object sender, EventArgs e)
        {
            var enter = new Enter();
            enter.Show();
            this.Hide();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
    }
}