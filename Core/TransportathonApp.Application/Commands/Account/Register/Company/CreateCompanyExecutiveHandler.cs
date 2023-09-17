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
    private readonly ICompanyWriteRepository _companyWriteRepository;

    public CreateCompanyExecutiveHandler(ICompanyExecutiveWriteRepository companyExecutiveWriteRepository, UserManager<AppUser> userManager, ICompanyWriteRepository companyWriteRepository)
    {
        _companyExecutiveWriteRepository = companyExecutiveWriteRepository;
        _userManager = userManager;
        _companyWriteRepository = companyWriteRepository;
    }

    public async Task<CreateCompanyExecutiveResponse> Handle(CreateCompanyExecutiveRequest request, CancellationToken cancellationToken)
    {
        AppUser user = new()
        {
            UserName = request.Email,
            Email = request.Email
        };
        var result = await _userManager.CreateAsync(user, request.Password);

        Company company = new()
        {
            CompanyExecutiveId = user.Id,
            Name = request.CompanyName
        };

        CompanyExecutive companyExecutive = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Id = user.Id,
            CompanyId = user.Id
        };


        if (result.Succeeded)
        {
            await _companyWriteRepository.AddAsync(company);
            await _companyExecutiveWriteRepository.AddAsync(companyExecutive);
            await _companyExecutiveWriteRepository.SaveAsync();
            return new();
        }
        else
            return new();
    }
}
