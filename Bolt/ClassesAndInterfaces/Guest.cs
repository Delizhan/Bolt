using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public class Guest: User
    {
        public Gift gift;
        public override string? FirstName { get; set; } = "Guest";
        public override string? LastName { get; set; } = "Guest";
        public override string? Password { get; set; } = null;
        public override event Message? OnMessage;
        public Guest()
        {
            gift = new Gift();
        }
        public override void LogInSystem()
        {
            OnMessage?.Invoke($"Ви ввійшли як гість.");
        }
    }
}
