using AspNet5StartApp.Models;
using Microsoft.Extensions.Configuration;

namespace AspNet5StartApp.Repositories.Mongo
{
    public class PersonRespository : MongoRepository<Person>
    {
        public PersonRespository(
            IConfiguration config) : base(config, nameof(Person))
        {
        }
    }
}