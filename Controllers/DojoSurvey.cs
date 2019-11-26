using Microsoft.AspNetCore.Mvc;
namespace dojo_survey.Controllers
{
    public class DojoSurvey : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Result(string FullName, string Location, string Language, string Comment)
        {
            ViewBag.FullName = FullName;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}