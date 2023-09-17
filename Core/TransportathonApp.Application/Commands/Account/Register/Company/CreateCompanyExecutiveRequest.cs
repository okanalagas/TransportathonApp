using MediatR;

namespace TransportathonApp.Application.Commands.Account.Register;

public class CreateCompanyExecutiveRequest : IRequest<CreateCompanyExecutiveResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CompanyName { get; set; }
}
