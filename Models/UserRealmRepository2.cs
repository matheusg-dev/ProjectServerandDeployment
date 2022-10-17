using System.Collections.Generic;

public class UserRealmRepository2 : UserRealm
{
    
    List<UserRealm> fakelist2 = new List<UserRealm>();
   
   public UserRealmRepository2()
    {
        fakelist2.Add(new UserRealm()
        {
           Score1 = 8,
           Nickname1 = "Robertinho",
           Score2 = 9,
           Nickname2 = "Robervilson"
          
        });
    }
    public List<UserRealm> GetUserRealms()
    {
        return fakelist2;
    }

    public void AddUserRealm(UserRealm userRealm)
    {
        fakelist2.Add(userRealm);
    }
}

