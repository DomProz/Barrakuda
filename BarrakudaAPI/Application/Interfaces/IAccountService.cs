using Application.Models;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAccountService
    {
        Task<string> GenerateJwt(LoginDto dto);
        Task RegisterUserAsync(RegisterUserDto registerDto);
        Task<bool> IsMailIsTaken(string mail);
        Task<bool> IsUserNameIsTaken(string username);
    }
}
