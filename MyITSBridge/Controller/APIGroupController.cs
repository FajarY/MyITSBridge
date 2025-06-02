namespace MyITSBridge
{
    public class APIGroupController : Controller
    {
        public override void POST(RequestHandle handle)
        {
            handle.response = Results.Json(new Dictionary<object, object>
            {
                {
                    "id", Guid.NewGuid()
                }
            });
        }
    }
}