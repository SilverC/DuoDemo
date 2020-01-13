using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DuoDemo.Authentication
{
    public class DuoTokenProvider<TUser> : IUserTwoFactorTokenProvider<TUser>
        where TUser : class
    {
        Task<bool> IUserTwoFactorTokenProvider<TUser>.CanGenerateTwoFactorTokenAsync(UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(true);
        }

        Task<string> IUserTwoFactorTokenProvider<TUser>.GenerateAsync(string purpose, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult("duo");
        }

        Task<bool> IUserTwoFactorTokenProvider<TUser>.ValidateAsync(string purpose, string token, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(true);
        }
    }
}
