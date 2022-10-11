using System.Collections.Generic;

public class ScoreFakeRepository : ScoreRepository
{
    
    List<Score> fakelist = new List<Score>();
   
   public ScoreFakeRepository()
    {
        fakelist.Add(new Score()
        {
           Score1 = 8,
           Score2 = 9
        });
    }
    public List<Score> GetScores()
    {
        return fakelist;
    }

    public void AddScore(Score score)
    {
        fakelist.Add(score);
    }
}
public class UserFakerRepository : UserRepository
{
    
    List<User> fakelist1 = new List<User>();
   
   public UserFakerRepository()
    {
        fakelist1.Add(new User()
        {
           Nickname1 = "Robertinho",
           Nickname2 ="Robervilson"
        });
    }
    public List<User> GetUsers()
    {
        return fakelist1;
    }

    public void AddScore(User user)
    {
        fakelist1.Add(user);
    }
}