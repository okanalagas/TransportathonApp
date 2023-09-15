using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TransportathonApp.Application.Commands.Account.Register;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly ICustomerWriteRepository _customerWriteRepository;
    private readonly UserManager<AppUser> _userManager;
    private readonly ICompanyExecutiveWriteRepository _companyExecutiveWriteRepository;

    public RegisterController(ICustomerWriteRepository customerWriteRepository, UserManager<AppUser> userManager, ICompanyExecutiveWriteRepository companyExecutiveWriteRepository)
    {
        _customerWriteRepository = customerWriteRepository;
        _userManager = userManager;
        _companyExecutiveWriteRepository = companyExecutiveWriteRepository;
    }

    [HttpPost]
    [Route("CreateCustomer")]
    public async Task<IActionResult> CreateCustomer(CreateCustomerRequest createCustomerDTO)
    {
        if (ModelState.IsValid)
        {
            AppUser user = new()
            {
                UserName = createCustomerDTO.Email,
                Email = createCustomerDTO.Email,
                PhoneNumber = createCustomerDTO.PhoneNumber,
                CreatedDate = DateTime.Now
            };
            var result = await _userManager.CreateAsync(user, createCustomerDTO.Password);

            Customer customer = new()
            {
                FirstName = createCustomerDTO.FirstName,
                LastName = createCustomerDTO.LastName,
                IdentityNo = createCustomerDTO.IdentityNo,
                Address = createCustomerDTO.Address,
                Id = user.Id
            };
            await _customerWriteRepository.AddAsync(customer);
            await _customerWriteRepository.SaveAsync();
            if (result.Succeeded)
            {
                return StatusCode((int)HttpStatusCode.Created);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.BadRequest);
            }
        }
        return BadRequest();
    }

    [HttpPost]
    [Route("CreateCompanyExecutive")]
    public async Task<IActionResult> CreateCompanyExecutive(CreateCompanyExecutiveRequest createCompanyExecutiveDto)
    {
        if (ModelState.IsValid)
        {
            AppUser user = new()
            {
                UserName = createCompanyExecutiveDto.Email,
                Email = createCompanyExecutiveDto.Email,
                PhoneNumber = createCompanyExecutiveDto.PhoneNumber,
                CreatedDate = DateTime.Now
            };
            var result = await _userManager.CreateAsync(user, createCompanyExecutiveDto.Password);

            CompanyExecutive companyExecutive = new()
            {
                FirstName = createCompanyExecutiveDto.FirstName,
                LastName = createCompanyExecutiveDto.LastName,
                Id = user.Id
            };
            await _companyExecutiveWriteRepository.AddAsync(companyExecutive);
            await _companyExecutiveWriteRepository.SaveAsync();
            if (result.Succeeded)
            {
                return StatusCode((int)HttpStatusCode.Created);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.BadRequest);
            }
        }
        return BadRequest();
    }
}
