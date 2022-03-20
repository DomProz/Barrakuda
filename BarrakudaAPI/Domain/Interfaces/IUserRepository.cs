using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task RegisterUserAsync(User user);
        Task<User> IsUserExist(string email);
        Task<bool> IsMailIsTaken(string mail);
        Task<bool> IsUserNameIsTaken(string username);
    }
}
