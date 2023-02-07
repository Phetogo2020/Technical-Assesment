using SimpleApp.Service.Models;
using System.Collections.Generic;

namespace SimpleApp.Service.Interface
{
    public interface IAddressService
    {
        Address Create(Address address);
        List<Address> GetAll();
        Address GetById(int Id);
    }
}
