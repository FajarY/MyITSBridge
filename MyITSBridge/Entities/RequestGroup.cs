namespace MyITSBridge
{
    public class RequestGroup
    {
        public string id;
        public string name;
        public List<string> staffs = new List<string>();
        public List<RequestTemplate> inputTemplates = new List<RequestTemplate>();
    }
}