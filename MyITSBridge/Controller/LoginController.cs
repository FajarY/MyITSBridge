
namespace MyITSBridge
{
    public class LoginController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new LoginView().Render().ToString(), "text/html");
        }
        public override void POST(RequestHandle handle)
        {
            handle.response = Results.Json(new Dictionary<object, object>
            {
                {
                    "cookie", Guid.NewGuid()
                }
            });
        }
    }
}