using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;


namespace WebApplication1;


[ApiController]
[Route("api/")]
public class ApiController : ControllerBase
{
    private readonly IDatabaseService _databaseService;

    public ApiController(IDatabaseService databaseService)
    {
        _databaseService = databaseService;
    }
    
    [HttpGet("accounts/{id:int}")]
    public async Task<IActionResult> GetAccount(int id)
    {
            var account = await _databaseService.GetAccountByIdAsync(id);
            
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
    }
}