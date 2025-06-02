
namespace MyITSBridge
{
    public class RequestController : Controller
    {
        public override Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>()
            {
                {
                    "/create", new RequestCreateController()
                }
            };
        }
    }
}