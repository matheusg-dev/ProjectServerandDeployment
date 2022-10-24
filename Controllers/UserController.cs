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
    [HttpPost]
    public void AddUser(User user,
    [FromServices]UserRepository repo)
    {
        repo.AddUser(user);
    }
    
}
    

