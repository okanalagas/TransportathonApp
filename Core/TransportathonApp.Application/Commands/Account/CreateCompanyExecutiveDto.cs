namespace TransportathonApp.Application.Commands.Account;

public class CreateCompanyExecutiveDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long IdentityNo { get; set; }
    public string Address { get; set; }
}
