using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using EntityModel;
using System.Threading.Tasks;

namespace DAC.Db_Operations
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        public UserRepository(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            var user = new UserModel()
            {
                Name = userModel.FirstName,
                Email = userModel.Email,
                UserName = userModel.Email
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);
            
            return result;
        }

        public async Task<SignInResult> PasswordLogInAsync(SignInUserModel user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
            return result;
        }

    }
}
