using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services;

public interface IUsersService
{
    public Task<List<Users>> GetAllUsers();
}

public class UsersService : IUsersService
{
    public async Task<List<Users>> GetAllUsers()
    {
        return new List<Users>
        {
            new Users
            {
                  Id = 10
            }
        };
    }
}