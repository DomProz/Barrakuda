using Application.Exceptions;
using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public AccountService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher,
            AuthenticationSettings authenticationSettings)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _authenticationSettings = authenticationSettings;
        }
        public async Task RegisterUserAsync(RegisterUserDto registerDto)
        {
            var newUser = new User()
            {
                Email = registerDto.Email,
                UserName = registerDto.UserName,
                BirthDate = registerDto.BirthDate,
                RoleId = registerDto.RoleId
            };

            var hashedPassword = _passwordHasher.HashPassword(newUser, registerDto.Password);

            newUser.PasswordHash = hashedPassword;

            await _userRepository.RegisterUserAsync(newUser);
        }

        public async Task<bool> IsMailIsTaken(string mail)
        {
            var result = await _userRepository.IsMailIsTaken(mail);
            return result;
        }
        public async Task<bool> IsUserNameIsTaken(string username)
        {
            var result = await _userRepository.IsUserNameIsTaken(username);
            return result;
        }

        public async Task<string> GenerateJwt(LoginDto dto)
        {
            var user = await _userRepository.IsUserExist(dto.Email);

            if (user is null)
            {
                throw new BadRequestException("Invalid username or password");
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Invalid username or password");
            }
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName.ToString()),
                new Claim(ClaimTypes.Role, $"{user.Role.Name}"),
                new Claim("FullName", $"{user.FirstName} {user.LastName}")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}
