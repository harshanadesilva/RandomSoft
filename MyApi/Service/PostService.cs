using MyApi.IService;
using MyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApi.Service
{
    public class PostService : IGenericService<Post>
    {
        List<Post> _post = new List<Post>();

        public PostService()
        {
            for (int i = 0; i < 9; i++)
            {
                _post.Add(new Post() {
                    Id = i,
                    Title = "Title" + i,
                    ImageUrl = "ImageUrl" + i,
                    AuthorName = "AuthorName" + i,
                    TotalLikes =+ i
                });
            }
        }

        public List<Post> Delete(int id)
        {
            _post.RemoveAll(x => x.Id == id);
            return _post;
        }

        public List<Post> GetAll()
        {
            return _post;
        }

        public Post GetById(int id)
        {
            return _post.Where(x=>x.Id==id).SingleOrDefault();
        }

        public List<Post> Insert(Post item)
        {
            _post.Add(item);
            return _post;
        }
    }
}