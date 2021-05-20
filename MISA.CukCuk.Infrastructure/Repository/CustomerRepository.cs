using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool CheckCustomerCodeExist(string customerCode)
        {
            throw new NotImplementedException();
        }

        public bool CheckPhoneNumberExist(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return null;
        }

        public IEnumerable<Customer> GetPaging(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void InitConnection()
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int Update(Customer customer, Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
