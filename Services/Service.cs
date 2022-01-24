using DAW2.Models;
using DAW2.Models.DTOs;
using DAW2.Repository.DatabaseRepository;

namespace DAW2.Services
{
    public class Service: IService
    {
        public IUserRepository _userRepository;

        public Service(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserResultDTO GetDataMappedByLastName(string LastName)
        {
            User user = _userRepository.GetByLastName(LastName);

            UserResultDTO result = new UserResultDTO()
            {
                LastName = user.LastName,
                FirstName = user.FirstName
            };
            return result;

        }
    }
}
