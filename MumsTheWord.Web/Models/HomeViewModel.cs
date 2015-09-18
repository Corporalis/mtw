using MumsTheWord.Web.Services;

namespace MumsTheWord.Web.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Results = new Result[0];
        }

        public Result[] Results { get; set; }
    }
}