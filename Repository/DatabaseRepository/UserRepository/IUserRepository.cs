using DAW2.Models;
using DAW2.Repository.GenericRepository;
using System.Collections.Generic;

namespace DAW2.Repository.DatabaseRepository
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User GetByLastName(string LastName);


        //User GetByUserNameIncludingSubscription(string UserName);

        //List<User> GetAllWithInclude();

    }
}
