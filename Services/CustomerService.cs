using customer.Dal;
using customer.Dtos;
using customer.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace customer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext _customerContext;

        public CustomerService(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public async Task CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            var customer = new Customer
            {

                FirstName = createCustomerDto.FirstName,
                LastName = createCustomerDto.LastName,
                Address = createCustomerDto.Address,
                Email = createCustomerDto.Email,
                DateOfBirth = createCustomerDto.DateOfBirth,
                IsPremiumMember = createCustomerDto.IsPremiumMember,
                PhoneNumber = createCustomerDto.PhoneNumber
            };
            await _customerContext.Customers.AddAsync(customer);
            await _customerContext.SaveChangesAsync();
        }

        public  async Task DeleteCustomerAsync(int id)
        {
            var values = await _customerContext.Customers.FindAsync(id);
            _customerContext.Customers.Remove(values);
            await _customerContext.SaveChangesAsync();
        }

        public async Task<List<ResultCustomerDto>> GetAllCustomerAsync()
        {
            return await _customerContext.Customers
                .Select(c => new ResultCustomerDto
                {
                    Address = c.Address,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    DateOfBirth = c.DateOfBirth,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Id = c.Id,
                    IsPremiumMember = c.IsPremiumMember

                }).ToListAsync();
        }

        public async  Task<GetByIdCustomerDto> GetByIdCustomersync(int id)
        {
            var customerıd = await _customerContext.Customers.FindAsync(id);
            return new GetByIdCustomerDto
            {
                Address = customerıd.Address,
                DateOfBirth = customerıd.DateOfBirth,
                Email = customerıd.Email,
                FirstName = customerıd.FirstName,
                Id = customerıd.Id,
                IsPremiumMember = customerıd.IsPremiumMember,
                LastName = customerıd.LastName,
                PhoneNumber = customerıd.PhoneNumber
            };
        }

        public async Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
        {
            var updatecustomer = new Customer
            {
                FirstName = updateCustomerDto.FirstName,
                Address = updateCustomerDto.Address,
                DateOfBirth = updateCustomerDto.DateOfBirth,
                IsPremiumMember = updateCustomerDto.IsPremiumMember,
                LastName = updateCustomerDto.LastName,
                PhoneNumber = updateCustomerDto.PhoneNumber,

            };
            _customerContext.Customers.Update(updatecustomer);
            await _customerContext.SaveChangesAsync();
        }
    }
}
