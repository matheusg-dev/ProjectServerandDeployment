using System;
using System.Collections.Generic;

public class UserFakerRepository : UserRepository
{
    List<User> fakelist = new List<User>();

    public UserFakerRepository(object https)
    {
        fakelist.Add(new User()
        {
            Nickname = "Robertinho",
            
        });
        
        fakelist.Add(new User()
        {
            Nickname = "Robervilson",
            
        });
        
        fakelist.Add(new User()
        {
            Nickname = "Leonardo",
            
        });
        
        fakelist.Add(new User()
        {
            Nickname = "Juarei",
            
        });

         fakelist.Add(new User()
        {
            Nickname = "Cleiton",
            
        });

         fakelist.Add(new User()
        {
            Nickname = "Paulo",
            
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

    public User GetByNickname(string nickname)
    {
        foreach(User user in fakelist)
        {
           if (user.Nickname == nickname)
           {
               return user;
           }
        }
        return null;
    }
}
















