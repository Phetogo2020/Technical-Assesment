using SimpleApp.Service.Interface;
using SimpleApp.Service.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SimpleApp.Service.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }
        public Customer Create(Customer customer)
        {
            return _repository.AddEntity(customer);
        }

        public List<Customer> GetAll()
        {
            return _repository.Search<Customer>(c => c.CustomerId > 0).Include(c => c.Comment).ToList();
        }

        public Customer GetById(int Id)
        {
            return _repository.Search<Customer>(c => c.CustomerId == Id).Include(c => c.Comment).FirstOrDefault();
        }
    }
}
