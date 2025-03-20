using MongoDB.Driver;
using ServerProjectMvcWithoutView.Models;
using Microsoft.Extensions.Options;
using ServerProjectMvcWithoutView.Configurations;

namespace ServerProjectMvcWithoutView.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(AppSettings appSettings)
        {
            var client = new MongoClient(appSettings.ConnectionString);
            _database = client.GetDatabase(appSettings.DatabaseName);
        }

        public IMongoCollection<Queue> Queues => _database.GetCollection<Queue>("queues");
        public IMongoCollection<CreateQueue> CreateQueues => _database.GetCollection<CreateQueue>("queues");

    }
}
