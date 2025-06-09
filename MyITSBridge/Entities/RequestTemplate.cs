namespace MyITSBridge
{
    public class RequestTemplate
    {
        public string name;
        public RequestTemplateType type;
        public string description;
    }
    public enum RequestTemplateType
    {
        PDF,
        IMAGE,
        TEXT
    }
}