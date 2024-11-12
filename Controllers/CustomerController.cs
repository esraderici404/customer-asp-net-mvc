using customer.Dtos;
using customer.Services;
using Microsoft.AspNetCore.Mvc;

namespace customer.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task< ActionResult> List()
        {
            var CustomerList = await _customerService.GetAllCustomerAsync();
            return View(CustomerList);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task <ActionResult> AddCustomer(CreateCustomerDto createCustomerDto)
        {
            await _customerService.CreateCustomerAsync(createCustomerDto);
            return RedirectToAction("List", "Customer");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _customerService.DeleteCustomerAsync(id);
            return RedirectToAction("List", "Customer");
        }
     
        [HttpGet]
        public async Task<IActionResult> EditCustomer(int id)
        {

            var customer = await _customerService.GetByIdCustomersync(id);
            return View(customer);

        }

        [HttpPost]
        public async Task<IActionResult> EditCustomer(UpdateCustomerDto updateCustomerDto)
        {

            await _customerService.UpdateCustomerAsync(updateCustomerDto);
            return RedirectToAction("ListCustomer", "Customer");

        }

    }
}
