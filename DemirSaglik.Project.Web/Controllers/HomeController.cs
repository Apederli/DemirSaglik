using DemirSaglik.Project.Business.Concrete.ApiService;
using DemirSaglik.Project.Entities;
using DemirSaglik.Project.Web.Attiributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemirSaglik.Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserApiService _userApiService;

        private readonly MovieService _movieService;

        public HomeController(UserApiService userApiService, MovieService movieService)
        {
            _userApiService = userApiService;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            if (ModelState.IsValid)
            {
                var login = _userApiService.LoginAsync(user);

                if (login.Result == true)
                {
                    HttpContext.Session.SetString("Name", user.Name);

                    return RedirectToAction("Privacy");
                }

            }

            return View();
        }
        [UserNeeded]
        public IActionResult Privacy()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        public JsonResult GetMovieByTitle(string title)
        {
           var list= _movieService.JsonList(title);

            return Json(list);
        }


    }
}
