using simpleApp.Models;
using System.Collections.Generic;

namespace simpleApp.Interface
{
    public interface ICustomerService
    {
        CustomerViewModel Create(CustomerViewModel customerViewModel);

        CustomerViewModel GetById(int Id);
        List<CustomerViewModel> Get();

    }
}
