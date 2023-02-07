using SimpleApp.Service.Interface;
using SimpleApp.Service.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Service.Service
{
    public class AddressService : IAddressService
    {
        private readonly IRepository _repository;

        public AddressService(IRepository repository)
        {
            _repository = repository;
        }
        public Address Create(Address address)
        {
            return _repository.AddEntity(address);
        }

        public List<Address> GetAll()
        {
            return _repository.All<Address>().ToList();
        }

        public Address GetById(int Id)
        {
            return _repository.Search<Address>(c => c.AddressId == Id).FirstOrDefault();
        }
    }
}
