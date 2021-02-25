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
    public class PostController : GenericController<Post>
    {
        public PostController(IGenericService<Post> genericService) : base(genericService)
        {

        }
    }
}
