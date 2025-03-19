using System;
using MongoFramework.Linq;
using ServerProjectMvcWithoutView.Data;
using ServerProjectMvcWithoutView.Models;
using ServerProjectMvcWithoutView.Repositories.Interface;

namespace ServerProjectMvcWithoutView.Repositories
{
    public class UserRepository : IUserRepository {
        
        private readonly MyDbContext _context;

        public UserRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            try{
                var users = await _context.users.ToListAsync();
                return users;
                // var users = await _context.users.add.ToListAsync();

                // Users user = new Users();
                // user.Name = "Yael";
                // user.Age = 4;

                
                // _context.users.Add(user);
                // await _context.SaveChangesAsync();

                // return null;
            }
            catch(Exception ex){
                throw;
            }
        }

    }
}