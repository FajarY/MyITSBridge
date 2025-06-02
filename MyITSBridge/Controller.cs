namespace MyITSBridge
{
    public class Controller
    {
        //Composite
        protected Dictionary<string, Controller> childs = new Dictionary<string, Controller>();
        
        public Controller()
        {
            childs = CreateChilds();
        }
        //Factory Method
        public virtual Dictionary<string, Controller> CreateChilds()
        {
            return new Dictionary<string, Controller>();
        }
        //Template Method Skeleton
        public void ProcessRequest(RequestHandle handle)
        {
            bool executeNow = false;

            if (handle.pathsToGo.Count == 0)
            {
                executeNow = true;
            }
            else
            {
                string traverse = handle.pathsToGo.Dequeue();
                if (childs.TryGetValue(traverse, out Controller nextController))
                {
                    nextController.ProcessRequest(handle);
                }
            }

            if (executeNow)
            {
                switch (handle.request.Method)
                {
                    case "GET":
                        GET(handle);
                        break;
                    case "POST":
                        POST(handle);
                        break;
                    case "PUT":
                        PUT(handle);
                        break;
                    case "DELETE":
                        DELETE(handle);
                        break;
                }
            }
        }

        //Template Methods
        public virtual void GET(RequestHandle handle)
        {

        }
        public virtual void POST(RequestHandle handle)
        {

        }
        public virtual void PUT(RequestHandle handle)
        {

        }
        public virtual void DELETE(RequestHandle handle)
        {

        }
    }
}