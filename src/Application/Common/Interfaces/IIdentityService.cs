using Application.Common.Models;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(long userId);

        Task<(Result Result, long UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(long userId);
    }
}