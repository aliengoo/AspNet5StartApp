using System.Threading.Tasks;
using AspNet5StartApp.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace AspNet5StartApp.Repositories.Mongo
{
    public abstract class MongoRepository<T> : IRepository<T> where T : ModelBase
    {
        protected IMongoDatabase Database { get; }

        protected IMongoCollection<T> Collection { get; }

        protected MongoRepository(IConfiguration config, string collectionName, string connectionStringName = "Data:Mongo:App:ConnectionString")
        {
            var url = MongoUrl.Create(config.Get<string>(connectionStringName));

            Database = new MongoClient(url).GetDatabase(url.DatabaseName);
            Collection = Database.GetCollection<T>(collectionName);
        }

        public Task<T> FindById(string id)
        {
            return Collection.Find(t => t.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T> Update(T doc)
        {
            await Collection.UpdateOneAsync(t => t.Id == doc.Id, new ObjectUpdateDefinition<T>(doc));

            return doc;
        }

        public async Task<T> Insert(T doc)
        {
            await Collection.InsertOneAsync(doc);

            return doc;
        }

        public Task Delete(string id)
        {
            return Collection.DeleteOneAsync(t => t.Id == id);
        }
    }
}