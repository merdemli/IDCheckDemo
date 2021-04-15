using IDCheckDemo.Abstract;
using IDCheckDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheckDemo.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService   //dış bir servisi, sisteme entegre ederken, "adapter" denilen design patter kullanılır
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
        }

    }
}
