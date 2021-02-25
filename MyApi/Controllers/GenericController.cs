using MyApi.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MyApi.Controllers
{
    public class GenericController<T> : Controller where T : class
    {
        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        // GET: api/Generic
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET: api/Generic/5
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST: api/Generic return _genericService.
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }

        // DELETE: api/Generic/5
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
    }
}
