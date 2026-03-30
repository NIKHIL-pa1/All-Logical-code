using APIWorking.Models;

namespace APIWorking.Repository.Interface
{
    public interface IUser
    {
        IEnumerable<UserModel> GetAll();

        UserModel GetByEmail(string email);
    }
}
