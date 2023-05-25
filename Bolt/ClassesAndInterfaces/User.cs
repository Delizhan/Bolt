using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public abstract class User: IUser
    {
        private byte age;
        public byte Age 
        { 
            get => age; 
            set
            {
                if(value < 14) throw new ArgumentOutOfRangeException();
                age = value;
            }
        }
        public abstract string? FirstName { get; set; }
        public abstract string? LastName { get; set; }
        public abstract string? Password { get; set; }
        public delegate void Message(string message);
        public virtual event Message? OnMessage;
        public virtual int UseDiscount(string? date, byte startTrip)
        {
            return -1;
        }
        public virtual void GetDiscount()
        {

        }
        public virtual byte DefineSpeed(byte age) 
        {
            return 0;
        }
        public abstract void LogInSystem();
    }
} 
