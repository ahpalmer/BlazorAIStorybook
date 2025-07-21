using MongoDB.Driver;
using BlazorAIStorybook.Core.Models;

namespace BlazorAIStorybook.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<StoryRequestModel> StoryRequests => _database.GetCollection<StoryRequestModel>("StoryRequests");
        // Add more collections as needed
    }

    public class StoryRequestRepository
    {
        private readonly IMongoCollection<StoryRequestModel> _collection;

        public StoryRequestRepository(MongoDbContext context)
        {
            _collection = context.StoryRequests;
        }

        public async Task<List<StoryRequestModel>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<StoryRequestModel?> GetByIdAsync(string id)
        {
            return await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(StoryRequestModel model)
        {
            await _collection.InsertOneAsync(model);
        }

        public async Task UpdateAsync(string id, StoryRequestModel model)
        {
            await _collection.ReplaceOneAsync(x => x.Id == id, model);
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
