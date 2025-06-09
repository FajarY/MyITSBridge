using Microsoft.AspNetCore.Mvc;

namespace MyITSBridge
{
    public class RequestHandle
    {
        public Uri uri;
        public HttpContext context;
        public HttpRequest request;
        public IResult response;
        public Queue<string> pathsToGo;
        public RequestHandle(Uri uri, HttpRequest request, IResult response, Queue<string> pathsToGo, HttpContext context)
        {
            this.uri = uri;
            this.request = request;
            this.response = response;
            this.pathsToGo = pathsToGo;
            this.context = context;
        }
    }
}