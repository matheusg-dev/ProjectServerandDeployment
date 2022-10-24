using Microsoft.AspNetCore.Mvc;
namespace ProjectServerandDeployment.Controllers;

[ApiController]
[Route("score")]
public class ScoreController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Score>> GetScores(
        [FromServices]ScoreRepository repo)
    {
        return Ok(repo.GetScores());
    }

    [HttpPost]
    public void AddScore(Score score,
     [FromServices]ScoreRepository repo)
    {
        repo.AddScore(score);
    }
    
}