using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public class Admin : User
    {
        public override string? FirstName { get; set; } = "Admin";
        public override string? LastName { get; set; } = "Admin";
        public override string? Password { get; set; } = "admin787";
        public override event Message? OnMessage;
        public override void LogInSystem()
        {
            OnMessage?.Invoke($"Ви ввійшли як адміністратор.");
        }
    }
}
