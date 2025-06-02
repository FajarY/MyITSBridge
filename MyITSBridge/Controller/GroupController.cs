
namespace MyITSBridge
{
    public class GroupController : Controller
    {
        public override Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>()
            {
                {
                    "/create", new GroupCreateController()
                }
            };
        }
    }
}