namespace MyITSBridge
{
    public class APIController : Controller
    {
        public override Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>()
            {
                {
                    "/user", new APIUserController()
                },
                {
                    "/group", new APIGroupController()
                }
            };
        }
    }
}