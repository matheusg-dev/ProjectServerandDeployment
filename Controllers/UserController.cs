using Microsoft.AspNetCore.Mvc;

namespace ProjectServerandDeployment.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<User>> GetUsers(
        [FromServices]UserRepository repo)
    {
        return Ok(repo.GetUsers());
        
    }
     [HttpGet]
    public ActionResult<List<Score>>FindByUser(string nickname,
        [FromServices]ScoreRepository repo)
    {
        return Ok (repo.FindByUser(nickname));
        
    }
    
    [HttpPost]
    public void AddUser(User user,
    [FromServices]UserRepository repo)
    {
        repo.AddUser(user);
    }
    
}
    

