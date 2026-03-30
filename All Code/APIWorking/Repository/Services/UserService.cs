using APIWorking.DTOs;
using APIWorking.Repository.Interface;

namespace APIWorking.Repository.Services
{
    public class UserService : IUserService
    {
        private readonly IUser _userService;
        public UserService(IUser Service)
        {
            this._userService = Service;
        }

        public IEnumerable<UserDtos> GetUsers() => _userService.GetAll().Select(x => new UserDtos
        {
            Name = x.Name,
            Email = x.Email,
        });
    }
}
