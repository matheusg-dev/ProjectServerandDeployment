using System.Collections.Generic;

public interface ScoreRepository
{
    List<Score> GetScores();
    void AddScore(Score score);
    List<Score> FindByUser(string nickname);
}