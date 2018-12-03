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
    [ApiVersion("2.0")]
    [Route("api/movies")]

    public class MoviesV2Controller : ApiController
    {
        static List<MoviesV2> movies = new List<MoviesV2>()
        {
            new MoviesV2() {Id = 1, MovieName = "Wonder Woman", MovieType = "Super Hero", ProducerName = "Tom Hanks"},
            new MoviesV2() {Id = 2, MovieName = "Maze Runner", MovieType = "Super Hero", ProducerName = "Jim John"}
        };


        // GET: api/MoviesV2
        public IEnumerable<MoviesV2> Get()
        {
            return movies;
        }

        // GET: api/MoviesV2/5
        public MoviesV2 Get(int id)
        {
            return movies[id];
        }

        // POST: api/MoviesV2
        public void Post([FromBody]MoviesV2 moviesV2)
        {
            movies.Add(moviesV2);
        }

        // PUT: api/MoviesV2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MoviesV2/5
        public void Delete(int id)
        {
        }
    }
}
