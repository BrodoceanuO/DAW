using DAW2.Models;
using DAW2.Models.DTOs;
using System;
using System.Collections.Generic;

namespace DAW2.Services
{
    public interface IUserService
    {
        UserResultDTO GetDataMappedByLastName(string LastName);

        //Auth
        UserResponseDTO Authenticate(UserRequestDTO model);

        //GET
        List<User> GetAllUsers();

        //UPDATE
        void UpdateUser(User user);

        //DELETE
        void DeleteUser(User user);

        //CREATE
        void CreateUser(User user);

        //GetById
        //User GetById(Guid id);
        
    }
}
