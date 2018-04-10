using System.Web.Http;
using XRayTest.Models;

namespace XRayTest.Controllers
{
    public class TestApiController : ApiController
    {
        [HttpPost]
        public TestResult Index()
        {
            XRayTest.CreateSubsegment();

            return new TestResult {Message = nameof(TestApiController)};
        }
    }
}
