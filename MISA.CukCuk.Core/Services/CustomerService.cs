using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interface.Repository;
using MISA.CukCuk.Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int Insert(Customer customer)
        {
            // Duyệt hồ sơ thông tin khách hàng:
            ValidateCustomer(customer);
            // Dữ liệu hợp lệ rồi thì thực hiện thêm mới vào database:

            return _customerRepository.Insert(customer);
        }

        void ValidateCustomer(Customer customer)
        {
            // Check mã khách hàng đã có hay chưa ?

            // Check mã khách hàng có bị trùng không ?
        }

        public int Update(Customer customer, Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
