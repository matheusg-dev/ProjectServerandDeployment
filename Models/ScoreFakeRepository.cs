using System.Collections.Generic;

public class ScoreFakeRepository : ScoreRepository
{
    List<Score> fakelist = new List<Score>();
   
   public ScoreFakeRepository()
    {
        fakelist.Add(new Score()
        {
           Score1 = 8
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