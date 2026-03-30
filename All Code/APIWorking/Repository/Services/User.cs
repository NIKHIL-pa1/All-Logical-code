using APIWorking.Models;
using APIWorking.Models.DbContext;
using APIWorking.Repository.Interface;

namespace APIWorking.Repository.Services
{
    public class User : IUser
    {
        public readonly AppDbContext _AppDbContext;
        public User(AppDbContext AppDbContext)
        {
            this._AppDbContext = AppDbContext;
        }

        public IEnumerable<UserModel> GetAll() => _AppDbContext.Users.ToList();

        public UserModel GetByEmail(string email) => _AppDbContext.Users.FirstOrDefault(x => x.Email == email);

    }
}
