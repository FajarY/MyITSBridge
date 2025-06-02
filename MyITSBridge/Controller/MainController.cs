namespace MyITSBridge
{
    public class MainController : Controller
    {
        public override Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>()
            {
                {
                    "/home", new HomeController()
                },
                {
                    "/login", new LoginController()
                },
                {
                    "/api", new APIController()
                },
                {
                    "/request", new RequestController()
                },
                {
                    "/group", new GroupController()
                }
            };
        }
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new WelcomeView().Render().ToString(), "text/html");
        }
    }
}