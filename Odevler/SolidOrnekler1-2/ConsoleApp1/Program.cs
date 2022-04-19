using ConsoleApp1;
using ConsoleApp1.Abstract;
using ConsoleApp1.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEntity> personellist = new List<IEntity>()
            {
                new Doctor{FirstName="Arzu",LastName="Akan"},
            new Nurse { FirstName="Tuba", LastName="Bugday"},
            new AdministrativeStaff{FirstName="Hasan",LastName="Haklı"}
            };

            List<Employe> employes = new List<Employe>();

            foreach (var person in personellist)
            {
                employes.Add(person.GenereateAccount.Create(person));
            }
            foreach (var employee in employes)
            {
                Console.WriteLine($"Ad: {employee.Firstname} Soyad: {employee.Lastname} Email: {employee.Email} Doktor: {employee.IsDoctor} Hemşire: {employee.IsNurse} İdariPersonel: {employee.IsAdministrativeStaff}");
            }
            Console.Read();

        }
    }
}
