using System.Collections.Generic;

public class UserFakerRepository : UserRepository
{
    List<User> fakelist = new List<User>();

    public UserFakerRepository(object https)
    {
        fakelist.Add(new User()
        {
            Nickname1 = "Robertinho",
            Nickname2 = "Robervilson"
        });
    }


    public void AddUser(User user)
    {
        fakelist.Add(user);
    }
    
}