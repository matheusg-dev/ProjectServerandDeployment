using Microsoft.AspNetCore.Mvc;

namespace ProjectServerandDeployment.Controllers;
[ApiController]
[Route("Armazenador")]
public class ArmazenadorController : ControllerBase
{

    [HttpGet]
    public async Task<Armazenador> AddArmazenador(Armazenador armazenador)
    {
    
    } 
}