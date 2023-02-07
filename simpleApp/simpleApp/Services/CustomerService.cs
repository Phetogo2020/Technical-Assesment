using Newtonsoft.Json;
using simpleApp.Interface;
using simpleApp.Models;
using System.Collections.Generic;

namespace simpleApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IIntegration _integration;
        public CustomerService(IIntegration integration)
        {
            _integration = integration;
        }
        public CustomerViewModel Create(CustomerViewModel customerViewModel)
        {
            var request = _integration.ResponseFromAPIPost("", "api/Customer", customerViewModel, "http://localhost:42898/", true);


            if (request != null)
            {
                var results = JsonConvert.DeserializeObject<CustomerViewModel>(request.Message);
                return results;
            }
            else
            {
                return null;
            }

        }

        public List<CustomerViewModel> Get()
        {
            var request = _integration.ResponseFromAPIGet("", "/api/Customer/customers", "http://localhost:42898", "GET");


            if (request != null)
            {
                var results = JsonConvert.DeserializeObject<List<CustomerViewModel>>(request.Message);
                return results;
            }
            else
            {
                return null;
            }
        }

        public CustomerViewModel GetById(int Id)
        {
            var request = _integration.ResponseFromAPIGet("", $"/api/Customer/byId?id={Id}", "http://localhost:42898", "GET");


            if (request != null)
            {
                var results = JsonConvert.DeserializeObject<CustomerViewModel>(request.Message);
                return results;
            }
            else
            {
                return null;
            }
        }


    }
}
