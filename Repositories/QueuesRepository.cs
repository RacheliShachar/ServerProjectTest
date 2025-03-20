using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoFramework.Linq;
using ServerProjectMvcWithoutView.Configurations;
using ServerProjectMvcWithoutView.Data;
using ServerProjectMvcWithoutView.Models;
using ServerProjectMvcWithoutView.Repositories.Interface;

namespace ServerProjectMvcWithoutView.Repositories
{
    public class QueuesRepository : IQueuesRepository {
        
        private readonly MongoDbContext _context;

        public QueuesRepository(MongoDbContext context){
            _context = context;
        }

        public async Task AddNewQueue(CreateQueue queue){
            
            try{
                await _context.CreateQueues.InsertOneAsync(queue);
            }
            catch(Exception ex){
                throw;
            }
        }
        public async Task DeleteQueue(string id){
            try{
                await _context.Queues.DeleteOneAsync(queue => queue.Id == id);
            }
            catch(Exception ex){
                throw;
            }

        }

        public async Task<List<Queue>> GetAllQueues(){
            try{
               return await _context.Queues.Find(_ => true).ToListAsync();
            }
            catch(Exception ex){
                throw;
            }

        }


    }
}