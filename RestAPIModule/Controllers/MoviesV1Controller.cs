using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;
using RestAPIModule.Models;

namespace RestAPIModule.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/movies")]

    public class MoviesV1Controller : ApiController
    {

        static List<MoviesV1> movies = new List<MoviesV1>()
        {
            new MoviesV1() {Id = 1, MovieName = "Thor", MovieType = "Super Hero"},
            new MoviesV1() {Id = 2, MovieName = "Iron Man", MovieType = "Super Hero"},
            new MoviesV1() {Id = 3, MovieName = "Fast and Furious", MovieType = "Racing"}


        };


        // GET: api/MoviesV1
        public IEnumerable<MoviesV1> Get()
        {
            //return new string[] { "value1", "value2" };
            return movies;
        }

        // GET: api/MoviesV1/5
        public MoviesV1 Get(int id)
        {
            return movies[id];
        }

        // POST: api/MoviesV1
        public void Post([FromBody]MoviesV1 moviesV1)
        {
            movies.Add(moviesV1);
        }

        // PUT: api/MoviesV1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MoviesV1/5
        public void Delete(int id)
        {
        }
    }
}
