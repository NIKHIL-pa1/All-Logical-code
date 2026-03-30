using APIWorking.DTOs;

namespace APIWorking.Repository.Interface
{
    public interface IUserService
    {
        IEnumerable<UserDtos> GetUsers();
    }
}
