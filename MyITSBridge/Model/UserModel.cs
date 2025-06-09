namespace MyITSBridge.Models
{
    public class UserModel : Model
    {
        private static List<User> users = new List<User>();
        public override void Initialize()
        {
            users.Add(new User()
            {
                email = "5025231185@student.its.ac.id",
                name = "Kadek Fajar Pramartha Yasodana",
                password = "Password123",
                isOperator = false
            });
            users.Add(new User()
            {
                email = "bintangnuralamsyah@its.ac.id",
                name = "Bintang Nuralamsyah",
                password = "432432",
                isOperator = false
            });
            users.Add(new User()
            {
                email = "aryshiddiqi@its.ac.id",
                name = "Ary Mazharuddin Shiddiqi",
                password = "432432",
                isOperator = false
            });
            users.Add(new User()
            {
                email = "412542324@its.ac.id",
                name = "John Smith",
                password = "testoperator",
                isOperator=true
            });
        }
        public static User? GetUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}