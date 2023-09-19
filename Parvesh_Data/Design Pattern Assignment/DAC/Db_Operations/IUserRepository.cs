using EntityModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DAC.Db_Operations
{
    public interface IUserRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordLogInAsync(SignInUserModel user);
    }
}