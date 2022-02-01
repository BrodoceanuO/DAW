using DAW2.Models;
using DAW2.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAW2.Repository.DatabaseRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User GetByLastName(string LastName);


        //User GetByUserNameIncludingSubscription(string UserName);

        //List<User> GetAllWithInclude();

        List<User> GetAllWithInclude();

        List<IGrouping<string, User>> GroupBy();

        User GetUserById(Guid Id);

    }
}
