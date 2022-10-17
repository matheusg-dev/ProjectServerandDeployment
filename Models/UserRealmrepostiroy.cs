using System.Collections.Generic;

public interface UserRealmRepository{
    List<Score> GetUserRealms();
    void AddUserRealm(UserRealm userRealm);
}