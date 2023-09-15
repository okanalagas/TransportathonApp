using MediatR;
using Microsoft.AspNetCore.Identity;
using TransportathonApp.Application.Repositories;
using TransportathonApp.Domain.Entities;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Application.Commands.Account.Register;

public class CreateCompanyExecutiveHandler : IRequestHandler<CreateCompanyExecutiveRequest, CreateCompanyExecutiveResponse>
{
    private readonly ICompanyExecutiveWriteRepository _companyExecutiveWriteRepository;
    private readonly UserManager<AppUser> _userManager;

    public CreateCompanyExecutiveHandler(ICompanyExecutiveWriteRepository companyExecutiveWriteRepository, UserManager<AppUser> userManager)
    {
        _companyExecutiveWriteRepository = companyExecutiveWriteRepository;
        _userManager = userManager;
    }

    public async Task<CreateCompanyExecutiveResponse> Handle(CreateCompanyExecutiveRequest request, CancellationToken cancellationToken)
    {
        AppUser user = new()
        {
            UserName = request.Email,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
        var result = await _userManager.CreateAsync(user, request.Password);

        CompanyExecutive companyExecutive = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Id = user.Id
        };
        await _companyExecutiveWriteRepository.AddAsync(companyExecutive);
        await _companyExecutiveWriteRepository.SaveAsync();
        if (result.Succeeded)
            return new();
        else
            return new();
    }
}
