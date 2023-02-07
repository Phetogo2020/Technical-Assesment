using Microsoft.AspNetCore.Mvc;
using SimpleApp.Service.Interface;
using SimpleApp.Service.Models.Dto;

namespace SimpleApp.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        private readonly IAddressService _addressService;
        public CustomerController(ICustomerService customerService, IAddressService addressService)
        {
            _customerService = customerService;
            _addressService = addressService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] CustomerDto customerDto)
        {
            try
            {
                var cust = _customerService.Create(new Models.Customer()
                {
                    Name = customerDto.Name,
                    Phone = customerDto.Phone,
                    Surname = customerDto.Surname
                });

                var addr = _addressService.Create(new Models.Address()
                {
                    Address1 = customerDto.Address1,
                    Address2 = customerDto.Address2,
                    Address3 = customerDto.Address3,
                    Address4 = customerDto.Address4,
                    PAddress1 = customerDto.PAddress1,
                    PAddress2 = customerDto.PAddress2,
                    PAddress3 = customerDto.PAddress3,
                    PAddress4 = customerDto.PAddress4,
                    CustomerId = cust.CustomerId
                });
                return Ok(cust);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }



        }
        [HttpGet("customers")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_customerService.GetAll());
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("byId")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_customerService.GetById(id));
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }
    }
}
