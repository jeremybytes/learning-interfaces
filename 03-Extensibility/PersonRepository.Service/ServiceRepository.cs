using PersonRepository.Interface;
using PersonRepository.Service.MyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        PersonServiceClient proxy = new PersonServiceClient();

        public IEnumerable<Person> GetPeople()
        {
            return proxy.GetPeople();
        }

        public Person GetPerson(string lastName)
        {
            return proxy.GetPerson(lastName);
        }

        public void AddPerson(Person newPerson)
        {
            proxy.AddPerson(newPerson);
        }

        public void DeletePerson(string lastName)
        {
            proxy.DeletePerson(lastName);
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            proxy.UpdatePeople(updatedPeople.ToArray());
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            proxy.UpdatePerson(lastName, updatedPerson);
        }
    }
}
