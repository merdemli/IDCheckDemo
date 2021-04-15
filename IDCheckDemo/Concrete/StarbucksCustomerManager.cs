using IDCheckDemo.Abstract;
using IDCheckDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheckDemo.Concrete
{
    public class StarbucksCustomerManager: BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
                                                                                            //dependency injection
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;                                   //constructor
        }


        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
           
        }
    }
}
