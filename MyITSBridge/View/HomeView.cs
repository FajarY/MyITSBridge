namespace MyITSBridge
{
    public class HomeView : View
    {
        public override object Render(object? args = null)
        {
            string val = "Welcome to /home\n";

            if (args != null && args is User user)
            {
                val += $"Name: {user.name}\n";
                val += $"Email: {user.email}\n";
                val += $"IsOperator: {user.isOperator}\n";
            }

            return val;
        }
    }
}