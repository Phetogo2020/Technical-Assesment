using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simpleApp.Interface;
using simpleApp.Models;
using System.Diagnostics;

namespace simpleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAddressService _addressService;
        private readonly ICustomerService _customerService;

        public HomeController(ILogger<HomeController> logger, ICustomerService customerService, IAddressService addressService)
        {
            _logger = logger;
            _addressService = addressService;
            _customerService = customerService;
        }
        public IActionResult List()
        {
            var results = _customerService.Get();
            return View(results);
        }
        public IActionResult Create(CustomerViewModel customerViewModel)
        {
            var results = _customerService.Create(customerViewModel);
            return Redirect("List");
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Details(int id)
        {
            var customer = _customerService.GetById(id);
            var address = _addressService.GetById(customer.CustomerId);

            var customerVM = new CustomerViewModel()
            {
                Address1 = address.Address1,
                Address2 = address.Address2,
                Address3 = address.Address3,
                Address4 = address.Address4,
                PAddress1 = address.PAddress1,
                PAddress2 = address.PAddress2,
                PAddress3 = address.PAddress3,
                PAddress4 = address.PAddress4,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone

            };
            return View(customerVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
