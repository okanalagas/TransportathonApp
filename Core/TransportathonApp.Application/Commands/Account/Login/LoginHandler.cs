using MediatR;
using Microsoft.AspNetCore.Identity;
using TransportathonApp.Application.Exceptions;
using TransportathonApp.Domain.Entities.Identity;

namespace TransportathonApp.Application.Commands.Account.Login;

public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public LoginHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        AppUser user;

        user = await _userManager.FindByEmailAsync(request.Email);

        if (user != null)
        {            
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.IsPersistent, false);
            if (!result.Succeeded)
                throw new LoginFailException();
            return new()
            
            {
                Path = (await _userManager.GetRolesAsync(user)).Contains("Customer") ? "Customer" : "Company"
            };
        }
        throw new LoginFailException();
    }
}
