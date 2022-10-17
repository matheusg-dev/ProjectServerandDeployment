 using Microsoft.AspNetCore.Mvc;

namespace ProjectServerandDeployment.Controllers;

[ApiController]
[Route("userrealm")]
public class UserRealmController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UserRealm>>  GetUserRealms(
        [FromServices]UserRealmRepository2 repo
        )
    {
        return Ok(repo. GetUserRealms());
    }

    public void AddUserRealm(UserRealm userRealm)
    {
        UserRealmRepository2 usr2 = new UserRealmRepository2();
    }
    
}
    
