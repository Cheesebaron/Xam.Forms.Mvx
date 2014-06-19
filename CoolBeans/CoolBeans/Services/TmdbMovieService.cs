using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ModernHttpClient;

namespace CoolBeans.Services
{
    public class TmdbMovieService : IMovieService
    {
        public Task<List<Movie>> GetMovieList(string searchTerm)
        {
            var client = new HttpClient(new NativeMessageHandler());
        }

        public Task<Movie> GetMovieFromId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
