using FSD.Infrastructure.Context.Entities;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace FSD.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<JwtSecurityToken> Login(LoginModel model);
        Task<IdentityResult> Register(RegisterModel model);
        Task RegisterAdmin(RegisterModel model);
    }
}
