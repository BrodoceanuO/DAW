using DAW2.Data;
using DAW2.Models;
using DAW2.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAW2.Repository.DatabaseRepository
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {

        public UserRepository(DatabaseContext context): base(context)
        {

        }

        public User GetByLastName(string LastName)
        {
            return _table.FirstOrDefault(x => x.UserName.ToLower().Equals(LastName.ToLower()));
        }

        
        public List<User> GetAllWithInclude()
        {
            return _table.Include(x => x.Subscription).ToList();
        }
        

        public List<IGrouping<string,User>> GroupBy()
        {
            var groupUsers = _table.GroupBy(x => x.LastName).ToList();
            return groupUsers;
        }

        public User GetUserById(Guid Id)
        {
            return _table.Where(x => x.Id == Id).FirstOrDefault();
        }


    }
}
