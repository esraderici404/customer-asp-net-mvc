using customer.Dtos;

namespace customer.Services
{
    public interface ICustomerService
    {
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);

        Task DeleteCustomerAsync(int id);

        Task<List<ResultCustomerDto>> GetAllCustomerAsync();

        Task<GetByIdCustomerDto> GetByIdCustomersync(int id);
    }
}
