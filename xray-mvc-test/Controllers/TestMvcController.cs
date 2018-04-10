using System.Web.Mvc;
using XRayTest.Models;

namespace XRayTest.Controllers
{
    public class TestMvcController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            XRayTest.CreateSubsegment();

            return Json(new TestResult {Message = nameof(TestMvcController)});
        }
    }
}