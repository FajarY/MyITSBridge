namespace MyITSBridge
{
    public class APIUserController : Controller
    {
        public override Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>()
            {
                {
                    "/exists", new ModifiableController()
                    {
                        GETAction = (RequestHandle handle) =>
                        {
                            handle.response = Results.Content("Checking if a user exists", "text/html");
                        }
                    }
                }
            };
        }
    }
}