using CMA.Model;
using CMA.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CMA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private readonly IService<Customer> _customerService;

        public CustomerController(IService<Customer> customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int id)
        {
            var result = await _customerService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return NotFound(result.Message);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var result = await _customerService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return NotFound(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            var result = await _customerService.AddAsync(customer);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
            }
            return BadRequest(result.Message);
        }
    }
}
