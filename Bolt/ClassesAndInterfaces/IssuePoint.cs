using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public class IssuePoint: ICloneable
    {
        private byte id;
        private int idScooter;
        private string? city;
        private string? street;
        private short numberBuilding;
        public int IdScooter
        {
            get => idScooter;
            set => idScooter = value;
        }
        public byte Id
        {
            get => id;
            set
            {
                if (value < 1 || value > 3) throw new ArgumentOutOfRangeException();
                id = value;
            }
        }
        public string? City
        {
            get => city;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                city = value;
            }
        }
        public string? Street
        {
            get => street;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                street = value;
            }
        }
        public short NumberBuilding
        {
            get => numberBuilding;
            set
            {
                if(value <= 0) throw new ArgumentOutOfRangeException();
                numberBuilding = value;
            }
        }
        public object Clone() => new IssuePoint(Id, IdScooter, City, Street, NumberBuilding);
        [JsonConstructor]
        public IssuePoint(byte id, string? city, string? street, short numberBuilding)
        {
            Id = id;
            City = city;
            Street = street;
            NumberBuilding = numberBuilding;
        }
        public IssuePoint(byte id, int idScooter, string? city, string? street, short numberBuilding)
        {
            Id = id;
            IdScooter = idScooter;
            City = city;
            Street = street;
            NumberBuilding = numberBuilding;
        }
    }
}
