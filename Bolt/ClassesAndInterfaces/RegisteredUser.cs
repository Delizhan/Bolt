using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolt.ClassesAndInterfaces
{
    public class RegisteredUser: User
    {
        private int id;
        private string? firstName;
        private string? lastName;
        private int numberPhone;
        private string? password;
        private short code;
        private byte discount;
        public List<Scooter> Scooters;
        public delegate void _Date(int day, int month);
        public event _Date OnDate;
        public override event Message? OnMessage;
        public int Id
        {
            get => id;
            set => id = value;
        }
        public override string? FirstName
        { 
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                firstName = value;
            }
        }
        public override string? LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                lastName = value;
            }
        }
        public int NumberPhone
        {
            get => numberPhone;
            set
            {
                if (value < 100000000 || value > 999999999) throw new ArgumentOutOfRangeException();
                numberPhone = value;
            }
        }
        public override string? Password
        {
            get => password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                password = value;
            }
        }
        [JsonIgnore]
        public short Code
        {
            get => code;
            set
            {
                if (value < 1000 || value > 9999) throw new ArgumentOutOfRangeException();
                code = value;
            }
        }
        public byte Discount
        {
            get => discount;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                discount = value;
            }
        }
        public bool ChangePassword(short codeEntered, string? newPassword)
        {
            if (codeEntered == Code)
            {
                Password = newPassword;
                return true;
            }
            return false;
        }
        public static bool CheckAge(byte age)
        {
            if (age >= 14) return true;
            return false;
        }
        public override byte DefineSpeed(byte age)
        {
            if (age >= 18) return 25;
            return 15;
        }
        public override void LogInSystem()
        {
            OnMessage?.Invoke($"Ви ввійшли як {FirstName} {LastName}.");
        }
        public override int UseDiscount(string? date, byte startTrip)
        {
            if (Discount != 0)
            {
                foreach (Scooter scooter in Scooters)
                    if (scooter.Date == date && startTrip == scooter.StartTrip)
                    {
                        scooter.Discount += Discount;
                        OnMessage?.Invoke("Знижка успішно активована.");
                        return scooter.Id;
                    }
                OnMessage?.Invoke("Запису з такими даними не існує.");
            }
            else
                OnMessage?.Invoke("Ви не маєте знижок для використання.");
            return -1;
        }
        public override void GetDiscount()
        {
            OnDate?.Invoke(DateTime.Now.Day, DateTime.Now.Month);
            if (DateTime.Now.Day == DateTime.Now.Month)
                OnMessage?.Invoke("Сьогоднішня дата є щасливою.\nВи отримуєте знижку - 15%.");
            else
                OnMessage?.Invoke("Сьогоднішня дата не є щасливою.\nВи не можете отримати знижку.");
        }
        public void DefineId()
        {
            if (File.ReadLines("users.json").ToList() == null)
                Id = 0;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("users.json").ToList();
                int _id = 0;
                foreach (string line in lines)
                {
                    RegisteredUser? user;
                    user = JsonSerializer.Deserialize<RegisteredUser>(line);
                    if (_id < user.Id) _id = user.Id;
                }
                Id = ++_id;
            }
        }
        public RegisteredUser(string? firstName, string? lastName, int numberPhone, string? password)
        {
            FirstName = firstName;
            LastName = lastName;
            NumberPhone = numberPhone;
            Password = password;
        }
        [JsonConstructor]
        public RegisteredUser(int id, string? firstName, string? lastName, int numberPhone, string? password, byte discount)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NumberPhone = numberPhone;
            Password = password;
            Discount = discount;
        }
    }
}
