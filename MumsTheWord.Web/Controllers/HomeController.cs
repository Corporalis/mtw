using MumsTheWord.Web.Models;
using MumsTheWord.Web.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MumsTheWord.Web.Controllers
{
    public class HomeController : Controller
    {
        private IApiClient _apiClient;

        public HomeController(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<ActionResult> Index()
        {
            var places = await _apiClient.GetServicesAsync();
            var model = new HomeViewModel
            {
                Results = places.Results
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}