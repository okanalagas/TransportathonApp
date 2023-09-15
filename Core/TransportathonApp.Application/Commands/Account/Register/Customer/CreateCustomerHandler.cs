using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Net;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Application.Commands.Account.Register;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    private readonly ICustomerWriteRepository _customerWriteRepository;
    private readonly UserManager<AppUser> _userManager;

    public CreateCustomerHandler(ICustomerWriteRepository customerWriteRepository, UserManager<AppUser> userManager)
    {
        _customerWriteRepository = customerWriteRepository;
        _userManager = userManager;
    }

    public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        AppUser user = new()
        {
            UserName = request.Email,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
        var result = await _userManager.CreateAsync(user, request.Password);

        Customer customer = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            IdentityNo = request.IdentityNo,
            Address = request.FirstName,
            Id = user.Id
        };
        await _customerWriteRepository.AddAsync(customer);
        await _customerWriteRepository.SaveAsync();
        if (result.Succeeded)
            return new();
        else
            return null;
        
    }
}
