using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAbstraction.FakeDatabase;

namespace ProductAbstraction
{
    public class Supplier : BaseClass
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public override string Add()
        {
            Database.supplierList.Add(new Supplier()
            {
                CompanyName = CompanyName,
                PhoneNumber = PhoneNumber,
                Address=Address,
                CreatedDate = DateTime.Now,
                IsActive = true
            });

            return $" {DateTime.Now} Tarihinde {CompanyName}  İsimli Tedarikçi Eklendi.";
        }
        public override string Update(int index)
        {

            Supplier supplier = Database.supplierList[index];
            supplier.CompanyName = CompanyName;
            supplier.PhoneNumber = PhoneNumber;
            supplier.Address = Address;


            return $"{DateTime.Now} Tarihinde {supplier.CompanyName} İsimli Tedarikçi Bilgileri Güncellendi.";
        }
        public override string Delete(int index)
        {
            Supplier supplier = Database.supplierList[index];
            Database.supplierList.RemoveAt(index);

            return $"{DateTime.Now} Tarihinde {supplier.CompanyName} İsimli Tedarikçi Silindi.";
        }
        public override string List()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $" Şirket Adı: {CompanyName}, Telefon:  {PhoneNumber}, Adres: {Address}  " ;
        }


    }

}
