using System.Collections.Generic;

public interface UserRepository
{
    List<User> GetUsers();
    void AddUser(User user);
    User GetByNickname(string nickname);
}
