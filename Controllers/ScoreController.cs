using Microsoft.AspNetCore.Mvc;

namespace ProjectServerandDeployment.Controllers;
[ApiController]
[Route("score")]
public class ScoreController : ControllerBase
{

    [HttpGet]
    public async Task<Score> AddScore(Score score)
    {
    
    } 
}
