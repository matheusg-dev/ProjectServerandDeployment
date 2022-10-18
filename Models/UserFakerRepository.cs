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
    }

    public List<User> GetUsers()
    {
        return fakelist;
    }

    public void AddUser(User user)
    {
        fakelist.Add(user);
    }

   public class Score
   {
       public static void Main()
       {
           List<string> Nickname = new List<string>() { "Robertinho", "Robervilson"};

           foreach (var i in Nickname) {


               Console.WriteLine(Nickname);

           }

       }
   }
}
   
    
    

