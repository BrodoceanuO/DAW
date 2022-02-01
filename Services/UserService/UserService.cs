using DAW2.Data;
using DAW2.Models;
using DAW2.Models.DTOs;
using DAW2.Repository.DatabaseRepository;
using System.Linq;
using BCrypt;
using DAW2.Utilities.JWTUtils;
using System.Collections.Generic;
using System;

namespace DAW2.Services
{
    public class UserService: IUserService
    {
        public IUserRepository _userRepository;
        public DatabaseContext databaseContext;
        private IJWTUtils iJWTUtils;

        public UserService(IUserRepository userRepository)
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

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = databaseContext.Users.FirstOrDefault(x => x.UserName == model.UserName);

            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }

            //JWT Token Generation
            var jwtToken = iJWTUtils.GenerateJWTToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll().Result;
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
            _userRepository.Save();
        }

        public void DeleteUser(User user)
        {
            _userRepository.Delete(user);
            _userRepository.Save();
        }

        public void CreateUser(User user)
        {
            _userRepository.Create(user);
            _userRepository.Save();
        }

        public List<User> GetAllWithInclude()
        {
            return _userRepository.GetAllWithInclude();
        }


        public List<IGrouping<string, User>> GroupBy()
        {
            var groupUsers = _userRepository.GroupBy();
            return groupUsers;
        }

        public User GetUserById(Guid Id)
        {
            return _userRepository.GetUserById(Id);
        }
    }
}
