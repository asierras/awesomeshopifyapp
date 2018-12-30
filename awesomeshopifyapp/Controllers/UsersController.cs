using AutoMapper;
using awesomeshopifyapp.Model;
using awesomeshopifyapp.Model.FacebookModel;
using awesomeshopifyapp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awesomeshopifyapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserRepository _userRepository;
        IMapper _mapper;
        private ICache<FbUser> _cache;

        public UsersController(IUserRepository userRepository, IMapper mapper, ICache<FbUser> cache)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _cache = cache;
        }

        [HttpDelete("{name}")]
        public async Task DeleteUser([FromRoute]string name)
        {
            await _userRepository.RemoveUser(name);
        }

        [HttpGet("{name}")]
        public async Task<User> GetUser([FromRoute] string name)
        {
            return (await _userRepository.GetUsers()).FirstOrDefault(x => x.Name == name);
        }

        [HttpGet]
        public Task<IEnumerable<User>> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        [HttpPost]
        public async Task PostUser(User user)
        {
            await _userRepository.AddUser(user);
        }

        [HttpPost("fb")]
        public async Task PostFbUser(FbUser fbUser)
        {
            User user = _mapper.Map<User>(fbUser);
            await _userRepository.AddUser(user);
        }
    }
}