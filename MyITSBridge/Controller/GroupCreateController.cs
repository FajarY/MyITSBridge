
namespace MyITSBridge
{
    public class GroupCreateController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new GroupCreateView().Render().ToString(), "text/html");
        }
    }
}