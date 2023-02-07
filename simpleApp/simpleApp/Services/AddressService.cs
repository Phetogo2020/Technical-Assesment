using Newtonsoft.Json;
using simpleApp.Interface;
using simpleApp.Models;
using System.Collections.Generic;

namespace simpleApp.Services
{
    public class AddressService : IAddressService
    {
        private readonly IIntegration _integration;
        public AddressService(IIntegration integration)
        {
            _integration = integration;
        }
        public CustomerViewModel Create(CustomerViewModel customerViewModel)
        {
            var request = _integration.ResponseFromAPIPost("", "/address", customerViewModel, "http://localhost:42898", true);


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
            var request = _integration.ResponseFromAPIGet("", "addresses", "http://localhost:42898", "GET");


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
            var request = _integration.ResponseFromAPIGet("", $"byId?id={Id}", "http://localhost:42898", "GET");


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
