using awesomeshopifyapp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace awesomeshopifyapp.Services
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<IEnumerable<User>> GetUsers();
        Task RemoveUser(string name);
    }
}
