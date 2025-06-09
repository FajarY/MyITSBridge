namespace MyITSBridge
{
    public class RequestCreateView : View
    {
        public override object Render(object? args = null)
        {
            string html = "Welcome to /request/create\n";
            html += "--Choose Request Group--\n";
            if (args == null)
            {
                html += "There is currently no avalaible group\n";
            }
            else if (args is List<Tuple<string, string>> requestGroupIdAndNames)
            {
                foreach (Tuple<string, string> val in requestGroupIdAndNames)
                {
                    html += $"{val.Item1} - {val.Item2}\n";
                }
            }

            return html;
        }
    }
}