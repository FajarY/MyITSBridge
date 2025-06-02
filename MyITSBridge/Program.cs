using System.Collections.Specialized;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MyITSBridge
{
    public static class Program
    {
        private static MainController? entrypoint;
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(new string[0]);
            builder.WebHost.UseUrls("http://0.0.0.0:8080");
            var app = builder.Build();

            entrypoint = new MainController();

            app.MapGet("/{**catchall}", ProcessRequest);
            app.MapPost("/{**catchall}", ProcessRequest);
            app.MapPut("/{**catchall}", ProcessRequest);
            app.MapDelete("/{**catchall}", ProcessRequest);

            app.Run();
        }
        public static IResult ProcessRequest(HttpRequest request)
        {
            Uri uri = new Uri(request.GetDisplayUrl());

            Queue<string> paths = new Queue<string>();
            foreach (string str in uri.Segments)
            {
                string final = str.Trim('/');
                final = '/' + final;
                paths.Enqueue(final);
            }
            if (paths.Count > 0)
            {
                paths.Dequeue();
            }

            RequestHandle handle = new RequestHandle(uri, request, Results.NotFound(), paths);
            entrypoint.ProcessRequest(handle);

            return handle.response;
        }
    }
}