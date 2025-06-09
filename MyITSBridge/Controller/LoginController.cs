
using System.Threading.Tasks;
using MyITSBridge.Models;

namespace MyITSBridge
{
    public class LoginController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            handle.response = Results.Content(new LoginView().Render().ToString(), "text/html");
        }
        public override async void POST(RequestHandle handle)
        {
            Dictionary<string, object> body = await Parser.ParseBodyJson(handle.request);

            if (!body.TryGetValue("email", out object email) || !body.TryGetValue("password", out object password))
            {
                handle.response = Results.Json(new Dictionary<object, object>
                {
                    {
                        "error", "Invalid request body!"
                    }
                }, statusCode: 400);
                return;   
            }

            User? user = UserModel.GetUserByEmail(email.ToString());
            if (user == null || user.password != password.ToString())
            {
                handle.response = Results.Json(new Dictionary<object, object>
                {
                    {
                        "error", "Incorrect email or password!"
                    }
                }, statusCode: 404);
                return;
            }

            handle.context.Response.Cookies.Append("token", user.email, new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddDays(1),
            });
            handle.response = Results.Json(new Dictionary<object, object>
            {
                {
                    "message", "Login succesfull!"
                }
            }, statusCode: 200);
        }
    }
}