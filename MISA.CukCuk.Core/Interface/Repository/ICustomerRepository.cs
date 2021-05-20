using MISA.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interface.Repository
{
    /// <summary>
    /// Repository khách hàng
    /// </summary>
    /// CreatedBy: DQDAT (20/05/2021)
    public interface ICustomerRepository
    {
        /// <summary>
        /// Khởi tạo kết nối Database
        /// </summary>
        /// CreatedBy: DQDAT (20/05/2021)
        void InitConnection();
        /// <summary>
        /// Lấy toàn bộ các bản ghi trong database
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// CreatedBy: DQDAT (20/05/2021)
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetPaging(int pageIndex, int pageSize);
        int Insert(Customer customer);
        int Update(Customer customer, Guid customerId);
        int Delete(Guid customerId);
        bool CheckCustomerCodeExist(string customerCode);
        bool CheckPhoneNumberExist(string phoneNumber);
    }
}
