using Microsoft.AspNetCore.Mvc;
namespace ProjectServerandDeployment.Controllers;
[ApiController]
[Route("Score")]
public class ScoreController : ControllerBase
{
[HttpGet]
    public ActionResult<List<Score>> GetScores(
        [FromServices]ScoreRepository repo)
    {
        return Ok(repo.GetScores());
    }

     public void AddScore(Score score)
    {
        ScoreFakeRepository scr = new ScoreFakeRepository();
        
    }
    
}