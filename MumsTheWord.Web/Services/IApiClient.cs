using System.Threading.Tasks;

namespace MumsTheWord.Web.Services
{
    public class Places
    {
        public Result[] Results { get; set; }
    }

    public class Result
    {
        public Geometry Geometry { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
    }

    public class Location
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
    }

    public interface IApiClient
    {
        Task<Places> GetServicesAsync();
    }
}
