using BorsaTakipSistemi.Application.Features.Auth.Login;
using BorsaTakipSistemi.Domain.Entities;

namespace BorsaTakipSistemi.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
