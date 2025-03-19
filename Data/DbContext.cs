using MongoDB.Driver;
using MongoFramework;
using ServerProjectMvcWithoutView.Models;

namespace ServerProjectMvcWithoutView.Data
{
    public class MyDbContext : MongoDbContext
    {
        public MyDbContext() 
            : base(MongoDbConnection.FromConnectionString("mongodb://localhost:27017/committees")) 
        { }


        public MongoDbSet<Users> users { get; set; }
    }
}
