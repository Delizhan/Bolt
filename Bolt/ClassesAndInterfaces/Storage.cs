using Bolt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.ClassesAndInterfaces
{
    public class Storage
    {
        private static Storage? instance = null;
        private Storage()
        {

        }
        public static Storage? Instance
        {
            get
            {
                if(instance == null)
                    instance = new Storage();
                return instance;
            }
        }
        public Registration? registration { get; set; } = null;
        public Enter? enter { get; set; } = null;
        public NewPassword? newPassword { get; set; } = null;
        public Main? main { get; set; } = null;
        public Rent? rent { get; set; } = null;
        public More? more { get; set; } = null;
        public SMS_Registration? sms_reg { get; set; } = null;
        public SMS_NewPassword? sms_newPassword { get; set; } = null;
    }
}
