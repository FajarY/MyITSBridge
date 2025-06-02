
namespace MyITSBridge
{
    public class RequestCreateController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new RequestCreateView().Render().ToString(), "text/html");
        }
    }
}