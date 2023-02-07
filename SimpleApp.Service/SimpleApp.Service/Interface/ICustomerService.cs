using SimpleApp.Service.Models;
using System.Collections.Generic;

namespace SimpleApp.Service.Interface
{
    public interface ICustomerService
    {
        Customer Create(Customer customer);

        List<Customer> GetAll();
        Customer GetById(int Id);
    }
}
