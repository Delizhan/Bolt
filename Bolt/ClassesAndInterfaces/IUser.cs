using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public interface IUser
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? Password { get; set; }
        int UseDiscount(string? date, byte startTrip);
        void GetDiscount();
        byte DefineSpeed(byte age);
        void LogInSystem();
    }
}
