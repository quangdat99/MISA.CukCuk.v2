using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interface.Repository;
using MISA.CukCuk.Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Web.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        ICustomerRepository _customerRepository;
        ICustomerService _customerService;

        public CustomerController(ICustomerRepository customerRepository, ICustomerService customerService)
        {
            _customerRepository = customerRepository;
            _customerService = customerService;
        }
        /// <summary>
        /// Lấy toàn bộ khách hàng
        /// </summary>
        /// <returns>
        /// 200 - dữ liệu toàn bộ khách hàng
        /// 204 - không có dữ liệu
        /// 400 - dữ liệu đầu vào không hợp lệ
        /// 500 - exception
        /// </returns>
        /// CreatedBy: DQDAT (20/05/2021)
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerRepository.GetAll();
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            var rowAffects = _customerService.Insert(customer);
            return Ok(rowAffects);
        }
    }
}
