using System.Collections.Specialized;
using System.Reflection;
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

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.Namespace == "MyITSBridge.Models" && type.IsSubclassOf(typeof(Model)))
                {
                    Model model = (Model)Activator.CreateInstance(type);
                    model.Initialize();
                }
            }

            app.MapGet("/{**catchall}", ProcessRequest);
            app.MapPost("/{**catchall}", ProcessRequest);
            app.MapPut("/{**catchall}", ProcessRequest);
            app.MapDelete("/{**catchall}", ProcessRequest);

            app.Run();
        }
        public static IResult ProcessRequest(HttpContext context)
        {
            Uri uri = new Uri(context.Request.GetDisplayUrl());

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

            RequestHandle handle = new RequestHandle(uri, context.Request, Results.NotFound(), paths, context);
            entrypoint.ProcessRequest(handle);

            return handle.response;
        }
    }
}