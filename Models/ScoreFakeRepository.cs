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
        
        fakelist2.Add(new Score()
        {
           Score1 = 8,
           Nickname1 = "Leonardo",
           Score2 = 9,
           Nickname2 = "Juarei"
          
        });
        
        fakelist2.Add(new Score()
        {
           Score1 = 8,
           Nickname1 = "Cleiton",
           Score2 = 9,
           Nickname2 = "Paulo"
          
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
        List<Score> scores = new List<Score>();
        
        foreach(Score score in fakelist2)
        {
           if (score.Nickname1 == nickname)
           {
               scores.Add(score);
           }
           if (score.Nickname2 == nickname)
           {
               scores.Add(score);
           }    
        }

        return scores;
    }
}