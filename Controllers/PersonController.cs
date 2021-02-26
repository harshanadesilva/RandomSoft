using MyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyApi.IService;

namespace MyApi.Controllers
{
    public class PersonController : GenericController<Person>
    {
        public PersonController(IGenericService<Person> genericService) : base(genericService)
        {
        }
    }
}
