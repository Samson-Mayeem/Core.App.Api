namespace Core.App.Api.Models.Users
{
    public class UserConstants
    {
        public static List<User> Users = new List<User>()
        {
            new Models.Users.User()
            {
                    Id = 1, UserId = "UB0989",Email="sam@gmail.com", FirstName =" Sam", SurName = "Mayeem", Password = "1234" 
            },
        };
    }
}
