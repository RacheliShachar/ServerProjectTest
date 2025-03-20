using ServerProjectMvcWithoutView.Models;

namespace ServerProjectMvcWithoutView.Repositories.Interface
{
    public interface IQueuesRepository
    {
        Task AddNewQueue(CreateQueue queue);
        Task DeleteQueue(string id);
        Task<List<Queue>> GetAllQueues(); 
    }
}