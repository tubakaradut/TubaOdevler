using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generate
{
    public class AdministrativeStaffAccount : IAccount
    {
        public Employe Create(IEntity account)
        {
            Employe employe = new Employe();
            employe.Firstname = account.FirstName;
            employe.Lastname = account.LastName;
            employe.Email = account.FirstName.Substring(0, 1) + account.LastName.ToLower() + "@kartaleah.com";
            employe.IsAdministrativeStaff = true;

            return employe;
        }
    }
}
