using ConsoleApp1.Abstract;
using ConsoleApp1.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Account
{
    public class Doctor : IEntity
    {
        public Doctor()
        {
            GenereateAccount = new DoctorAccount();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount GenereateAccount { get; set; }
    }
}
