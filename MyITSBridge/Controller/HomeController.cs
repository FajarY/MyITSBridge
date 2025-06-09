using MyITSBridge.Models;

namespace MyITSBridge
{
    public class HomeController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            if (!handle.request.Cookies.TryGetValue("token", out string cookieValue))
            {
                handle.response = Results.Content("Unaothorized!", "text/html", statusCode: 401);
                return;
            }
            User user = UserModel.GetUserByEmail(cookieValue);

            handle.response = Results.Content(new HomeView().Render(user).ToString(), "text/html");
        }
    }
}