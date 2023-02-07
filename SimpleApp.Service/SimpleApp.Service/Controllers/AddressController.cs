using Microsoft.AspNetCore.Mvc;
using SimpleApp.Service.Interface;
using SimpleApp.Service.Models.Dto;

namespace SimpleApp.Service.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpPost("address")]
        public IActionResult Create([FromBody] CustomerDto customerDto)
        {
            try
            {
                return Ok(_addressService.Create(new Models.Address()
                {
                    Address1 = customerDto.Address1,
                    Address2 = customerDto.Address2,
                    Address3 = customerDto.Address3,
                    Address4 = customerDto.Address4,
                    PAddress1 = customerDto.PAddress1,
                    PAddress2 = customerDto.PAddress2,
                    PAddress3 = customerDto.PAddress3,
                    PAddress4 = customerDto.PAddress4,
                    CustomerId = customerDto.CustomerId



                }));
            }
            catch (System.Exception ex)
            {

                throw ex;
            }



        }
        [HttpGet("addresses")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_addressService.GetAll());
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
                return Ok(_addressService.GetById(id));
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }
    }
}
