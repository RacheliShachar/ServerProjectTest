using ServerProjectMvcWithoutView.Models;

namespace ServerProjectMvcWithoutView.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetUsers();
    }
}