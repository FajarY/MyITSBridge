using System.Text.Json;

namespace MyITSBridge
{
    public static class Parser
    {
        public async static Task<Dictionary<string, object>> ParseBodyJson(HttpRequest request)
        {
            string body;
            using (var reader = new StreamReader(request.Body))
            {
                body = await reader.ReadToEndAsync();
            }

            return JsonSerializer.Deserialize<Dictionary<string, object>>(body);
        }
    }
}