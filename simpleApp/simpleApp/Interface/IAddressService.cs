using simpleApp.Models;
using System.Collections.Generic;

namespace simpleApp.Interface
{
    public interface IAddressService
    {
        CustomerViewModel Create(CustomerViewModel customerViewModel);

        CustomerViewModel GetById(int Id);
        List<CustomerViewModel> Get();
    }
}
