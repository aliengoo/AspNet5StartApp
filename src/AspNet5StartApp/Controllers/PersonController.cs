using System.Threading.Tasks;
using AspNet5StartApp.Models;
using AspNet5StartApp.Repositories;
using Microsoft.AspNet.Mvc;

namespace AspNet5StartApp.Controllers
{
    [Route("api/[controller]")]
    public class PersonController
    {
        private readonly IRepository<Person> _personRepository;

        public PersonController(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        /// <summary>
        /// GET /api/person/id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<Person> Get(string id)
        {
            return _personRepository.FindById(id);
        }

        [HttpPut("{id}")]
        public Task<Person> Put([FromBody]Person person)
        {
            return _personRepository.Update(person);
        }

        [HttpPost]
        public Task<Person> Post([FromBody]Person person)
        {
            return _personRepository.Insert(person);
        }

        [HttpDelete("{id}")]
        public Task Delete(string id)
        {
            return _personRepository.Delete(id);
        }
    }
}