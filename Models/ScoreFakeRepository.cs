using System.Collections.Generic;

public class ScoreFakeRepository : ScoreRepository
{
    
    List<Score> fakelist2 = new List<Score>();
   
   public ScoreFakeRepository()
    {
        fakelist2.Add(new Score()
        {
           Score1 = 8,
           Nickname1 = "Robertinho",
           Score2 = 9,
           Nickname2 = "Robervilson"
          
        });
    }

    public  List<Score> GetScores()
    {
        return fakelist2;
    }

    public void AddScore(Score score)
    {
        fakelist2.Add(score);
    }
    public List<Score> FindByUser(string nickname)
    {
        
    }
}

