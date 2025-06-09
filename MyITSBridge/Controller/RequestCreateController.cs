
using MyITSBridge.Models;

namespace MyITSBridge
{
    public class RequestCreateController : Controller
    {
        public override void GET(RequestHandle handle)
        {
            if (!handle.request.Cookies.TryGetValue("token", out string cookieValue))
            {
                handle.response = Results.Content("Unaothorized!", "text/html", statusCode: 401);
                return;
            }

            List<Tuple<string, string>> requestGroupIdAndNames = RequestGroupModel.GetRequestGroupIDAndTypes();
            handle.response = Results.Content(new RequestCreateView().Render(requestGroupIdAndNames).ToString(), "text/html");
        }
    }
}