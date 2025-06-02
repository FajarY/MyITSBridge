namespace MyITSBridge
{
    public class HomeController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new HomeView().Render().ToString(), "text/html");
        }
    }
}