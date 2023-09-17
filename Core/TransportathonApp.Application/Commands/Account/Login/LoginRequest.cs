using MediatR;

namespace TransportathonApp.Application.Commands.Account.Login;

public class LoginRequest : IRequest<LoginResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsPersistent { get; set; }
}
