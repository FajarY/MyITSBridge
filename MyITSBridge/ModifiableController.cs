namespace MyITSBridge
{
    public class ModifiableController : Controller
    {
        public Action<RequestHandle>? GETAction;
        public Action<RequestHandle>? POSTAction;
        public Action<RequestHandle>? PUTAction;
        public Action<RequestHandle>? DELETEAction;

        public override void GET(RequestHandle handle)
        {
            GETAction?.Invoke(handle);
        }
        public override void POST(RequestHandle handle)
        {
            POSTAction?.Invoke(handle);
        }
        public override void PUT(RequestHandle handle)
        {
            PUTAction?.Invoke(handle);
        }
        public override void DELETE(RequestHandle handle)
        {
            DELETEAction?.Invoke(handle);
        }
    }
}