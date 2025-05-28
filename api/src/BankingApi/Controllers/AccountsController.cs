namespace BankingApi.Controllers;

using BankingApi.Model;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly BankingSystemFacade facade;

    public AccountsController(BankingSystemFacade facade)
    {
        this.facade = facade;
    }

    [HttpGet]
    public IActionResult GetAccounts()
    {
        return Ok();
    }
}
