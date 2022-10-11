using System.Collections.Generic;

public class UserFakerRepository : UserRepository
{
    List<User> fakelist = new List<User>();

    public UserFakerRepository()
    {
        fakelist.Add(new User()
        {
            Nickname = "Robertinho"
        });
    }

    public List<User> GetUsers()
    {
        return fakelist;
    }

    public void AddUser(User user)
    {
        fakelist.Add(user);
    }
    
}