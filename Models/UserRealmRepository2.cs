using System.Collections.Generic;

public class UserRealmRepository2 : UserRealm
{
    
    List<UserRealm> fakelist2 = new List<UserRealm>();
    private UserRealm userRealm;

    public UserRealmRepository2(object https)
    {
        fakelist2.Add(new UserRealm()
        {
           Score1 = 8,
           Score2 = 9,
           Nickname1 = "Robertinho",
            Nickname2 = "Robervilson"
        });
    }

    public UserRealmRepository2()
    {
    }

    public List<UserRealm> GetUserRealms()
    {
        return fakelist2;
    }

    public void AddUserRealm(Score UserRealm)
    {
        fakelist2.Add(userRealm);
    }
}
