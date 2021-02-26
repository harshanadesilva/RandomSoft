using MyApi.IService;
using MyApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MyApi.Service
{
    public class PersonService : IGenericService<Person>
    {
        string Baseurl = "https://60377f0e54350400177228df.mockapi.io/";
        List<Person> _person = new List<Person>();

        public PersonService()
        {
            for (int i = 0; i < 9; i++)
            {
                _person.Add(new Person()
                {
                    Id = i,
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Email = "Email" + i
                });
            }
        }

        public List<Person> Delete(int id)
        {
            _person.RemoveAll(x => x.Id == id);
            return _person;
        }

        public List<Person> GetAll()
        {
            return _person;
        }

        public Person GetById(int id)
        {
            return _person.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Person> Insert(Person item)
        {
            _person.Add(item);
            return _person;
        }
    }
}