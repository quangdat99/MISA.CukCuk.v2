using MISA.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interface.Service
{
    /// <summary>
    /// Service khách hàng
    /// </summary>
    /// CreatedBy: DQDAT (20/05/2021)
    public interface ICustomerService
    {
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        /// <param name="customer">Thông tin khách hàng</param>
        /// <returns>Số bản ghi thêm mới được vào database</returns>
        /// CreatedBy: DQDAT (20/05/2021)
        int Insert(Customer customer);
        /// <summary>
        /// Sửa thông tin khách hàng
        /// </summary>
        /// <param name="customer">Thông tin khách hàng</param>
        /// <param name="customerId">Id của khách hàng cần sửa</param>
        /// <returns>Số bản ghi thêm mới được vào database</returns>
        /// CreatedBy: DQDAT (20/05/2021)
        int Update(Customer customer, Guid customerId);
    }
}
