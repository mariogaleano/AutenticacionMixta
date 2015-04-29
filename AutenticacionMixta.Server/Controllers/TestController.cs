using System.Collections.Generic;
using System.Web.Http;

namespace AutenticacionMixta.Server.Controllers
{
    [Authorize]
    public class TestController : ApiController
    {
        public List<string> Get()
        {
            List<string> result =new List<string>();

            for (int i = 0; i < 100; i++)
            {
                result.Add(i.ToString());
            }
            return result;
        }
    }
}
