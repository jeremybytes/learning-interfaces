using PersonRepository.Interface;
using System;
using System.Configuration;

namespace PeopleViewer
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string repositoryTypeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repositoryType = Type.GetType(repositoryTypeName);
            object repository = Activator.CreateInstance(repositoryType);
            return repository as IPersonRepository;
        }
    }
}
