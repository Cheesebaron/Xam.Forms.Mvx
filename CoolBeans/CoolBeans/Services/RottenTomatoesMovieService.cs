using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using ModernHttpClient;

namespace CoolBeans.Services
{
    public class RottenTomatoesMovieService : IMovieService
    {
        public async Task<List<Movie>> GetMovieList(string searchTerm)
        {
            var client = new HttpClient(new NativeMessageHandler());
            var msg =
                await
                    client.GetAsync(string.Format(Constants.RottenTomatoMovieListUrl, Constants.RottenTomatoApiKey,
                        searchTerm));

            if (!msg.IsSuccessStatusCode) return null;

            var json = await msg.Content.ReadAsStringAsync();
            var converter = Mvx.Resolve<IMvxJsonConverter>();

            var obj = converter.DeserializeObject<RootObject>(json);
            return obj.movies;
        }

        public async Task<Movie> GetMovieFromId(int id)
        {
            var client = new HttpClient(new NativeMessageHandler());
            var msg =
                await
                    client.GetAsync(string.Format(Constants.RottenTomatoMovieUrl, Constants.RottenTomatoApiKey,
                        id));

            if (!msg.IsSuccessStatusCode) return null;

            var json = await msg.Content.ReadAsStringAsync();
            var converter = Mvx.Resolve<IMvxJsonConverter>();

            return converter.DeserializeObject<Movie>(json);
        }
    }
}
