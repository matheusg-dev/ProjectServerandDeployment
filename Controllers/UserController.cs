using Microsoft.AspNetCore.Mvc;

namespace ProjectServerandDeployment.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{

    [HttpGet]
    public IEnumerable<User> Get([FromServices]UserRepository repo)
    {
        
        return repo.GetUsers();
    }

    public object GetUsers(User usr)
    {
        return fakelist;
    }
     public void AddUser(User user)
    {
        UserFakerRepository usr = new UserFakerRepository();
        
    }
    
}
    

