using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public class Scooter: IScooter, IComparable<Scooter>
    {
        private int id;
        private int idUser;
        private static int totalCountScooters = 0;
        private byte countScooters;
        private byte startTrip;
        private byte endTrip;
        private string? date;
        private short coupon;
        private byte discount = 0;
        private byte speed;
        public IssuePoint issuePoint;
        public delegate void Message(string? message);
        public event Message? OnMessage;
        public int Id
        {
            get => id;
            set => id = value;
        }
        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }
        [JsonIgnore]
        public static int TotalCountScooters
        {
            get => totalCountScooters;
            set => totalCountScooters = value;
        }
        [JsonIgnore]
        public static byte MaxSpeed { get; } = 25;
        [JsonIgnore]
        public byte Speed
        {
            get => speed;
            set
            {
                if (value < 0 || value > 25) throw new ArgumentOutOfRangeException();
                speed = value;
            }
        }
        [JsonIgnore]
        public static byte MaxHumanWeight { get; } = 100;
        [JsonIgnore]
        public static short EnginePower { get; } = 300;//Вт
        [JsonIgnore]
        public static double Weight { get; } = 12.5;//kg
        [JsonIgnore]
        public static double SteeringRackHeight { get; } = 1.15;//m
        public byte CountScooters
        {
            get => countScooters;
            set => countScooters = value;
        }
        public byte StartTrip
        {
            get => startTrip;
            set
            {
                if(value < 8 || value > 20) throw new ArgumentOutOfRangeException();
                startTrip = value;
            }
        }
        public byte EndTrip
        {
            get => endTrip;
            set
            {
                if (value < 9 || value > 21) throw new ArgumentOutOfRangeException();
                endTrip = value;
            }
        }
        public string? Date
        {
            get => date;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                if (value.Length != 10) throw new ArgumentOutOfRangeException();
                if (value[2] != '.' || value[5] != '.') throw new ArgumentOutOfRangeException();
                date = value;
            }
        }
        public short Coupon
        {
            get => coupon;
            set
            {
                if (value < 1000 || value > 9999) throw new ArgumentOutOfRangeException();
                coupon = value;
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
        public static void CalculatePrice(byte countScooters, byte time, Action<byte, byte> operation)
        {
            operation(countScooters, time);
        }
        public void Mult(byte firstNumber, byte secondNumber)
        {
            OnMessage?.Invoke($"Ціна прокату {firstNumber} самокатів\nпротягом {secondNumber} годин = {firstNumber * secondNumber * 300} грн.");
        }
        public int CompareTo(Scooter? otherScooter)
        {
            if (otherScooter == null) throw new ArgumentException();
            return CountScooters - otherScooter.CountScooters;
        }
        public void DefineId()
        {
            if (File.ReadLines("scooters.json").ToList() == null)
                Id = 0;
            else
            {
                List<string> lines = new List<string>();
                lines = File.ReadLines("scooters.json").ToList();
                int _id = 0;
                foreach (string line in lines)
                {
                    Scooter? scooter;
                    scooter = JsonSerializer.Deserialize<Scooter>(line);
                    if (_id < scooter.Id) _id = scooter.Id;
                }
                Id = ++_id;
            }
        }
        public Scooter(byte countScooters)
        {
            CountScooters = countScooters;
        }
        public Scooter(byte countScooters, byte startTrip, byte endTrip, string? date, short coupon, byte discount, IssuePoint issuePoint)
        {
            CountScooters = countScooters;
            StartTrip = startTrip;
            EndTrip = endTrip;
            Date = date;
            Coupon = coupon;
            this.issuePoint = issuePoint;
            Discount = discount;
        }
        [JsonConstructor]
        public Scooter(int id, int idUser, byte countScooters, byte startTrip, byte endTrip, string? date, short coupon, byte discount)
        {
            Id = id;
            IdUser = idUser;
            CountScooters = countScooters;
            StartTrip = startTrip;
            EndTrip = endTrip;
            Date = date;
            Coupon = coupon;
            Discount = discount;
        }
    }
}
