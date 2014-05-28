using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoolBeans.Services
{
    public interface IRottenTomatoesService
    {
        Task<List<Movie>> GetMovieList(string searchTerm);
        Task<Movie> GetMovieFromId(int id);
    }
}
