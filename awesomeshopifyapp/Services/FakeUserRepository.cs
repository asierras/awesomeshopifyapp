using awesomeshopifyapp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace awesomeshopifyapp.Services
{
    public class FakeUserRepository : IUserRepository
    {
        List<User> _users;

        public FakeUserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Name = "Pepe",
                    Surname = "Real",
                    Email = "pepe.real@gmail.com"
                },
                new User
                {
                    Name = "Paco",
                    Surname = "Gipsy",
                    Email = "paco.gipsy@gmail.com"
                }
            };
        }

        public Task AddUser(User user)
        {
            _users.Add(user);

            return Task.CompletedTask;
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return Task.FromResult<IEnumerable<User>>(_users);
        }

        public Task RemoveUser(string name)
        {
            _users.Remove(_users.Find(x => x.Name == name));

            return Task.CompletedTask;
        }
    }
}
