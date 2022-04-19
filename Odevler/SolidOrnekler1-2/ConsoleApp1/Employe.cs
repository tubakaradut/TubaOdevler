using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employe
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IAccount GenereateAccount { get; set; }
        public string Email { get; set; }

        public bool IsDoctor { get; set; }
        public bool IsNurse { get; set; }
        public bool IsAdministrativeStaff { get; set; }
    }
}
